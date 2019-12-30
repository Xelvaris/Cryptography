namespace CryptoWinGUI
{
    partial class DevPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevPage));
            this.background = new System.Windows.Forms.Panel();
            this.CaesarPanel = new System.Windows.Forms.Panel();
            this.contentPages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shiftNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaesarDecrypt = new System.Windows.Forms.Button();
            this.CaesarInput = new System.Windows.Forms.TextBox();
            this.CaesarEncrypt = new System.Windows.Forms.Button();
            this.CaesarOutput = new System.Windows.Forms.TextBox();
            this.AffinePage = new System.Windows.Forms.TabPage();
            this.AffineB = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AffineA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AffineDecrypt = new System.Windows.Forms.Button();
            this.AffineEncrypt = new System.Windows.Forms.Button();
            this.AffineOutput = new System.Windows.Forms.TextBox();
            this.AffineInput = new System.Windows.Forms.TextBox();
            this.RailFencePage = new System.Windows.Forms.TabPage();
            this.Rails = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RailFenceDecrypt = new System.Windows.Forms.Button();
            this.RailFenceEncrypt = new System.Windows.Forms.Button();
            this.RailFenceOutput = new System.Windows.Forms.TextBox();
            this.RailFenceInput = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.background.SuspendLayout();
            this.CaesarPanel.SuspendLayout();
            this.contentPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumber)).BeginInit();
            this.AffinePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AffineB)).BeginInit();
            this.RailFencePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rails)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.background.Controls.Add(this.CaesarPanel);
            this.background.Controls.Add(this.MenuBar);
            this.background.Location = new System.Drawing.Point(-1, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1224, 672);
            this.background.TabIndex = 29;
            // 
            // CaesarPanel
            // 
            this.CaesarPanel.Controls.Add(this.contentPages);
            this.CaesarPanel.Location = new System.Drawing.Point(-1, 60);
            this.CaesarPanel.Name = "CaesarPanel";
            this.CaesarPanel.Size = new System.Drawing.Size(1227, 612);
            this.CaesarPanel.TabIndex = 29;
            // 
            // contentPages
            // 
            this.contentPages.Controls.Add(this.tabPage1);
            this.contentPages.Controls.Add(this.AffinePage);
            this.contentPages.Controls.Add(this.RailFencePage);
            this.contentPages.Controls.Add(this.tabPage3);
            this.contentPages.Location = new System.Drawing.Point(130, 25);
            this.contentPages.Name = "contentPages";
            this.contentPages.SelectedIndex = 0;
            this.contentPages.Size = new System.Drawing.Size(777, 461);
            this.contentPages.TabIndex = 15;
            this.contentPages.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.shiftNumber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CaesarDecrypt);
            this.tabPage1.Controls.Add(this.CaesarInput);
            this.tabPage1.Controls.Add(this.CaesarEncrypt);
            this.tabPage1.Controls.Add(this.CaesarOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 435);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Caesar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shiftNumber
            // 
            this.shiftNumber.Location = new System.Drawing.Point(184, 74);
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
            this.shiftNumber.TabIndex = 7;
            this.shiftNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shift:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output:";
            // 
            // CaesarDecrypt
            // 
            this.CaesarDecrypt.Location = new System.Drawing.Point(150, 132);
            this.CaesarDecrypt.Name = "CaesarDecrypt";
            this.CaesarDecrypt.Size = new System.Drawing.Size(84, 23);
            this.CaesarDecrypt.TabIndex = 3;
            this.CaesarDecrypt.Text = "Decrypt";
            this.CaesarDecrypt.UseVisualStyleBackColor = true;
            this.CaesarDecrypt.Click += new System.EventHandler(this.CaesarDecrypt_Click);
            // 
            // CaesarInput
            // 
            this.CaesarInput.Location = new System.Drawing.Point(41, 50);
            this.CaesarInput.Name = "CaesarInput";
            this.CaesarInput.Size = new System.Drawing.Size(193, 20);
            this.CaesarInput.TabIndex = 0;
            // 
            // CaesarEncrypt
            // 
            this.CaesarEncrypt.Location = new System.Drawing.Point(41, 132);
            this.CaesarEncrypt.Name = "CaesarEncrypt";
            this.CaesarEncrypt.Size = new System.Drawing.Size(84, 23);
            this.CaesarEncrypt.TabIndex = 2;
            this.CaesarEncrypt.Text = "Encrypt";
            this.CaesarEncrypt.UseVisualStyleBackColor = true;
            this.CaesarEncrypt.Click += new System.EventHandler(this.CaesarEncrypt_Click);
            // 
            // CaesarOutput
            // 
            this.CaesarOutput.Location = new System.Drawing.Point(41, 96);
            this.CaesarOutput.Name = "CaesarOutput";
            this.CaesarOutput.ReadOnly = true;
            this.CaesarOutput.Size = new System.Drawing.Size(193, 20);
            this.CaesarOutput.TabIndex = 1;
            // 
            // AffinePage
            // 
            this.AffinePage.Controls.Add(this.AffineB);
            this.AffinePage.Controls.Add(this.label9);
            this.AffinePage.Controls.Add(this.label8);
            this.AffinePage.Controls.Add(this.AffineA);
            this.AffinePage.Controls.Add(this.label6);
            this.AffinePage.Controls.Add(this.label7);
            this.AffinePage.Controls.Add(this.AffineDecrypt);
            this.AffinePage.Controls.Add(this.AffineEncrypt);
            this.AffinePage.Controls.Add(this.AffineOutput);
            this.AffinePage.Controls.Add(this.AffineInput);
            this.AffinePage.Location = new System.Drawing.Point(4, 22);
            this.AffinePage.Name = "AffinePage";
            this.AffinePage.Padding = new System.Windows.Forms.Padding(3);
            this.AffinePage.Size = new System.Drawing.Size(769, 435);
            this.AffinePage.TabIndex = 2;
            this.AffinePage.Text = "Affine";
            this.AffinePage.UseVisualStyleBackColor = true;
            // 
            // AffineB
            // 
            this.AffineB.Location = new System.Drawing.Point(184, 62);
            this.AffineB.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.AffineB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AffineB.Name = "AffineB";
            this.AffineB.Size = new System.Drawing.Size(40, 20);
            this.AffineB.TabIndex = 17;
            this.AffineB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "b:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "a:";
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
            this.AffineA.Location = new System.Drawing.Point(113, 62);
            this.AffineA.MaxDropDownItems = 12;
            this.AffineA.Name = "AffineA";
            this.AffineA.Size = new System.Drawing.Size(37, 21);
            this.AffineA.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Output:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Input:";
            // 
            // AffineDecrypt
            // 
            this.AffineDecrypt.Location = new System.Drawing.Point(140, 122);
            this.AffineDecrypt.Name = "AffineDecrypt";
            this.AffineDecrypt.Size = new System.Drawing.Size(84, 23);
            this.AffineDecrypt.TabIndex = 11;
            this.AffineDecrypt.Text = "Decrypt";
            this.AffineDecrypt.UseVisualStyleBackColor = true;
            this.AffineDecrypt.Click += new System.EventHandler(this.AffineDecrypt_Click);
            // 
            // AffineEncrypt
            // 
            this.AffineEncrypt.Location = new System.Drawing.Point(31, 122);
            this.AffineEncrypt.Name = "AffineEncrypt";
            this.AffineEncrypt.Size = new System.Drawing.Size(84, 23);
            this.AffineEncrypt.TabIndex = 10;
            this.AffineEncrypt.Text = "Encrypt";
            this.AffineEncrypt.UseVisualStyleBackColor = true;
            this.AffineEncrypt.Click += new System.EventHandler(this.AffineEncrypt_Click);
            // 
            // AffineOutput
            // 
            this.AffineOutput.Location = new System.Drawing.Point(31, 86);
            this.AffineOutput.Name = "AffineOutput";
            this.AffineOutput.ReadOnly = true;
            this.AffineOutput.Size = new System.Drawing.Size(193, 20);
            this.AffineOutput.TabIndex = 9;
            // 
            // AffineInput
            // 
            this.AffineInput.Location = new System.Drawing.Point(31, 40);
            this.AffineInput.Name = "AffineInput";
            this.AffineInput.Size = new System.Drawing.Size(193, 20);
            this.AffineInput.TabIndex = 8;
            // 
            // RailFencePage
            // 
            this.RailFencePage.Controls.Add(this.Rails);
            this.RailFencePage.Controls.Add(this.label5);
            this.RailFencePage.Controls.Add(this.label10);
            this.RailFencePage.Controls.Add(this.label11);
            this.RailFencePage.Controls.Add(this.RailFenceDecrypt);
            this.RailFencePage.Controls.Add(this.RailFenceEncrypt);
            this.RailFencePage.Controls.Add(this.RailFenceOutput);
            this.RailFencePage.Controls.Add(this.RailFenceInput);
            this.RailFencePage.Location = new System.Drawing.Point(4, 22);
            this.RailFencePage.Name = "RailFencePage";
            this.RailFencePage.Padding = new System.Windows.Forms.Padding(3);
            this.RailFencePage.Size = new System.Drawing.Size(769, 435);
            this.RailFencePage.TabIndex = 3;
            this.RailFencePage.Text = "Rail-Fence";
            this.RailFencePage.UseVisualStyleBackColor = true;
            // 
            // Rails
            // 
            this.Rails.Location = new System.Drawing.Point(172, 64);
            this.Rails.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Rails.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Rails.Name = "Rails";
            this.Rails.Size = new System.Drawing.Size(49, 20);
            this.Rails.TabIndex = 15;
            this.Rails.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rails:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Output:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Input:";
            // 
            // RailFenceDecrypt
            // 
            this.RailFenceDecrypt.Location = new System.Drawing.Point(138, 122);
            this.RailFenceDecrypt.Name = "RailFenceDecrypt";
            this.RailFenceDecrypt.Size = new System.Drawing.Size(84, 23);
            this.RailFenceDecrypt.TabIndex = 11;
            this.RailFenceDecrypt.Text = "Decrypt";
            this.RailFenceDecrypt.UseVisualStyleBackColor = true;
            this.RailFenceDecrypt.Click += new System.EventHandler(this.RailFenceDecrypt_Click);
            // 
            // RailFenceEncrypt
            // 
            this.RailFenceEncrypt.Location = new System.Drawing.Point(29, 122);
            this.RailFenceEncrypt.Name = "RailFenceEncrypt";
            this.RailFenceEncrypt.Size = new System.Drawing.Size(84, 23);
            this.RailFenceEncrypt.TabIndex = 10;
            this.RailFenceEncrypt.Text = "Encrypt";
            this.RailFenceEncrypt.UseVisualStyleBackColor = true;
            this.RailFenceEncrypt.Click += new System.EventHandler(this.RailFenceEncrypt_Click);
            // 
            // RailFenceOutput
            // 
            this.RailFenceOutput.Location = new System.Drawing.Point(29, 86);
            this.RailFenceOutput.Name = "RailFenceOutput";
            this.RailFenceOutput.ReadOnly = true;
            this.RailFenceOutput.Size = new System.Drawing.Size(193, 20);
            this.RailFenceOutput.TabIndex = 9;
            // 
            // RailFenceInput
            // 
            this.RailFenceInput.Location = new System.Drawing.Point(29, 40);
            this.RailFenceInput.Name = "RailFenceInput";
            this.RailFenceInput.Size = new System.Drawing.Size(193, 20);
            this.RailFenceInput.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(769, 435);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MenuBar.Controls.Add(this.PageNameLabel);
            this.MenuBar.Controls.Add(this.SettingsButton);
            this.MenuBar.Controls.Add(this.CloseButton);
            this.MenuBar.Location = new System.Drawing.Point(-1, -1);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1227, 62);
            this.MenuBar.TabIndex = 28;
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.PageNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.PageNameLabel.Location = new System.Drawing.Point(65, 11);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(194, 46);
            this.PageNameLabel.TabIndex = 2;
            this.PageNameLabel.Text = "Dev Page";
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(1166, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(55, 55);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(4, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(55, 55);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // DevPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1224, 672);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DevPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher";
            this.background.ResumeLayout(false);
            this.CaesarPanel.ResumeLayout(false);
            this.contentPages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumber)).EndInit();
            this.AffinePage.ResumeLayout(false);
            this.AffinePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AffineB)).EndInit();
            this.RailFencePage.ResumeLayout(false);
            this.RailFencePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rails)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel CaesarPanel;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.TabControl contentPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown shiftNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CaesarDecrypt;
        private System.Windows.Forms.Button CaesarEncrypt;
        private System.Windows.Forms.TextBox CaesarOutput;
        private System.Windows.Forms.TextBox CaesarInput;
        private System.Windows.Forms.TabPage AffinePage;
        private System.Windows.Forms.NumericUpDown AffineB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AffineA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AffineDecrypt;
        private System.Windows.Forms.Button AffineEncrypt;
        private System.Windows.Forms.TextBox AffineOutput;
        private System.Windows.Forms.TextBox AffineInput;
        private System.Windows.Forms.TabPage RailFencePage;
        private System.Windows.Forms.NumericUpDown Rails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button RailFenceDecrypt;
        private System.Windows.Forms.Button RailFenceEncrypt;
        private System.Windows.Forms.TextBox RailFenceOutput;
        private System.Windows.Forms.TextBox RailFenceInput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button CloseButton;
    }
}