using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyServer
{
    /// <summary>
    /// 同步Socket TCP服务器事件类
    /// </summary>
    public class SocketEventArgs : EventArgs
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        public string msg;

        /// <summary>
        /// 客户端状态封装类
        /// </summary>
        public ClientHandler handle;

        /// <summary>
        /// 是否已经处理过了
        /// </summary>
        public bool IsHandled { get; set; }

        public SocketEventArgs(string msg)
        {
            this.msg = msg;
            IsHandled = false;
        }
        public SocketEventArgs(ClientHandler handle)
        {
            this.handle = handle;
            IsHandled = false;
        }
        public SocketEventArgs(string msg, ClientHandler handle)
        {
            this.msg = msg;
            this.handle = handle;
            IsHandled = false;
        }
    }
}
