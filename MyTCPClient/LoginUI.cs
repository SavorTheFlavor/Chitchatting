using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTCPClient {
    public partial class LoginUI : CCWin.Skin_Mac {

        private MyClient client;
        private ClientUI clientUI;
        //splash loading..............
        public LoginUI() {
            this.client = new MyClient();
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;
            usernameTxtBox.Text = ClientUtil.getRandomName();
            client.ImgFlag = ClientUtil.getRandomImgFlag();
            profileImg.Image = ClientUtil.getImg(client.ImgFlag);
            client.ProfileImg = profileImg.Image;
            client.LoginUI = this;

        }

        private void connectBtn_Click(object sender, EventArgs e) {
            //set paramerters
            String ipaddrstr = serverIpTxtBox.Text;
            if (!ipaddrstr.Trim().Equals("localhost")) {
                try {
                    client.Ip = IPAddress.Parse(ipaddrstr);
                }
                catch (Exception e3) {
                    MessageBox.Show("server ip address isn't legal...");
                    return;
                }
            }
            try {
                client.Port = Int32.Parse(portTextBox.Text);
            }
            catch (Exception e22) {
                MessageBox.Show("the port is illegal...");
                return;
            }
            client.Username = usernameTxtBox.Text;
            client.IndividualWords = individualWords.Text;
           
            bool isConnected = client.Connect();
            if (isConnected) {
                this.Hide();//因为是主线程，直接close掉的话其他的窗体也会跟着挂了
                clientUI = new ClientUI(client);
                client.ClientUI = clientUI;
                clientUI.Show();
            }
        }

        private void changeProfile_Click(object sender, EventArgs e) {
            client.ImgFlag = ClientUtil.getRandomImgFlag();
            profileImg.Image = ClientUtil.getImg(client.ImgFlag);
            client.ProfileImg = profileImg.Image;
        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e) {

        }

        private void LoginUI_Click(object sender, EventArgs e) {
            serverIpTxtBox.Enabled = false;
            portTextBox.Enabled = false;
        }

        private void serverIptxbPanel_MouseHover(object sender, EventArgs e) {
            serverIpTxtBox.Enabled = true;
        }

        private void porttxbPanel_MouseHover(object sender, EventArgs e) {
            portTextBox.Enabled = true;
        }

    }
}
