﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTCPClient {
    public class PacketHelper {
        //无奈之举...........
        internal static byte[] packet(string msg) {
            byte[] buf = new byte[2048];
            for (int i = 0; i < 2048; i++) {
                buf[i] = (byte)'$';
            }
            byte[] data = Encoding.UTF8.GetBytes(msg);
            for (int i = 0; i < data.Length; i++) {
                buf[i] = data[i];
            }
            return buf;
        }
    }
}
