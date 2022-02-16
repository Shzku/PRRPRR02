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

            try
            {
                //var client = new TcpClient(hostName, portNum);

                //NetworkStream ns = client.GetStream();

                //int bytesRead = ns.Read(bytes, 0, bytes.Length);

                //Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));

                //client.Close();
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes("ALO?");
                client = new TcpClient(tbxIPInput.Text, portNum);
                stream = client.GetStream();
                stream.Write(bytes, 0, bytes.Length);
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
    }
}