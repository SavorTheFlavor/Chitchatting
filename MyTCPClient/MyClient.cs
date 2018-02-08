using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyTCPClient {
    public class MyClient {
        private String username;
        public String Username {
            get { return username; }
            set { username = value; }
        }
        private bool isConnected;
        private Socket socket;

        private IPAddress ip;
        public IPAddress Ip {
            get { return ip; }
            set { ip = value; }
        }

        private int port;
        public int Port {
            get { return port; }
            set { port = value; }
        }

        private Image profileImg;

        public Image ProfileImg {
            get { return profileImg; }
            set { profileImg = value; }
        }

        private int imgFlag;

        public int ImgFlag {
            get { return imgFlag; }
            set { imgFlag = value; }
        }

        private String individualWords;

        public String IndividualWords {
            get { return individualWords; }
            set { individualWords = value; }
        }

        private ClientUI clientUI;

        public ClientUI ClientUI {
            get { return clientUI; }
            set { clientUI = value; }
        }

        private LoginUI loginUI;

        public LoginUI LoginUI {
            get { return loginUI; }
            set { loginUI = value; }
        }


        public MyClient()
            : this("user" + DateTime.Now.Minute + DateTime.Now.Second, IPAddress.Loopback, 12345) {
        }

        public MyClient(String name) : this(name, IPAddress.Loopback, 12345){
        }

        public MyClient(String name, IPAddress ip, int port) {
            this.username = name;
            this.ip = ip;
            this.port = port;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Connect() {
            try {
                this.socket.Connect(Ip, Port);
                isConnected = socket.Connected;
            }
            catch (Exception e) {
                System.Windows.Forms.MessageBox.Show("与服务器连接失败！");
                return false;
            }
            if (socket.Connected) {
                //发送用户名和头像给服务器
                socket.Send(PacketHelper.packet((String)Username + "/" + imgFlag+"/"+individualWords+"/"));
            }
            else {
                System.Windows.Forms.MessageBox.Show("连接出错！");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 向服务器发送文本消息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool SendMsg(String msg) {
            //all in one package!!!!!!!
            if (!socket.Connected) {
                System.Windows.Forms.MessageBox.Show("无法连接到服务器！","ERROR");
                return false;
            }
            //与服务器约定以name/type/img/content/的方式发送消息头
            socket.Send(PacketHelper.packet(username + "/" + Message.TEXT + "/" + imgFlag + "/" + msg+"/"));
            //......
            return true;
        }

        public bool SendPic(String msg) {
            return false;
        }

        public bool uploadFile() {
            return false;
        }

        public void ReceiveData() {
            while (socket.Connected) {
                byte[] buf = new byte[2048];
                int len = -1;
                try {
                    len = socket.Receive(buf);
                }
                catch (Exception e) {

                }
                if (len < 1) {
                    continue;
                }

                String[] userNameAndMsgType = Encoding.UTF8.GetString(buf, 0, len).Split('/');
                String name = userNameAndMsgType[0];
                String msgType = userNameAndMsgType[1];
                int imgFlag = int.Parse(userNameAndMsgType[2]);
                String content = userNameAndMsgType[3];
                String idvlWords = "";//if new member....
                if (userNameAndMsgType.Length >= 6) {
                    idvlWords = userNameAndMsgType[4];
                }
                switch (msgType) {
                    case Message.TEXT:
                        clientUI.Render(name,imgFlag,content, Message.TEXT);
                        break;
                    case "file":
                        //TODO
                        break;
                    case "pic":
                        //TODO
                        break;
                    case Message.NEWMEMBER:
                        if (name.Equals(this.Username)) {
                            break;
                        }
                        clientUI.addOnlineGuy(imgFlag, name, idvlWords);
                        break;
                    case Message.QUIT:
                        clientUI.removeFromOnlineList(name);
                        break;
                    default:
                        break;
                }
            }
        }


        internal void Close() {
            if (!socket.Connected) {//如果已经与服务器断开了连接
                loginUI.Close();
                return;
            }
            socket.Send(PacketHelper.packet(username + "/" + Message.QUIT + "/" + imgFlag + "/" + "bye" + "/"));
            isConnected = false;
            loginUI.Close();//不然线程仍然会继续运行....
        }
    }
}
