namespace TeeTimer
{
    partial class Popup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbTim = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.pMain);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 158);
            this.panel1.TabIndex = 0;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 123);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(272, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.lbDesc);
            this.pMain.Controls.Add(this.lbTim);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(272, 100);
            this.pMain.TabIndex = 3;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(99, 47);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(80, 13);
            this.lbDesc.TabIndex = 1;
            this.lbDesc.Text = "Geschirr spülen";
            // 
            // lbTim
            // 
            this.lbTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(110, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(59, 24);
            this.lbTim.TabIndex = 0;
            this.lbTim.Text = "Timer";
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 158);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbTim;
    }
}