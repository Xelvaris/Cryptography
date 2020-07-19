using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWinGUI.Pages
{
    public partial class CWServer : Form
    {
        public CWServer()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void CWServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            ChatOutput.Invoke((MethodInvoker)delegate ()
            {
                ChatOutput.Text += e.MessageString;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            });
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ChatOutput.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(ipTB.Text);
            try
            {
                server.Start(ip, Convert.ToInt32(PortTB.Text));
            }
            catch (Exception ex)
            {
                ChatOutput.Text = Convert.ToString(ex);
            }
            
            Start.Enabled = false;
            Stop.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                Start.Enabled = true;
                Stop.Enabled = false;
            }
        }
    }
}
