using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyServer {
    public partial class ServerLogPanel : UserControl {

        public ServerLogPanel(string msg, string type) {
            InitializeComponent();
            logLabel.Text = msg;
            switch (type) {
                case "info":
                    break;
                case "warn":
                    logLabel.ForeColor = System.Drawing.Color.Orange;
                    break;
                case "error":
                    logLabel.ForeColor = System.Drawing.Color.Red;
                    break;
                case "important":
                    logLabel.ForeColor = System.Drawing.Color.ForestGreen;
                    break;

            }
        }

        private void ServerLogPanel_Load(object sender, EventArgs e) {

        }

    }
}
