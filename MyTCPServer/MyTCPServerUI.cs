using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyServer {
    public partial class MyTCPServerUI : CCWin.Skin_Mac {
        //Alt + Shift + F10 提示导包
        private MyTCPServer server;

        public MyTCPServerUI(MyTCPServer server) {
            this.server = server;
            server.setLogger(new ServerLogger(this));
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {
            server.Logger.info("Server now is starting..................");
            server.Start();
        }

        internal void Log(ServerLogPanel lp) {
            consolePanel.BeginInvoke(new Action(() => {
                consolePanel.Controls.Add(lp);
            }));
            
        }

        private void consolePanel_ControlAdded(object sender, ControlEventArgs e) {
            ((Panel)sender).VerticalScroll.Value = ((Panel)sender).VerticalScroll.Maximum;
        }

        private void MyTCPServerUI_FormClosing(object sender, FormClosingEventArgs e) {
            server.Logger.important("Server is closing.......");
            server.Stop();
        }
    }
}
