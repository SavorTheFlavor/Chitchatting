using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTCPClient {
    /// <summary>
    /// for message transmission (transfer to json before sending...
    /// It's not a good idea.........
    /// </summary>
    public class Message {

        public const String TEXT = "text";
        public const String NEWMEMBER = "newMember";
        public const String FILE = "file";
        public const String PICTURE = "pic";
        public const String QUIT = "quit";


        private String type;
        public String Type {
            get { return type; }
            set { type = value; }
        }
        private String sender;

        public String Sender {
            get { return sender; }
            set { sender = value; }
        }
        private String content;

        public String Content {
            get { return content; }
            set { content = value; }
        }
        private String time;

        public String Time {
            get { return time; }
            set { time = value; }
        }

        private byte[] data;//file transmission....

        public byte[] Data {
            get { return data; }
            set { data = value; }
        }

    }
}
