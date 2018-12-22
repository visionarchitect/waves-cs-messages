namespace WavesPoC1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRecipiant = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbMyMsg = new System.Windows.Forms.TextBox();
            this.tbReceived = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbSeed = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress.Location = new System.Drawing.Point(3, 16);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(434, 20);
            this.tbAddress.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRecipiant);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 43);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipiant Address";
            // 
            // tbRecipiant
            // 
            this.tbRecipiant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecipiant.Location = new System.Drawing.Point(3, 16);
            this.tbRecipiant.Name = "tbRecipiant";
            this.tbRecipiant.Size = new System.Drawing.Size(434, 20);
            this.tbRecipiant.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSync);
            this.groupBox3.Controls.Add(this.lbValue);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.btnReceive);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 43);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // btnReceive
            // 
            this.btnReceive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReceive.Location = new System.Drawing.Point(3, 16);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 24);
            this.btnReceive.TabIndex = 0;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSend.Location = new System.Drawing.Point(78, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 24);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbMyMsg);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "My message";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbReceived);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 272);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 197);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Received";
            // 
            // tbMyMsg
            // 
            this.tbMyMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMyMsg.Location = new System.Drawing.Point(3, 16);
            this.tbMyMsg.Multiline = true;
            this.tbMyMsg.Name = "tbMyMsg";
            this.tbMyMsg.Size = new System.Drawing.Size(434, 81);
            this.tbMyMsg.TabIndex = 0;
            // 
            // tbReceived
            // 
            this.tbReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReceived.Location = new System.Drawing.Point(3, 16);
            this.tbReceived.Multiline = true;
            this.tbReceived.Name = "tbReceived";
            this.tbReceived.Size = new System.Drawing.Size(434, 178);
            this.tbReceived.TabIndex = 0;
            // 
            // lbValue
            // 
            this.lbValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbValue.Location = new System.Drawing.Point(389, 16);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(48, 24);
            this.lbValue.TabIndex = 2;
            this.lbValue.Text = "0";
            // 
            // btnSync
            // 
            this.btnSync.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSync.Location = new System.Drawing.Point(345, 16);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(44, 24);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbSeed);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(440, 43);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "My Seed";
            // 
            // tbSeed
            // 
            this.tbSeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSeed.Location = new System.Drawing.Point(3, 16);
            this.tbSeed.Name = "tbSeed";
            this.tbSeed.Size = new System.Drawing.Size(434, 20);
            this.tbSeed.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 469);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Waves App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbRecipiant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbMyMsg;
        private System.Windows.Forms.TextBox tbReceived;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbSeed;
    }
}

