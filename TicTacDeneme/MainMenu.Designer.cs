namespace TicTacDeneme
{
    partial class MainMenu
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlIpAddress = new System.Windows.Forms.Panel();
            this.pnlPvAI = new System.Windows.Forms.Panel();
            this.cboxTimed = new System.Windows.Forms.CheckBox();
            this.pnlIpAddress.SuspendLayout();
            this.pnlPvAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(3, 34);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(213, 32);
            this.txtIP.TabIndex = 8;
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbO.Location = new System.Drawing.Point(92, 12);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(84, 33);
            this.rbO.TabIndex = 9;
            this.rbO.TabStop = true;
            this.rbO.Text = "O ol";
            this.rbO.UseVisualStyleBackColor = true;
            this.rbO.Click += new System.EventHandler(this.rbO_Click);
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbX.Location = new System.Drawing.Point(3, 12);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(84, 33);
            this.rbX.TabIndex = 10;
            this.rbX.TabStop = true;
            this.rbX.Text = "X Ol";
            this.rbX.UseVisualStyleBackColor = true;
            this.rbX.Click += new System.EventHandler(this.rbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Adresi :";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 184);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(235, 95);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Başla !";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlIpAddress
            // 
            this.pnlIpAddress.Controls.Add(this.label1);
            this.pnlIpAddress.Controls.Add(this.txtIP);
            this.pnlIpAddress.Location = new System.Drawing.Point(282, 98);
            this.pnlIpAddress.Name = "pnlIpAddress";
            this.pnlIpAddress.Size = new System.Drawing.Size(226, 81);
            this.pnlIpAddress.TabIndex = 13;
            // 
            // pnlPvAI
            // 
            this.pnlPvAI.Controls.Add(this.rbO);
            this.pnlPvAI.Controls.Add(this.rbX);
            this.pnlPvAI.Location = new System.Drawing.Point(282, 45);
            this.pnlPvAI.Name = "pnlPvAI";
            this.pnlPvAI.Size = new System.Drawing.Size(184, 57);
            this.pnlPvAI.TabIndex = 0;
            // 
            // cboxTimed
            // 
            this.cboxTimed.AutoSize = true;
            this.cboxTimed.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTimed.Location = new System.Drawing.Point(282, 19);
            this.cboxTimed.Name = "cboxTimed";
            this.cboxTimed.Size = new System.Drawing.Size(205, 33);
            this.cboxTimed.TabIndex = 11;
            this.cboxTimed.Text = "Zaman Modlu";
            this.cboxTimed.UseVisualStyleBackColor = true;
            this.cboxTimed.Click += new System.EventHandler(this.cboxTimed_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 345);
            this.Controls.Add(this.cboxTimed);
            this.Controls.Add(this.pnlPvAI);
            this.Controls.Add(this.pnlIpAddress);
            this.Controls.Add(this.btnStart);
            this.Name = "MainMenu";
            this.Text = "Yeni Oyun";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnlIpAddress.ResumeLayout(false);
            this.pnlIpAddress.PerformLayout();
            this.pnlPvAI.ResumeLayout(false);
            this.pnlPvAI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlIpAddress;
        private System.Windows.Forms.Panel pnlPvAI;
        private System.Windows.Forms.CheckBox cboxTimed;
    }
}