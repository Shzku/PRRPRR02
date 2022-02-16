using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        private const int portNum = 4200;
        public Form1()
        {
            InitializeComponent();
            listenServer();
        }

        public async void listenServer()
        {
            bool done = false;

            var listener = new TcpListener(IPAddress.Any, portNum);

            listener.Start();

            while (!done)
            {
                Debug.Write("Waiting for connection...");
                TcpClient client = await listener.AcceptTcpClientAsync();

                Debug.WriteLine("Connection accepted.");
                NetworkStream ns = client.GetStream();

                
                while (!done)
                {
                    byte[] buffer = new byte[1024];
                    await ns.ReadAsync(buffer, 0, buffer.Length);

                    Debug.WriteLine(Encoding.UTF8.GetString(buffer, 0, buffer.Length));
                    MessageBox.Show(Encoding.UTF8.GetString(buffer, 0, buffer.Length));
                }
                /*byte[] byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString());

                try
                {
                    ns.Write(byteTime, 0, byteTime.Length);
                    ns.Close();
                    client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }*/
            }

            Debug.WriteLine("listener quit");
            listener.Stop();
        }
    }
}