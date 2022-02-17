using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    public partial class Klient : Form
    {
        private const int portNum = 4200;
        private const string hostName = "127.0.0.1";

        TcpClient client;
        NetworkStream stream;

        public Klient()
        {
            InitializeComponent();
            client = new TcpClient();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //client = new TcpClient(tbxIPInput.Text, portNum);
                client.Connect(tbxIPInput.Text, portNum);
                btnConnect.Enabled = false;
                stream = client.GetStream();
                streamRead();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("UP!");
            stream.Write(bytes, 0, bytes.Length);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("DOWN!");
            stream.Write(bytes, 0, bytes.Length);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("LEFT!");
            stream.Write(bytes, 0, bytes.Length);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("RIGHT!");
            stream.Write(bytes, 0, bytes.Length);
        }
        
        private async void streamRead()
        {
            while (true)
            {
                int n;
                string cmd;
                byte[] bytes = new byte[1024];
                n = await stream.ReadAsync(bytes, 0, bytes.Length);
                cmd = Encoding.UTF8.GetString(bytes, 0, n);
                Debug.WriteLine(Encoding.UTF8.GetString(bytes, 0, n));

                switch (cmd)
                {
                    case "UPLOCKED":
                        btnUp.Enabled = false;
                        break;
                    case "UNLOCKUP":
                        btnUp.Enabled = true;
                        break;
                    case "DOWNLOCKED":
                        btnDown.Enabled = false;
                        break;
                    case "UNLOCKDOWN":
                        btnDown.Enabled = true;
                        break;
                    case "LEFTLOCKED":
                        btnLeft.Enabled = false;
                        break;
                    case "UNLOCKLEFT":
                        btnLeft.Enabled = true;
                        break;
                    case "RIGHTLOCKED":
                        btnRight.Enabled = false;
                        break;
                    case "UNLOCKRIGHT":
                        btnRight.Enabled = true;
                        break;
                    default:
                        MessageBox.Show("Unknown message from server: " + cmd);
                        break;
                }
            }
        }
    }
}