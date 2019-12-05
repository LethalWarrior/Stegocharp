namespace Steganography
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TbxPath = new System.Windows.Forms.TextBox();
            this.MainPb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnProceed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxOperation = new System.Windows.Forms.ComboBox();
            this.PnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPb)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.PnlHeader.Controls.Add(this.BtnMin);
            this.PnlHeader.Controls.Add(this.BtnClose);
            this.PnlHeader.Controls.Add(this.label1);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.ForeColor = System.Drawing.Color.White;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(662, 53);
            this.PnlHeader.TabIndex = 0;
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.BtnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.Location = new System.Drawing.Point(542, 9);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(51, 30);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.TabStop = false;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(599, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(51, 30);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steganography";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBrowse);
            this.groupBox1.Controls.Add(this.TbxPath);
            this.groupBox1.Controls.Add(this.MainPb);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 376);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowse.ForeColor = System.Drawing.Color.White;
            this.BtnBrowse.Location = new System.Drawing.Point(24, 318);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(250, 34);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "Browse...";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TbxPath
            // 
            this.TbxPath.Enabled = false;
            this.TbxPath.Location = new System.Drawing.Point(24, 285);
            this.TbxPath.Name = "TbxPath";
            this.TbxPath.Size = new System.Drawing.Size(250, 27);
            this.TbxPath.TabIndex = 8;
            // 
            // MainPb
            // 
            this.MainPb.Image = ((System.Drawing.Image)(resources.GetObject("MainPb.Image")));
            this.MainPb.Location = new System.Drawing.Point(24, 26);
            this.MainPb.Name = "MainPb";
            this.MainPb.Size = new System.Drawing.Size(250, 250);
            this.MainPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPb.TabIndex = 4;
            this.MainPb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 36);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(-99, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(856, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyleft Robby Auziqni, 2019";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnProceed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TbxMessage);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CbxOperation);
            this.groupBox2.Location = new System.Drawing.Point(325, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // BtnProceed
            // 
            this.BtnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnProceed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProceed.ForeColor = System.Drawing.Color.White;
            this.BtnProceed.Location = new System.Drawing.Point(211, 101);
            this.BtnProceed.Name = "BtnProceed";
            this.BtnProceed.Size = new System.Drawing.Size(108, 34);
            this.BtnProceed.TabIndex = 9;
            this.BtnProceed.Text = "Proceed";
            this.BtnProceed.UseVisualStyleBackColor = false;
            this.BtnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Message";
            // 
            // TbxMessage
            // 
            this.TbxMessage.Location = new System.Drawing.Point(88, 68);
            this.TbxMessage.Name = "TbxMessage";
            this.TbxMessage.Size = new System.Drawing.Size(231, 27);
            this.TbxMessage.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Operation";
            // 
            // CbxOperation
            // 
            this.CbxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxOperation.FormattingEnabled = true;
            this.CbxOperation.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.CbxOperation.Location = new System.Drawing.Point(88, 31);
            this.CbxOperation.Name = "CbxOperation";
            this.CbxOperation.Size = new System.Drawing.Size(231, 28);
            this.CbxOperation.TabIndex = 9;
            this.CbxOperation.SelectedIndexChanged += new System.EventHandler(this.CbxOperation_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox MainPb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TbxPath;
        private System.Windows.Forms.ComboBox CbxOperation;
        private System.Windows.Forms.Button BtnProceed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxMessage;
        private System.Windows.Forms.Label label3;
    }
}