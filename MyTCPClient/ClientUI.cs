using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using System.Threading;

namespace MyTCPClient {
    ///那c#窗体滚动条的问题怎么都弄不好
    public partial class ClientUI : CCWin.Skin_Mac {

        private MyClient client;
        private delegate void received();//接收数据的守护线程
        private int curPX = 0;
        private int curPY = 0;

        public List<String> onlineMsgList;



        public ClientUI(MyClient client) {
            this.client = client;
            onlineMsgList = new List<string>();
            InitializeComponent();
        }

        internal void setup() {
            received rd = new received(receive);
            rd.BeginInvoke(null,null);
        }

        private void ClientUI_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;
            textBox.SendToBack();
            addOnlineGuy(client.ImgFlag, client.Username, client.IndividualWords);
            setup();
        }

        private bool isInOnlineList(String name) {
            foreach (string n in onlineMsgList) {
                if (n.Equals(name))
                    return true;
            }
            return false;
        }

        public void addOnlineGuy(int imgFlag, string username, string individualWords) {
            if (isInOnlineList(username)) {
                return;
            }
            onlineMsgList.Add(username);
            onlineListPanel.BeginInvoke(new Action(() => {
                OnlineGuyPanel ogp = new OnlineGuyPanel();
                ogp.Name = username;//把控件的名字设置为用户名，方便维护（移除
                ((PictureBox)ogp.Controls.Find("headimg", true)[0]).Image = ClientUtil.getImg(imgFlag);
                ((Label)ogp.Controls.Find("username", true)[0]).Text = username;
                ((Label)ogp.Controls.Find("individualWords", true)[0]).Text = individualWords;
                ((Label)ogp.Controls.Find("individualWords", true)[0]).Enabled = false;
                onlineListPanel.Controls.Add(ogp);
            }));
        }

        private void sendBtn_Click(object sender, EventArgs e) {
            MsgPanelSelf mpanel = new MsgPanelSelf();
            renderMsgToPanel(client.Username,0, textBox.Text, "self", new MsgPanelSelf());
            client.SendMsg(textBox.Text);
            textBox.Text = "";
        }

        public void receive() {
            client.ReceiveData();
        }

        internal void Render(string content) {
            
        }

        internal void Render(string content, string type) {
            throw new NotImplementedException();
        }

        internal void Render(string name,int imgFlag, string content, string type) {
            if (type.Equals(Message.TEXT)) {
                if (name.Equals(client.Username)) {
                    return;
                }
               
                 //必须委托给主线程执行!!!!
                   //控件所在的线程！！！！
                contentPanel.BeginInvoke(new Action(() => {
                    renderMsgToPanel(name,imgFlag, content, "others", new MsgPanelOthers());
                }));
            }
        }

        private void renderMsgToPanel(string name,int imgFlag, string content, string msgOwner, UserControl mpanel) {

            if (msgOwner.Equals("others")) {//别人的消息 ....imgFlag...别人的头像...
                curPX = 0;
                ((PictureBox)mpanel.Controls.Find("headimg", true)[0]).Image = ClientUtil.getImg(imgFlag);
            }
            else if (msgOwner.Equals("self")) {//自己发送的消息
                curPX = this.Width - mpanel.Width - 20;
                ((PictureBox)mpanel.Controls.Find("headimg", true)[0]).Image = client.ProfileImg;
            }
            ((Label)mpanel.Controls.Find("nameLabel", true)[0]).Text = name;
            ((Label)mpanel.Controls.Find("nameLabel", true)[0]).Enabled = false;
            Panel cpanel = ((Panel)mpanel.Controls.Find("contentPanel1", true)[0]);
            TextBox contentArea = ((TextBox)mpanel.Controls.Find("content", true)[0]);
            int tWidth = (int)getContentSize(content).Width;
            int tHeight = (int)getContentSize(content).Height;

            if (tWidth > 232) {
                tHeight += tWidth - 232;
                tWidth = 232;
            }
            contentArea.Width = tWidth + 6;
            contentArea.Height = tHeight;
            cpanel.Height = tHeight;
            contentArea.Text = content;
           // mpanel.Location = new Point(curPX, curPY);
            //contentPanel.Controls.Add(mpanel);
            contentPanel.Controls.Add(mpanel);
            curPY += tHeight + 79;

        }

        private SizeF getContentSize(string content) {
            Font f = new Font("微软雅黑", 11.25F);
            Graphics g = this.CreateGraphics();
            SizeF siF = g.MeasureString(content, f);//通过此方法得到字体的像素长度
            return siF;//因为得到的长度是浮点数，所以要进行转换成整形才能使用
        }


        private void contentPanel_ControlAdded_1(object sender, ControlEventArgs e) {
            ((Panel)sender).VerticalScroll.Value = ((Panel)sender).VerticalScroll.Maximum;
        }

        private void textBox_TextChanged(object sender, EventArgs e) {
            if (textBox.Text.Equals("")) {
                sendBtn.Enabled = false;
            }
            else {
                sendBtn.Enabled = true;
            }
        }

        private void onlineListPanel_ControlAdded(object sender, ControlEventArgs e) {
            ((Panel)sender).VerticalScroll.Value = ((Panel)sender).VerticalScroll.Maximum;
        }

        internal void removeFromOnlineList(string name) {
            onlineListPanel.BeginInvoke(new Action(() => {
                Control[] cs = onlineListPanel.Controls.Find(name, true);
                if (cs.Length > 0) {
                    onlineListPanel.Controls.Remove(cs[0]);
                }
            }));
           
        }

        private void ClientUI_FormClosed(object sender, FormClosedEventArgs e) {
            client.Close();
        }
    }
}
