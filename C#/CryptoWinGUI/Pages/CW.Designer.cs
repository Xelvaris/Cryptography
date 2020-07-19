namespace CryptoWinGUI
{
    partial class CW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CW));
            this.background = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddUser = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.Button();
            this.Sniffer = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ChatOutput = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.CLoseButton = new System.Windows.Forms.Button();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.background.Controls.Add(this.splitContainer1);
            this.background.Controls.Add(this.MenuBar);
            this.background.Location = new System.Drawing.Point(-1, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1224, 672);
            this.background.TabIndex = 29;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddUser);
            this.splitContainer1.Panel1.Controls.Add(this.Server);
            this.splitContainer1.Panel1.Controls.Add(this.Sniffer);
            this.splitContainer1.Panel1.Controls.Add(this.Disconnect);
            this.splitContainer1.Panel1.Controls.Add(this.Connect);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.PortTB);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ipTB);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.UsernameTB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1245, 614);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 29;
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddUser.ForeColor = System.Drawing.Color.Black;
            this.AddUser.Location = new System.Drawing.Point(18, 491);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(179, 33);
            this.AddUser.TabIndex = 43;
            this.AddUser.Text = "AddUser";
            this.AddUser.UseVisualStyleBackColor = false;
            // 
            // Server
            // 
            this.Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Server.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Server.ForeColor = System.Drawing.Color.Black;
            this.Server.Location = new System.Drawing.Point(18, 530);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(179, 33);
            this.Server.TabIndex = 42;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = false;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // Sniffer
            // 
            this.Sniffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Sniffer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sniffer.ForeColor = System.Drawing.Color.Black;
            this.Sniffer.Location = new System.Drawing.Point(18, 569);
            this.Sniffer.Name = "Sniffer";
            this.Sniffer.Size = new System.Drawing.Size(179, 33);
            this.Sniffer.TabIndex = 41;
            this.Sniffer.Text = "Sniffer";
            this.Sniffer.UseVisualStyleBackColor = false;
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Disconnect.ForeColor = System.Drawing.Color.Black;
            this.Disconnect.Location = new System.Drawing.Point(16, 306);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(179, 33);
            this.Disconnect.TabIndex = 40;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Connect.ForeColor = System.Drawing.Color.Black;
            this.Connect.Location = new System.Drawing.Point(16, 267);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(179, 33);
            this.Connect.TabIndex = 39;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(11, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Port:";
            // 
            // PortTB
            // 
            this.PortTB.BackColor = System.Drawing.Color.Gray;
            this.PortTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortTB.Location = new System.Drawing.Point(14, 220);
            this.PortTB.MaxLength = 5;
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(181, 26);
            this.PortTB.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(11, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Address:";
            // 
            // ipTB
            // 
            this.ipTB.BackColor = System.Drawing.Color.Gray;
            this.ipTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTB.Location = new System.Drawing.Point(16, 142);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(181, 26);
            this.ipTB.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Username:";
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.Color.Gray;
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.Location = new System.Drawing.Point(14, 61);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(181, 26);
            this.UsernameTB.TabIndex = 31;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ChatOutput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Send);
            this.splitContainer2.Panel2.Controls.Add(this.MessageBox);
            this.splitContainer2.Size = new System.Drawing.Size(1008, 614);
            this.splitContainer2.SplitterDistance = 555;
            this.splitContainer2.TabIndex = 42;
            // 
            // ChatOutput
            // 
            this.ChatOutput.BackColor = System.Drawing.Color.Gray;
            this.ChatOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChatOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatOutput.Location = new System.Drawing.Point(8, 9);
            this.ChatOutput.Multiline = true;
            this.ChatOutput.Name = "ChatOutput";
            this.ChatOutput.Size = new System.Drawing.Size(987, 543);
            this.ChatOutput.TabIndex = 44;
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.ForeColor = System.Drawing.Color.Black;
            this.Send.Location = new System.Drawing.Point(848, 10);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(153, 38);
            this.Send.TabIndex = 42;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.Color.Gray;
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.Location = new System.Drawing.Point(8, 10);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(835, 38);
            this.MessageBox.TabIndex = 43;
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
            this.CLoseButton.Click += new System.EventHandler(this.CLoseButton_Click);
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.PageNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.PageNameLabel.Location = new System.Drawing.Point(10, 10);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(104, 46);
            this.PageNameLabel.TabIndex = 2;
            this.PageNameLabel.Text = "Chat";
            // 
            // CW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1224, 672);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher";
            this.background.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Button CLoseButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PortTB;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Button Server;
        private System.Windows.Forms.Button Sniffer;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.TextBox ChatOutput;
    }
}