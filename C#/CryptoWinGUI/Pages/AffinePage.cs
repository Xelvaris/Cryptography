using System;
using System.Windows.Forms;
using CryptoLib;

namespace CryptoWinGUI
{
    public partial class AffinePage : Form
    {
        public AffinePage()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Affine.Encrypt(Input.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
            }
            catch
            {
                Output.Text = "Error: You must select a value for 'a'";
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Affine.Decrypt(Input.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
            }
            catch
            {
                Output.Text = "Error: You must select a value for 'a'";
            }
        }

        private void CLoseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}