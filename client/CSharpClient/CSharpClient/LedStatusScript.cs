using System;
using System.Net.Sockets;
using System.Text;

namespace CSharpClient
{

    public class LedStatusScript
    {
        private readonly Socket _mySocket;

        public LedStatusScript(Socket socket)
        {
            _mySocket = socket;
        }


        public void Run()
        {
            try
            {
                var fileManager = new FileManager();

                /*The two lines below are mimicking what GBG will output*/
                Console.Write("Enter message : ");
                string msg = Console.ReadLine();

                //if (msg != fileManager.ReadFile()) // check if the GBG status msg is the same as the one written on the file
                //{
                //    fileManager.SaveFile(msg); // save the new GBG status msg to the file

                //    var resp = Send(msg);
                //    Console.WriteLine("Received message : {0}", resp);

                //    if (resp == "exit")
                //        Program.exit = true;
                //}
                var resp = Send(msg);
                Console.WriteLine("Received message : {0}", resp);

                if (resp == "exit")
                    Program.exit = true;

                /*No need to send commands to the RPi when the state is the same*/
                //else
                //{
                //    Console.WriteLine("Not sending anything");
                //}
            }
            catch (SocketException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string Send(string msg)
        {
            byte[] msgBuffer = Encoding.Default.GetBytes(msg);
            _mySocket.Send(msgBuffer, 0, msgBuffer.Length, 0);

            var msgResponse = ReadResponse();
            return msgResponse;
        }

        public string ReadResponse()
        {
            byte[] buffer = new byte[255];
            int rec = _mySocket.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            return Encoding.Default.GetString(buffer);
        }
    }
}