namespace TeeTimer
{
    partial class AddTimer
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
            this.nD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nS = new System.Windows.Forms.NumericUpDown();
            this.btOK = new System.Windows.Forms.Button();
            this.tDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // nD
            // 
            this.nD.Location = new System.Drawing.Point(15, 61);
            this.nD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nD.Name = "nD";
            this.nD.Size = new System.Drawing.Size(47, 20);
            this.nD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "h";
            // 
            // nH
            // 
            this.nH.Location = new System.Drawing.Point(114, 61);
            this.nH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nH.Name = "nH";
            this.nH.Size = new System.Drawing.Size(47, 20);
            this.nH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "min";
            // 
            // nM
            // 
            this.nM.Location = new System.Drawing.Point(196, 61);
            this.nM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nM.Name = "nM";
            this.nM.Size = new System.Drawing.Size(47, 20);
            this.nM.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "sec";
            // 
            // nS
            // 
            this.nS.Location = new System.Drawing.Point(288, 61);
            this.nS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nS.Name = "nS";
            this.nS.Size = new System.Drawing.Size(47, 20);
            this.nS.TabIndex = 5;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(283, 87);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tDesc
            // 
            this.tDesc.Location = new System.Drawing.Point(15, 25);
            this.tDesc.Name = "tDesc";
            this.tDesc.Size = new System.Drawing.Size(343, 20);
            this.tDesc.TabIndex = 1;
            this.tDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tDesc_KeyDown);
            // 
            // AddTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 121);
            this.Controls.Add(this.tDesc);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Timer";
            ((System.ComponentModel.ISupportInitialize)(this.nD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nS;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tDesc;
    }
}