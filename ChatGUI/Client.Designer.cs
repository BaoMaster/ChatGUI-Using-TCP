namespace ChatGUI
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSerPort = new System.Windows.Forms.NumericUpDown();
            this.butKetnoi = new System.Windows.Forms.Button();
            this.laTrangThai = new System.Windows.Forms.Label();
            this.txtNdChat = new System.Windows.Forms.TextBox();
            this.txtThongDiep = new System.Windows.Forms.TextBox();
            this.butGui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP:";
            // 
            // txtSerIP
            // 
            this.txtSerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerIP.Location = new System.Drawing.Point(154, 37);
            this.txtSerIP.Name = "txtSerIP";
            this.txtSerIP.Size = new System.Drawing.Size(160, 26);
            this.txtSerIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // numSerPort
            // 
            this.numSerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSerPort.Location = new System.Drawing.Point(414, 37);
            this.numSerPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSerPort.Name = "numSerPort";
            this.numSerPort.Size = new System.Drawing.Size(132, 26);
            this.numSerPort.TabIndex = 3;
            // 
            // butKetnoi
            // 
            this.butKetnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKetnoi.Location = new System.Drawing.Point(606, 37);
            this.butKetnoi.Name = "butKetnoi";
            this.butKetnoi.Size = new System.Drawing.Size(99, 26);
            this.butKetnoi.TabIndex = 4;
            this.butKetnoi.Text = "Connect";
            this.butKetnoi.UseVisualStyleBackColor = true;
            this.butKetnoi.Click += new System.EventHandler(this.butKetnoi_Click);
            // 
            // laTrangThai
            // 
            this.laTrangThai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.laTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTrangThai.Location = new System.Drawing.Point(12, 78);
            this.laTrangThai.Name = "laTrangThai";
            this.laTrangThai.Size = new System.Drawing.Size(707, 35);
            this.laTrangThai.TabIndex = 6;
            this.laTrangThai.Text = "Not Connect!";
            this.laTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNdChat
            // 
            this.txtNdChat.Location = new System.Drawing.Point(12, 116);
            this.txtNdChat.Multiline = true;
            this.txtNdChat.Name = "txtNdChat";
            this.txtNdChat.ReadOnly = true;
            this.txtNdChat.Size = new System.Drawing.Size(707, 218);
            this.txtNdChat.TabIndex = 7;
            // 
            // txtThongDiep
            // 
            this.txtThongDiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongDiep.Location = new System.Drawing.Point(12, 351);
            this.txtThongDiep.Name = "txtThongDiep";
            this.txtThongDiep.Size = new System.Drawing.Size(558, 26);
            this.txtThongDiep.TabIndex = 8;
            // 
            // butGui
            // 
            this.butGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGui.Location = new System.Drawing.Point(586, 351);
            this.butGui.Name = "butGui";
            this.butGui.Size = new System.Drawing.Size(143, 26);
            this.butGui.TabIndex = 9;
            this.butGui.Text = "Send";
            this.butGui.UseVisualStyleBackColor = true;
            this.butGui.Click += new System.EventHandler(this.butGui_Click);
            // 
            // Client
            // 
            this.AcceptButton = this.butGui;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 389);
            this.Controls.Add(this.butGui);
            this.Controls.Add(this.txtThongDiep);
            this.Controls.Add(this.txtNdChat);
            this.Controls.Add(this.laTrangThai);
            this.Controls.Add(this.butKetnoi);
            this.Controls.Add(this.numSerPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerIP);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Chat GUI Client";
            ((System.ComponentModel.ISupportInitialize)(this.numSerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSerPort;
        private System.Windows.Forms.Button butKetnoi;
        private System.Windows.Forms.Label laTrangThai;
        private System.Windows.Forms.TextBox txtNdChat;
        private System.Windows.Forms.TextBox txtThongDiep;
        private System.Windows.Forms.Button butGui;
    }
}