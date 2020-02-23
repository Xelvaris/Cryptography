using System;
using System.Windows.Forms;
using CryptoLib;

namespace CryptoWinGUI
{
    public partial class Main : Form
    {
        public Main()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void DevPageHMB_Click(object sender, EventArgs e)
        {
            DevPage DP = new DevPage();
            DP.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CaesarHMB_Click(object sender, EventArgs e)
        {
            CaesarPage CP = new CaesarPage();
            CP.Show();
        }
    }
}