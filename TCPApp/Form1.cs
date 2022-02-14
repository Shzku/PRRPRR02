using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        private const int portNum = 4200;
        public Form1()
        {
            InitializeComponent();

            bool done = false;

            var listener = new TcpListener(IPAddress.Any, portNum);

            listener.Start();

            while (!done)
            {
                Console.Write("Waiting for connection...");
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Connection accepted.");
                NetworkStream ns = client.GetStream();

                try
                {
                    //ns.Write();
                    ns.Close();
                    client.Close();
                } catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            listener.Stop();
        }
    }
}