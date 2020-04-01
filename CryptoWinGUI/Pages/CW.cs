using System;
using System.Text;
using System.Windows.Forms;
using CryptoLib;
using CryptoWinGUI.Pages;
using SimpleTCP;

namespace CryptoWinGUI
{
    public partial class CW : Form
    {
        public CW()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void CW_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            ChatOutput.Invoke((MethodInvoker)delegate ()
            {
                ChatOutput.Text += e.MessageString;
            });
        }

        private void CLoseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Connect.Enabled = false;
            try
            {
                client.Connect(ipTB.Text, Convert.ToInt32(PortTB.Text));
            }
            catch (Exception ex)
            {
                ChatOutput.Text = Convert.ToString(ex);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text != null)
            {
                client.WriteLineAndGetReply($"{UsernameTB.Text}: {MessageBox.Text}", TimeSpan.FromSeconds(3));
            }
            else
            {
                client.WriteLineAndGetReply($"Anon: {MessageBox.Text}", TimeSpan.FromSeconds(3));
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            Connect.Enabled = true;
        }

        private void Server_Click(object sender, EventArgs e)
        {
            CWServer CWS = new CWServer();
            CWS.Show();
        }
    }
}