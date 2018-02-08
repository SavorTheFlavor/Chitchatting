using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyServer {
    class BootStrap {
        //根据配置文件里的信息设置ip和端口，出错则按默认的
        internal static MyTCPServer loadServer(string config) {
            String curDir = Directory.GetCurrentDirectory();
            StreamReader sr = new StreamReader(curDir + "/" + config , System.Text.Encoding.UTF8);

            MyTCPServer server = null;
            IPAddress ipaddr = null;
            int port = 12345;
            String line;
            try {
                while ((line = sr.ReadLine()) != null) {
                    String[] attrAndVal = line.Split('=');
                    if (attrAndVal[0].Equals("server.ip")) {
                        ipaddr = IPAddress.Parse(attrAndVal[1]);
                    }
                    if (attrAndVal[0].Equals("server.port")) {
                        port = int.Parse(attrAndVal[1]);
                    }
                }
                server = new MyTCPServer(ipaddr, port);
            }
            catch (Exception e) {
                server = new MyTCPServer(12345);
                //System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally {
                sr.Close();
            }

            return server;
        }
    }
}
