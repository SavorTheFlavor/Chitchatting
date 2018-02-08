using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer {
    public class ServerLogger {

        private MyTCPServerUI serverUI;

        public ServerLogger(MyTCPServerUI serverUI) {
            this.serverUI = serverUI;
        }

        public const string INFO = "info";
        public const string WARN = "warn";
        public const string ERROR = "error";
        public const string IMPORTANT = "important";

        public void info(string msg) {
            ServerLogPanel lp = new ServerLogPanel(getNowTimeString() + msg, INFO);
            serverUI.Log(lp);
        }

        public void warn(string msg) {
            ServerLogPanel lp = new ServerLogPanel(getNowTimeString() + msg, WARN);
            serverUI.Log(lp);
        }

        public void error(string msg) {
            ServerLogPanel lp = new ServerLogPanel(getNowTimeString()+msg, ERROR);
            serverUI.Log(lp);
        }

        public void important(string msg) {
            ServerLogPanel lp = new ServerLogPanel(getNowTimeString() + msg, IMPORTANT);
            serverUI.Log(lp);
        }

        public String getNowTimeString() {
            return DateTime.Now.ToLocalTime().ToString()+"  ";
        }


    }
}
