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

        private bool topLocked = false;
        private bool bottomLocked = false;
        private bool leftLocked = false;
        private bool rightLocked = false;

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
                    int n;
                    n = await ns.ReadAsync(buffer, 0, buffer.Length);

                    string cmd = Encoding.UTF8.GetString(buffer, 0, n);

                    

                    switch(cmd)
                    {
                        case "UP!":
                            Debug.WriteLine("up command received");
                            pbxSprite.Top -= 20;
                            if (pbxSprite.Top <= 0)
                            {
                                pbxSprite.Top = 0;
                                buffer = Encoding.UTF8.GetBytes("UPLOCKED");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                topLocked = true;
                            }
                            if(bottomLocked)
                            {
                                buffer = Encoding.UTF8.GetBytes("UNLOCKDOWN");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                bottomLocked = false;
                            }
                            break;
                        case "DOWN!":
                            Debug.WriteLine("down command received");
                            pbxSprite.Top += 20;
                            if (pbxSprite.Bottom >= ClientRectangle.Height)
                            {
                                pbxSprite.Top = ClientRectangle.Height - pbxSprite.Height;
                                buffer = Encoding.UTF8.GetBytes("DOWNLOCKED");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                bottomLocked = true;
                            }
                            if (topLocked)
                            {
                                buffer = Encoding.UTF8.GetBytes("UNLOCKUP");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                topLocked = false;
                            }
                            break;
                        case "LEFT!":
                            Debug.WriteLine("left command received");
                            pbxSprite.Left -= 20;
                            if (pbxSprite.Left <= 0)
                            {
                                pbxSprite.Left = 0;
                                buffer = Encoding.UTF8.GetBytes("LEFTLOCKED");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                leftLocked = true;
                            }
                            if(rightLocked)
                            {
                                buffer = Encoding.UTF8.GetBytes("UNLOCKRIGHT");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                rightLocked = false;
                            }
                            break;
                        case "RIGHT!":
                            Debug.WriteLine("right command received");
                            pbxSprite.Left += 20;
                            if (pbxSprite.Right >= ClientRectangle.Width)
                            {
                                pbxSprite.Left = ClientRectangle.Width - pbxSprite.Width;
                                buffer = Encoding.UTF8.GetBytes("RIGHTLOCKED");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                rightLocked = true;
                            }
                            if (leftLocked)
                            {
                                buffer = Encoding.UTF8.GetBytes("UNLOCKLEFT");
                                await ns.WriteAsync(buffer, 0, buffer.Length);
                                leftLocked = false;
                            }
                            break;
                        default:
                            Debug.WriteLine(cmd);
                            Debug.WriteLine("error");
                            break;
                    }
                }
            }

            Debug.WriteLine("listener quit");
            listener.Stop();
        }
    }
}