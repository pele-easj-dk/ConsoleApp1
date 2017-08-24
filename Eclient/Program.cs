using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Eclient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TcpClient socket = new TcpClient("localhost", 7777))
            using (NetworkStream ns = socket.GetStream())
            using (StreamWriter sw = new StreamWriter(ns))
            using (StreamReader sr = new StreamReader(ns))
            {
                String outline = "Peter";
                sw.WriteLine(outline);
                sw.Flush();

                String inline = sr.ReadLine();
                Console.WriteLine(inline);
                Console.ReadLine(); // wait to finish
            }
        }
    }
}
