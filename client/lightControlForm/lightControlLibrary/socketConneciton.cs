using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace lightControlLibrary
{
    public class SocketConnection
    {
        private readonly string _ipAddress;
        private readonly int _portNum;

        public Socket MySocket { get; set; }
        public IPEndPoint IpEndPoint { get; set; }
        public bool IsActive { get; set; }

        public SocketConnection(string ipAddress, int portNum)
        {
            _ipAddress = ipAddress;
            _portNum = portNum;
        }

        public void SocketSetup()
        {
            MySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IpEndPoint = new IPEndPoint(IPAddress.Parse(_ipAddress), _portNum);
        }

        public void Connect()
        {
            MySocket.Connect(IpEndPoint);
            IsActive = true;
        }

        public void Disconnect()
        {
            MySocket.Close();
            IsActive = false;
        }
        public string Send(string msg)
        {
            byte[] msgBuffer = Encoding.Default.GetBytes(msg);
            MySocket.Send(msgBuffer, 0, msgBuffer.Length, 0);

            var msgResponse = ReadResponse();
            return msgResponse;
        }

        public string ReadResponse()
        {
            byte[] buffer = new byte[255];
            int rec = MySocket.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            return Encoding.Default.GetString(buffer);
        }

    }
}
