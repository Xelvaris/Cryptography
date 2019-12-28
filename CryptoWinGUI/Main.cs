using System;
using System.Windows.Forms;
using CryptoLib;

namespace CryptoWinGUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void CeasarButton_Click(object sender, EventArgs e)
        {
            CaesarOutput.Text = "";
            CaesarInput.Text = "";
            shiftNumber.Value = 1;
            contentPages.SelectTab(0);
        }

        private void CaesarEncrypt_Click(object sender, EventArgs e)
        {
            CaesarOutput.Text = Caesar.Encrypt(CaesarInput.Text, Convert.ToInt32(shiftNumber.Value));
        }

        private void CaesarDecrypt_Click(object sender, EventArgs e)
        {
            CaesarOutput.Text = Caesar.Decrypt(CaesarInput.Text, Convert.ToInt32(shiftNumber.Value));
        }

        private void AffineButton_Click(object sender, EventArgs e)
        {
            AffineInput.Text = "";
            AffineOutput.Text = "";
            contentPages.SelectTab(1);
        }

        private void AffineEncrypt_Click(object sender, EventArgs e)
        {
            try {
                AffineOutput.Text = Affine.Encrypt(AffineInput.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a value for 'a'.", "Peramiter Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AffineDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                AffineOutput.Text = Affine.Decrypt(AffineInput.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a value for 'a'.", "Peramiter Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RailFenceButton_Click(object sender, EventArgs e)
        {
            RailFenceInput.Text = "";
            RailFenceOutput.Text = "";
            Rails.Value = 1;
            contentPages.SelectTab(2);
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