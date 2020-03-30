using System;
using System.Windows.Forms;
using CryptoLib;

namespace CryptoWinGUI
{
    public partial class CW : Form
    {
        public CW()
        {
            InitializeComponent();
        }

        private void CLoseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}