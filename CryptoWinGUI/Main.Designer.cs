namespace CryptoWinGUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.background = new System.Windows.Forms.Panel();
            this.HomePage = new System.Windows.Forms.Panel();
            this.HomePageLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DevPageHMB = new System.Windows.Forms.Button();
            this.CaesarHMB = new System.Windows.Forms.Button();
            this.AffineHMB = new System.Windows.Forms.Button();
            this.RailFenceHMB = new System.Windows.Forms.Button();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PlayfairHMB = new System.Windows.Forms.Button();
            this.background.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.HomePageLayout.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.background.Controls.Add(this.HomePage);
            this.background.Controls.Add(this.MenuBar);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1260, 672);
            this.background.TabIndex = 28;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.HomePageLayout);
            this.HomePage.Location = new System.Drawing.Point(-1, 60);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(1227, 612);
            this.HomePage.TabIndex = 29;
            // 
            // HomePageLayout
            // 
            this.HomePageLayout.AutoScroll = true;
            this.HomePageLayout.Controls.Add(this.DevPageHMB);
            this.HomePageLayout.Controls.Add(this.CaesarHMB);
            this.HomePageLayout.Controls.Add(this.AffineHMB);
            this.HomePageLayout.Controls.Add(this.RailFenceHMB);
            this.HomePageLayout.Controls.Add(this.PlayfairHMB);
            this.HomePageLayout.Location = new System.Drawing.Point(13, 2);
            this.HomePageLayout.Name = "HomePageLayout";
            this.HomePageLayout.Size = new System.Drawing.Size(1211, 610);
            this.HomePageLayout.TabIndex = 0;
            // 
            // DevPageHMB
            // 
            this.DevPageHMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.DevPageHMB.FlatAppearance.BorderSize = 0;
            this.DevPageHMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevPageHMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.DevPageHMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.DevPageHMB.Location = new System.Drawing.Point(3, 3);
            this.DevPageHMB.Name = "DevPageHMB";
            this.DevPageHMB.Size = new System.Drawing.Size(230, 230);
            this.DevPageHMB.TabIndex = 38;
            this.DevPageHMB.Text = "Dev Page";
            this.DevPageHMB.UseVisualStyleBackColor = false;
            this.DevPageHMB.Click += new System.EventHandler(this.DevPageHMB_Click);
            // 
            // CaesarHMB
            // 
            this.CaesarHMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.CaesarHMB.FlatAppearance.BorderSize = 0;
            this.CaesarHMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaesarHMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.CaesarHMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.CaesarHMB.Location = new System.Drawing.Point(239, 3);
            this.CaesarHMB.Name = "CaesarHMB";
            this.CaesarHMB.Size = new System.Drawing.Size(230, 230);
            this.CaesarHMB.TabIndex = 35;
            this.CaesarHMB.Text = "Caesar Cipher";
            this.CaesarHMB.UseVisualStyleBackColor = false;
            // 
            // AffineHMB
            // 
            this.AffineHMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.AffineHMB.FlatAppearance.BorderSize = 0;
            this.AffineHMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AffineHMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.AffineHMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.AffineHMB.Location = new System.Drawing.Point(475, 3);
            this.AffineHMB.Name = "AffineHMB";
            this.AffineHMB.Size = new System.Drawing.Size(230, 230);
            this.AffineHMB.TabIndex = 36;
            this.AffineHMB.Text = "Affine Cipher";
            this.AffineHMB.UseVisualStyleBackColor = false;
            // 
            // RailFenceHMB
            // 
            this.RailFenceHMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.RailFenceHMB.FlatAppearance.BorderSize = 0;
            this.RailFenceHMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RailFenceHMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.RailFenceHMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.RailFenceHMB.Location = new System.Drawing.Point(711, 3);
            this.RailFenceHMB.Name = "RailFenceHMB";
            this.RailFenceHMB.Size = new System.Drawing.Size(230, 230);
            this.RailFenceHMB.TabIndex = 37;
            this.RailFenceHMB.Text = "Rail-Fence Cipher";
            this.RailFenceHMB.UseVisualStyleBackColor = false;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MenuBar.Controls.Add(this.MinimizeButton);
            this.MenuBar.Controls.Add(this.CloseButton);
            this.MenuBar.Controls.Add(this.PageNameLabel);
            this.MenuBar.Controls.Add(this.SettingsButton);
            this.MenuBar.Controls.Add(this.HomeButton);
            this.MenuBar.Location = new System.Drawing.Point(-1, -1);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1227, 62);
            this.MenuBar.TabIndex = 28;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(1108, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(55, 55);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1169, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(55, 55);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.PageNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.PageNameLabel.Location = new System.Drawing.Point(65, 11);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(127, 46);
            this.PageNameLabel.TabIndex = 2;
            this.PageNameLabel.Text = "Home";
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(1047, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(55, 55);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(4, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(55, 55);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // PlayfairHMB
            // 
            this.PlayfairHMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.PlayfairHMB.FlatAppearance.BorderSize = 0;
            this.PlayfairHMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayfairHMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.PlayfairHMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.PlayfairHMB.Location = new System.Drawing.Point(947, 3);
            this.PlayfairHMB.Name = "PlayfairHMB";
            this.PlayfairHMB.Size = new System.Drawing.Size(230, 230);
            this.PlayfairHMB.TabIndex = 39;
            this.PlayfairHMB.Text = "Playfair Cipher";
            this.PlayfairHMB.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1224, 672);
            this.ControlBox = false;
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.background.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.HomePageLayout.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel HomePage;
        private System.Windows.Forms.FlowLayoutPanel HomePageLayout;
        private System.Windows.Forms.Button CaesarHMB;
        private System.Windows.Forms.Button AffineHMB;
        private System.Windows.Forms.Button RailFenceHMB;
        private System.Windows.Forms.Button DevPageHMB;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button PlayfairHMB;
    }
}