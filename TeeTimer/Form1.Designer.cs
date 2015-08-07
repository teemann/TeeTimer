namespace TeeTimer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.table = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesc,
            this.colTimer});
            this.table.ContextMenuStrip = this.contextMenuStrip1;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(637, 350);
            this.table.TabIndex = 0;
            this.table.MouseDown += new System.Windows.Forms.MouseEventHandler(this.table_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.minToolStripMenuItem,
            this.minToolStripMenuItem1,
            this.customToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hToolStripMenuItem.Text = "1 h";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem.Text = "30 min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.min30ToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            this.minToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem1.Text = "10 min";
            this.minToolStripMenuItem1.Click += new System.EventHandler(this.min10ToolStripMenuItem1_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem.Text = "Custom...";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pauseToolStripMenuItem.Text = "Toggle";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // colDesc
            // 
            this.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colTimer
            // 
            this.colTimer.HeaderText = "Timer";
            this.colTimer.Name = "colTimer";
            this.colTimer.ReadOnly = true;
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.trayContextMenu;
            this.tray.Text = "TeeTimer";
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOverviewToolStripMenuItem,
            this.toolStripSeparator1,
            this.addToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(164, 82);
            // 
            // showOverviewToolStripMenuItem
            // 
            this.showOverviewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.showOverviewToolStripMenuItem.Name = "showOverviewToolStripMenuItem";
            this.showOverviewToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showOverviewToolStripMenuItem.Text = "Show Overview";
            this.showOverviewToolStripMenuItem.Click += new System.EventHandler(this.showOverviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem1,
            this.minToolStripMenuItem2,
            this.minToolStripMenuItem3,
            this.customToolStripMenuItem1});
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // hToolStripMenuItem1
            // 
            this.hToolStripMenuItem1.Name = "hToolStripMenuItem1";
            this.hToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.hToolStripMenuItem1.Text = "1 h";
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            this.minToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem2.Text = "30 min";
            // 
            // minToolStripMenuItem3
            // 
            this.minToolStripMenuItem3.Name = "minToolStripMenuItem3";
            this.minToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem3.Text = "10 min";
            // 
            // customToolStripMenuItem1
            // 
            this.customToolStripMenuItem1.Name = "customToolStripMenuItem1";
            this.customToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem1.Text = "Custom...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 374);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "TeeTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimer;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

