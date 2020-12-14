using System.Net;
using System.Net.Sockets;

namespace CSharpClient
{
    public class Initialization
    {
        private readonly string _ipAddress = "10.10.14.53";
        private readonly int _portNum = 7776;
        public Socket MySocket { get; set; }

        public void Initialize()
        {
            SocketSetup();
            //CheckInitialStatus();
        }

        public void SocketSetup()
        {
            MySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(_ipAddress), _portNum);

            MySocket.Connect(endPoint);
        }

        public void CheckInitialStatus()
        {
            var fileManager = new FileManager();

            //Check all instrument
            var initialStatus = new LedStatusScript(MySocket);
            var resp = initialStatus.Send("ready"); // this will be actual GBG instrument variable

            fileManager.SaveFile(resp);
        }
    }
}