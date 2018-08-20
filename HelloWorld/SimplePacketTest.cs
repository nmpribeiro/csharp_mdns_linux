using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace csharp_pocs
{
    public class SimplePacketTest
    {
        public SimplePacketTest()
        {
			// byte[] bytes = Encoding.ASCII.GetBytes("test");
            // string someString = Encoding.ASCII.GetString(bytes);

            int port = 5354;

            IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            IPEndPoint ip = new IPEndPoint(ipAddress, port);

            IPAddress destinationAddress = Dns.GetHostEntry("localhost").AddressList[0];
            IPEndPoint destinationIp = new IPEndPoint(destinationAddress, port);

            Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Bind(ip);
            _socket.SendTo(Encoding.ASCII.GetBytes("test"), destinationIp);
            Console.WriteLine("Hello World!");
        }
    }
}
