namespace CryptoWinGUI
{
    partial class AffinePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffinePage));
            this.background = new System.Windows.Forms.Panel();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.CLoseButton = new System.Windows.Forms.Button();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.shiftNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaesarDecrypt = new System.Windows.Forms.Button();
            this.CaesarOutput = new System.Windows.Forms.TextBox();
            this.CaesarEncrypt = new System.Windows.Forms.Button();
            this.CaesarInput = new System.Windows.Forms.TextBox();
            this.AffineA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.AffineA);
            this.background.Controls.Add(this.shiftNumber);
            this.background.Controls.Add(this.MenuBar);
            this.background.Controls.Add(this.label4);
            this.background.Controls.Add(this.label2);
            this.background.Controls.Add(this.CaesarInput);
            this.background.Controls.Add(this.label3);
            this.background.Controls.Add(this.CaesarEncrypt);
            this.background.Controls.Add(this.CaesarDecrypt);
            this.background.Controls.Add(this.CaesarOutput);
            this.background.Location = new System.Drawing.Point(-1, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1224, 672);
            this.background.TabIndex = 29;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MenuBar.Controls.Add(this.CLoseButton);
            this.MenuBar.Controls.Add(this.PageNameLabel);
            this.MenuBar.Location = new System.Drawing.Point(-1, -1);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1227, 62);
            this.MenuBar.TabIndex = 28;
            // 
            // CLoseButton
            // 
            this.CLoseButton.FlatAppearance.BorderSize = 0;
            this.CLoseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLoseButton.Image = ((System.Drawing.Image)(resources.GetObject("CLoseButton.Image")));
            this.CLoseButton.Location = new System.Drawing.Point(1167, 3);
            this.CLoseButton.Name = "CLoseButton";
            this.CLoseButton.Size = new System.Drawing.Size(55, 55);
            this.CLoseButton.TabIndex = 3;
            this.CLoseButton.UseVisualStyleBackColor = true;
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.PageNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.PageNameLabel.Location = new System.Drawing.Point(10, 10);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(250, 46);
            this.PageNameLabel.TabIndex = 2;
            this.PageNameLabel.Text = "Affine Cipher";
            // 
            // shiftNumber
            // 
            this.shiftNumber.Location = new System.Drawing.Point(347, 88);
            this.shiftNumber.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.shiftNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftNumber.Name = "shiftNumber";
            this.shiftNumber.Size = new System.Drawing.Size(49, 20);
            this.shiftNumber.TabIndex = 44;
            this.shiftNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(325, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(65, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Output:";
            // 
            // CaesarDecrypt
            // 
            this.CaesarDecrypt.Location = new System.Drawing.Point(255, 298);
            this.CaesarDecrypt.Name = "CaesarDecrypt";
            this.CaesarDecrypt.Size = new System.Drawing.Size(144, 33);
            this.CaesarDecrypt.TabIndex = 40;
            this.CaesarDecrypt.Text = "Decrypt";
            this.CaesarDecrypt.UseVisualStyleBackColor = true;
            // 
            // CaesarOutput
            // 
            this.CaesarOutput.BackColor = System.Drawing.Color.Gray;
            this.CaesarOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaesarOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaesarOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CaesarOutput.Location = new System.Drawing.Point(70, 213);
            this.CaesarOutput.Multiline = true;
            this.CaesarOutput.Name = "CaesarOutput";
            this.CaesarOutput.ReadOnly = true;
            this.CaesarOutput.Size = new System.Drawing.Size(329, 64);
            this.CaesarOutput.TabIndex = 37;
            // 
            // CaesarEncrypt
            // 
            this.CaesarEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.CaesarEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CaesarEncrypt.ForeColor = System.Drawing.Color.Black;
            this.CaesarEncrypt.Location = new System.Drawing.Point(70, 298);
            this.CaesarEncrypt.Name = "CaesarEncrypt";
            this.CaesarEncrypt.Size = new System.Drawing.Size(142, 33);
            this.CaesarEncrypt.TabIndex = 39;
            this.CaesarEncrypt.Text = "Encrypt";
            this.CaesarEncrypt.UseVisualStyleBackColor = false;
            // 
            // CaesarInput
            // 
            this.CaesarInput.BackColor = System.Drawing.Color.Gray;
            this.CaesarInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaesarInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaesarInput.Location = new System.Drawing.Point(70, 116);
            this.CaesarInput.Multiline = true;
            this.CaesarInput.Name = "CaesarInput";
            this.CaesarInput.Size = new System.Drawing.Size(329, 66);
            this.CaesarInput.TabIndex = 38;
            // 
            // AffineA
            // 
            this.AffineA.FormattingEnabled = true;
            this.AffineA.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "15",
            "17",
            "19",
            "21",
            "23",
            "25"});
            this.AffineA.Location = new System.Drawing.Point(255, 90);
            this.AffineA.MaxDropDownItems = 12;
            this.AffineA.Name = "AffineA";
            this.AffineA.Size = new System.Drawing.Size(34, 21);
            this.AffineA.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(230, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "a:";
            // 
            // AffinePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1224, 672);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AffinePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Button CLoseButton;
        private System.Windows.Forms.NumericUpDown shiftNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CaesarInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CaesarEncrypt;
        private System.Windows.Forms.Button CaesarDecrypt;
        private System.Windows.Forms.TextBox CaesarOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AffineA;
    }
}