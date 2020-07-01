namespace ChatGUI
{
    partial class Server
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
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.butKhhoiTao = new System.Windows.Forms.Button();
            this.txtNdChat = new System.Windows.Forms.TextBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.txtThongDiep = new System.Windows.Forms.TextBox();
            this.butGui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server run on port";
            // 
            // numServerPort
            // 
            this.numServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numServerPort.Location = new System.Drawing.Point(222, 26);
            this.numServerPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(255, 26);
            this.numServerPort.TabIndex = 1;
            this.numServerPort.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // butKhhoiTao
            // 
            this.butKhhoiTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKhhoiTao.Location = new System.Drawing.Point(553, 26);
            this.butKhhoiTao.Name = "butKhhoiTao";
            this.butKhhoiTao.Size = new System.Drawing.Size(127, 26);
            this.butKhhoiTao.TabIndex = 2;
            this.butKhhoiTao.Text = "Create Server";
            this.butKhhoiTao.UseVisualStyleBackColor = true;
            this.butKhhoiTao.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNdChat
            // 
            this.txtNdChat.Location = new System.Drawing.Point(12, 110);
            this.txtNdChat.Multiline = true;
            this.txtNdChat.Name = "txtNdChat";
            this.txtNdChat.Size = new System.Drawing.Size(707, 218);
            this.txtNdChat.TabIndex = 4;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(12, 72);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(707, 35);
            this.lbTrangThai.TabIndex = 5;
            this.lbTrangThai.Text = "Not Connect!";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTrangThai.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtThongDiep
            // 
            this.txtThongDiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongDiep.Location = new System.Drawing.Point(12, 351);
            this.txtThongDiep.Name = "txtThongDiep";
            this.txtThongDiep.Size = new System.Drawing.Size(558, 26);
            this.txtThongDiep.TabIndex = 6;
            // 
            // butGui
            // 
            this.butGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGui.Location = new System.Drawing.Point(576, 352);
            this.butGui.Name = "butGui";
            this.butGui.Size = new System.Drawing.Size(143, 26);
            this.butGui.TabIndex = 7;
            this.butGui.Text = "Send";
            this.butGui.UseVisualStyleBackColor = true;
            this.butGui.Click += new System.EventHandler(this.butGui_Click);
            // 
            // Server
            // 
            this.AcceptButton = this.butGui;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 389);
            this.Controls.Add(this.butGui);
            this.Controls.Add(this.txtThongDiep);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.txtNdChat);
            this.Controls.Add(this.butKhhoiTao);
            this.Controls.Add(this.numServerPort);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Chat GUI Server";
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.Button butKhhoiTao;
        private System.Windows.Forms.TextBox txtNdChat;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.TextBox txtThongDiep;
        private System.Windows.Forms.Button butGui;
    }
}