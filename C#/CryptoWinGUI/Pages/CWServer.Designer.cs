namespace CryptoWinGUI.Pages
{
    partial class CWServer
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
            this.ChatOutput = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatOutput
            // 
            this.ChatOutput.BackColor = System.Drawing.Color.Gray;
            this.ChatOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChatOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatOutput.Location = new System.Drawing.Point(204, 12);
            this.ChatOutput.Multiline = true;
            this.ChatOutput.Name = "ChatOutput";
            this.ChatOutput.Size = new System.Drawing.Size(698, 588);
            this.ChatOutput.TabIndex = 51;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Stop.Enabled = false;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Stop.ForeColor = System.Drawing.Color.Black;
            this.Stop.Location = new System.Drawing.Point(10, 223);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(179, 33);
            this.Stop.TabIndex = 50;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // ipTB
            // 
            this.ipTB.BackColor = System.Drawing.Color.Gray;
            this.ipTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTB.Location = new System.Drawing.Point(12, 47);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(181, 26);
            this.ipTB.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Address:";
            // 
            // PortTB
            // 
            this.PortTB.BackColor = System.Drawing.Color.Gray;
            this.PortTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortTB.Location = new System.Drawing.Point(10, 125);
            this.PortTB.MaxLength = 5;
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(181, 26);
            this.PortTB.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Port:";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(10, 181);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(179, 33);
            this.Start.TabIndex = 49;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CWServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(920, 613);
            this.Controls.Add(this.ChatOutput);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PortTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipTB);
            this.Name = "CWServer";
            this.Text = "CWServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatOutput;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Start;
    }
}