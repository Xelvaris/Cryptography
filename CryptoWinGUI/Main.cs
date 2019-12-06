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
            CaesarCiphertext.Text = "";
            CaesarPlaintext.Text = "";
            shiftNumber.Value = 1;
            contentPages.SelectTab(0);
        }

        private void CaesarEncrypt_Click(object sender, EventArgs e)
        {
            string ptext = CaesarPlaintext.Text;
            int shift = Convert.ToInt32(shiftNumber.Value);
            CaesarCiphertext.Text = Caesar.Encrypt(ptext, shift);
        }

        private void CaesarDecrypt_Click(object sender, EventArgs e)
        {
            string ctext = CaesarCiphertext.Text;
            int shift = Convert.ToInt32(shiftNumber.Value);
            CaesarPlaintext.Text = Caesar.Decrypt(ctext, shift);
        }

        private void AffineButton_Click(object sender, EventArgs e)
        {
            AffinePlaintext.Text = "";
            AffineCiphertext.Text = "";
            contentPages.SelectTab(1);
        }

        private void AffineEncrypt_Click(object sender, EventArgs e)
        {
            string ptext = AffinePlaintext.Text;
        }

        private void AffineDecrypt_Click(object sender, EventArgs e)
        {
            string ctext = AffineCiphertext.Text;
        }
    }
}