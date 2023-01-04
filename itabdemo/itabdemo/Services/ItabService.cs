using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace itabdemo.Services
{

    public class ItabService : IService
    {
        // Set correct ip address to the Itab lan server
        const string sesamIpAddress = "127.0.0.1";

        // default port for the Itab sesam service
        const int port = 25803;

        public async Task<string> notify()
        {
            Console.WriteLine("Notify");
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(sesamIpAddress), port);
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine(ipEndPoint.Serialize());

            // We use socket to connect to Itab. The ip adress is
            // oobtained once the itab system is set up on the environemmt
            await socket.ConnectAsync(ipEndPoint);
            Console.WriteLine("connected");

            // A random message identifying the transaction, Itab don't care
            // what the message is as long as it starts with ACC and is unique
            var message = $"ACC {DateTime.Now.Millisecond}{"1234"}\r";
            byte[] data = Encoding.UTF8.GetBytes(message);
            _ = await socket.SendAsync(data, SocketFlags.None);

            // Itab will echo back the message to verify that the message
            // has been recived and processed
            var buffer = new byte[1024];
            int received = await socket.ReceiveAsync(buffer, SocketFlags.None);
            var result = Encoding.UTF8.GetString(buffer, 0, received);
            Console.WriteLine(result);

            socket.Close();

            return result;
        }
    }
}