using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace MyServer
{
    /// <summary>
    /// Socket 服务器用于处理客户端连接封装的客户端处理类
    /// </summary>
    public class ClientHandler
    {
        /// <summary>
        /// 与客户端相关联的socket
        /// </summary>
        private Socket clientSocket;
        private ServerLogger logger;

        public Socket ClientSocket {
            get { return clientSocket; }
            set { clientSocket = value; }
        }

        private String username;

        public String Username {
            get { return username; }
            set { username = value; }
        }

        private bool isConnected;

        public bool IsConnected {
            get { return clientSocket.Connected; }
            set { isConnected = value; }
        }

        private MyTCPServer server;


        public ClientHandler(Socket clientSocket, MyTCPServer myTCPServer, ServerLogger logger) {
            this.clientSocket = clientSocket;
            this.server = myTCPServer;
            this.logger = logger;
            isConnected = true;
        }

        public void ReceiveData(Object state)
        {
            int len = -1;
            while (IsConnected)
            {
                try
                {
                    byte[] buf = new byte[2048];
                    len = ClientSocket.Receive(buf);
                    if (len < 1) {
                        continue;
                    }
                    //客户端每次约定以这样的格式发送消息: name/type/img/content/
                    String[] userNameAndMsgType = Encoding.UTF8.GetString(buf,0,len).Split('/');
                    String name = userNameAndMsgType[0];
                    String msgType = userNameAndMsgType[1];
                    int imgFlag = int.Parse(userNameAndMsgType[2]);
                    String content = userNameAndMsgType[3];
                    String individualWords = "";//if new member....
                    if (userNameAndMsgType.Length >= 6) {
                        individualWords = userNameAndMsgType[4];
                    }

                    switch (msgType) {
                        case Message.TEXT:
                            server.Broadcast(name,imgFlag, content, Message.TEXT);
                            logger.info("Receive message from "+name+": \""+content+"\"");
                            break;
                        case Message.NEWMEMBER:
                            server.Broadcast(name, imgFlag, content+"/"+individualWords, Message.TEXT);
                            break;
                        case Message.QUIT:
                            server.Broadcast(name, imgFlag, content, Message.QUIT);
                            server.Close(this);
                            break;
                        case "pic":
                            //TODO
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e) {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    break;
                }
            }
        }

        /// <summary>
        /// 向客户端发送数据
        /// </summary>
        public void SendData(string msg)
        {
            byte[] data = Encoding.Default.GetBytes(msg);
            try
            {
                ClientSocket.Send(data);
            }
            catch (Exception)
            {
                //TODO 处理异常
            }
        }

    }
}
