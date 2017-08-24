using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Eserver
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpListener server = new TcpListener(IPAddress.Loopback,7777);
            server.Start();

            using (TcpClient socket = server.AcceptTcpClient())
            using (NetworkStream ns = socket.GetStream())
            using (StreamWriter sw = new StreamWriter(ns))
            using (StreamReader sr = new StreamReader(ns))
            {
                String inline = sr.ReadLine();
                String outline = inline.ToUpper().Trim();
                sw.WriteLine(outline);
                sw.Flush();
            }
        }
    }
}
