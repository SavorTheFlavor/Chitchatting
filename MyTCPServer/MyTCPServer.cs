using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace MyServer
{
    /// <summary>
    /// 基于socket实现的TCP服务器
    /// </summary>
    public class MyTCPServer
    {
        /// <summary>
        /// 最大连接数
        /// </summary>
        private const int MAXCONNECTION = 1024;

        private Socket serverSock;

        private List<ClientHandler> clientList;

        public List<ClientHandler> ClientList {//表示字段只能通过get、set访问器访问
            get { return clientList; }
            set { clientList = value; }
        }

        public List<String> onlineMsgList;


        public bool IsRunning { get; private set; }
        public IPAddress Address { get; private set; }
        public int Port { get; private set; }
        public Encoding Encoding { get; set; }
        private ServerLogger logger;

        public ServerLogger Logger {
            get { return logger; }
            set { logger = value; }
        }


        #region 构造函数

        public MyTCPServer(int listenPort)
            : this(new IPEndPoint(IPAddress.Any, listenPort))
        {
        }

        public MyTCPServer(IPEndPoint localEP)
            : this(localEP.Address, localEP.Port)
        {
        }

        /// <summary>
        /// 同步Socket TCP服务器
        /// </summary>
        /// <param name="localIPAddress">监听的IP地址</param>
        /// <param name="listeningPort">监听的端口</param>
        public MyTCPServer(IPAddress localIPAddress, int listeningPort)
        {
            this.Address = localIPAddress;
            this.Port = listeningPort;
            this.Encoding = Encoding.UTF8;

            clientList = new List<ClientHandler>();
            serverSock = new Socket(localIPAddress.AddressFamily, 
                SocketType.Stream, ProtocolType.Tcp);
            serverSock.Bind(new IPEndPoint(this.Address, this.Port)); //绑定监听的ip和端口
            onlineMsgList = new List<string>();
        }

        #endregion

        public void Start()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                Thread thread = new Thread(Listening);
                thread.Start();
                Logger.info("Server has started..................");
                Logger.info("Listening at "+this.Address.ToString()+":"+this.Port);
                IsRunning = true;
            }
        }
        /// <summary>
        /// 开始进行监听
        /// </summary>
        private void Listening()
        {
            serverSock.Listen(1024);
            while (IsRunning)
            {
                if (clientList.Count >= MAXCONNECTION){//I bet it may never ever happen....
                    //RaiseOtherException(null);
                    Logger.error("Members overload.......");
                }
                else
                {
                    Socket clientSocket = null;
                    try {
                        clientSocket = serverSock.Accept();
                        if (clientSocket != null && clientSocket.Connected) {
                            //获取用户名
                            byte[] buf = new byte[2048];
                            int len = clientSocket.Receive(buf);
                            String[] nameAndImg = Encoding.UTF8.GetString(buf, 0, len).Split('/');
                            String name = nameAndImg[0];
                            int imgFlag = int.Parse(nameAndImg[1]);
                            String individualWords = nameAndImg[2];

                            ClientHandler clientHlr = new ClientHandler(clientSocket,this,logger);
                            clientHlr.Username = name;
                            ClientList.Add(clientHlr);

                            //使用线程池来处理客户端请求
                            ThreadPool.QueueUserWorkItem(new WaitCallback(clientHlr.ReceiveData));
                            //保存客户端信息
                            onlineMsgList.Add(name + "%" + imgFlag + "%" + " has come in the room......." + "/" + individualWords);
                            logger.warn(name+" joined in the group chatting...");

                            //broadcast the message that a new member came in
                            foreach(String omsg in onlineMsgList){
                                String[] parameters = omsg.Split('%');
                                Broadcast(parameters[0], int.Parse(parameters[1]), parameters[2], Message.NEWMEMBER);
                            }
                          }
                    }
                    catch (Exception e) { logger.error(e.ToString().Substring(0,15)+"......."); }
                }
            }

        }
        /// <summary>
        /// 停止服务器
        /// </summary>
        public void Stop()
        {
            if (IsRunning)
            {
                IsRunning = false;
                CloseAll();
                serverSock.Close();
                clientList.Clear();
                Logger.important("Server has stopped!");
            }
        }

        /// <summary>
        /// 向指定客户端发送数据
        /// </summary>
        public bool Send(byte[] data, ClientHandler client) {
            if (client == null || client.ClientSocket == null) {
                return false;
            }
            if (!client.IsConnected) {
                return false;
            }
            //先告诉客户端要发送的消息类型
            client.ClientSocket.Send(PacketHelper.packet(Message.FILE));
            return Send(data, client.ClientSocket);
        }
        public bool Send(byte[] data, Socket client) {
            if (client == null) {
                return false;
            }
            client.Send(data);
            return false;
        }

        /// <summary>
        /// 向指定客户端发送文本消息
        /// </summary>
        public bool Send(String msg, ClientHandler client, String type)
        {
            if (client == null || client.ClientSocket == null) {
                return false;
            }
            if (!client.IsConnected) {
                return false;
            }

            client.ClientSocket.Send(PacketHelper.packet(type));
            return Send(msg, client.ClientSocket);
        }
        public bool Send(String msg, Socket client) {
            if (client == null) {
                return false;
            }
            client.Send(PacketHelper.packet(msg));
            return true;
        }
        public bool Send(String msg, ClientHandler client) {
            if (client == null) {
                return false;
            }
            client.ClientSocket.Send(PacketHelper.packet(msg));
            return true;
        }

        /// <summary>
        /// broadcast the message, only text type....
        /// </summary>
        /// <param name="msg"></param>
        public void Broadcast(String name,int headImg, String msg,String type) {
            foreach (ClientHandler c in clientList) {
                Send(name+"/"+type+"/"+headImg+"/"+msg+"/", c);
            }
        }

        public void setLogger(ServerLogger logger) {
            this.Logger = logger;
        }


        /// <summary>
        /// 关闭一个session
        /// </summary>
        /// <param name="client">客户端会话对象</param>
        public void Close(ClientHandler client)
        {
            Logger.important(client.Username + " has been quit group chatting.");
            if (client != null)
            {
                client.IsConnected = false;
                client.ClientSocket.Close();
                ClientList.Remove(client);
                removeFromOnlineMsgList(client.Username);
                Broadcast(client.Username, 0, "close", Message.QUIT);
            }
        }

        private void removeFromOnlineMsgList(string name) {
            for (int i=0; i<onlineMsgList.Count; i++) {
                string username = onlineMsgList[i].Split('%')[0];
                if (username.Equals(name)) {
                    onlineMsgList.RemoveAt(i);
                    break;
                }
            }

        }
        /// <summary>
        /// 关闭所有的客户端会话,与所有的客户端连接会断开
        /// </summary>
        public void CloseAll()
        {
            foreach (ClientHandler c in ClientList) {
                Close(c);
                if (ClientList.Count <= 0) {
                    break;
                }
            }
        }



        public event EventHandler<SocketEventArgs> ClientConnected;//需要自己定义相应动作
        public event EventHandler<SocketEventArgs> ClientDisconnected;

        private void RaiseClientConnected(ClientHandler handle)
        {
            if (ClientConnected != null)
            {
                ClientConnected(this, new SocketEventArgs(handle));
            }
        }

        private void RaiseClientDisconnected(Socket client)
        {
            if (ClientDisconnected != null)
            {
                ClientDisconnected(this, new SocketEventArgs("连接断开"));
            }
        }
    }
}
