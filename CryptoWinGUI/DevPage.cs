using System;
using System.Windows.Forms;
using CryptoLib;

namespace CryptoWinGUI
{
    public partial class DevPage : Form
    {
        public DevPage()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaesarEncrypt_Click(object sender, EventArgs e)
        {
            CaesarOutput.Text = Caesar.Encrypt(CaesarInput.Text, Convert.ToInt32(shiftNumber.Value));
        }

        private void CaesarDecrypt_Click(object sender, EventArgs e)
        {
            CaesarOutput.Text = Caesar.Decrypt(CaesarInput.Text, Convert.ToInt32(shiftNumber.Value));
        }

        private void AffineEncrypt_Click(object sender, EventArgs e)
        {
            AffineOutput.Text = Affine.Encrypt(AffineInput.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
        }

        private void AffineDecrypt_Click(object sender, EventArgs e)
        {
            AffineOutput.Text = Affine.Decrypt(AffineInput.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
        }

        private void RailFenceEncrypt_Click(object sender, EventArgs e)
        {
            RailFenceOutput.Text = RailFence.Encrypt(RailFenceInput.Text, Convert.ToInt32(Rails.Value));
        }

        private void RailFenceDecrypt_Click(object sender, EventArgs e)
        {
            RailFenceOutput.Text = RailFence.Decrypt(RailFenceInput.Text, Convert.ToInt32(Rails.Value));
        }
    }
}
