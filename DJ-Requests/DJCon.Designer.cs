namespace DJ_Requests
{
    partial class DJCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DJCon));
            this.Titlebar = new System.Windows.Forms.Panel();
            this.appExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestConsole = new System.Windows.Forms.FlowLayoutPanel();
            this.SLog = new System.Windows.Forms.TextBox();
            this.ExportRequests = new System.Windows.Forms.SaveFileDialog();
            this.mMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AOT = new System.Windows.Forms.ToolStripButton();
            this.HCRT = new System.Windows.Forms.ToolStripButton();
            this.HPRT = new System.Windows.Forms.ToolStripButton();
            this.Export = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titlebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.Titlebar.Controls.Add(this.appExit);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(170, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(496, 35);
            this.Titlebar.TabIndex = 0;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // appExit
            // 
            this.appExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.appExit.FlatAppearance.BorderSize = 0;
            this.appExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.appExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.appExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appExit.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.appExit.Location = new System.Drawing.Point(401, 3);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(92, 28);
            this.appExit.TabIndex = 4;
            this.appExit.Text = "Go off-air first";
            this.appExit.UseVisualStyleBackColor = false;
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(105)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 450);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 95);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F);
            this.label2.Location = new System.Drawing.Point(0, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Requests";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16.25F);
            this.label1.Location = new System.Drawing.Point(0, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RequestConsole
            // 
            this.RequestConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestConsole.AutoScroll = true;
            this.RequestConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RequestConsole.Location = new System.Drawing.Point(176, 74);
            this.RequestConsole.Name = "RequestConsole";
            this.RequestConsole.Size = new System.Drawing.Size(478, 358);
            this.RequestConsole.TabIndex = 5;
            // 
            // SLog
            // 
            this.SLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.SLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SLog.Location = new System.Drawing.Point(234, 120);
            this.SLog.Multiline = true;
            this.SLog.Name = "SLog";
            this.SLog.Size = new System.Drawing.Size(320, 288);
            this.SLog.TabIndex = 10;
            this.SLog.Visible = false;
            // 
            // ExportRequests
            // 
            this.ExportRequests.DefaultExt = "sr.log";
            this.ExportRequests.Filter = "\"Song Request Log|*.sr.log\"";
            this.ExportRequests.Title = "Export Song Requests";
            // 
            // mMenu
            // 
            this.mMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.mMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AOT,
            this.toolStripSeparator1,
            this.HCRT,
            this.HPRT,
            this.toolStripSeparator2,
            this.Export});
            this.mMenu.Location = new System.Drawing.Point(170, 35);
            this.mMenu.Name = "mMenu";
            this.mMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mMenu.Size = new System.Drawing.Size(496, 39);
            this.mMenu.TabIndex = 11;
            this.mMenu.Text = "Main Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AOT
            // 
            this.AOT.Checked = true;
            this.AOT.CheckOnClick = true;
            this.AOT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AOT.Image = global::DJ_Requests.Properties.Resources.on;
            this.AOT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AOT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AOT.Name = "AOT";
            this.AOT.Size = new System.Drawing.Size(83, 36);
            this.AOT.Text = "On-Top";
            this.AOT.ToolTipText = "When this is turned on, this window will remain pinned above all others.";
            this.AOT.CheckedChanged += new System.EventHandler(this.AOT_CheckedChanged);
            // 
            // HCRT
            // 
            this.HCRT.CheckOnClick = true;
            this.HCRT.Image = global::DJ_Requests.Properties.Resources.off;
            this.HCRT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HCRT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HCRT.Name = "HCRT";
            this.HCRT.Size = new System.Drawing.Size(137, 36);
            this.HCRT.Text = "Channel Requests";
            this.HCRT.ToolTipText = resources.GetString("HCRT.ToolTipText");
            this.HCRT.CheckedChanged += new System.EventHandler(this.HCRT_CheckedChanged);
            // 
            // HPRT
            // 
            this.HPRT.CheckOnClick = true;
            this.HPRT.Image = global::DJ_Requests.Properties.Resources.off;
            this.HPRT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HPRT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HPRT.Name = "HPRT";
            this.HPRT.Size = new System.Drawing.Size(129, 36);
            this.HPRT.Text = "Private Requests";
            this.HPRT.ToolTipText = resources.GetString("HPRT.ToolTipText");
            this.HPRT.CheckedChanged += new System.EventHandler(this.HPRT_CheckedChanged);
            // 
            // Export
            // 
            this.Export.Enabled = false;
            this.Export.Image = global::DJ_Requests.Properties.Resources.save;
            this.Export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(117, 36);
            this.Export.Text = "Save Requests";
            this.Export.ToolTipText = "Export your song requests to a text file.";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DJ_Requests.Properties.Resources.DJ;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // DJCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.mMenu);
            this.Controls.Add(this.RequestConsole);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SLog);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(666, 306);
            this.Name = "DJCon";
            this.Text = "Requests Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DJCon_FormClosed);
            this.Load += new System.EventHandler(this.DJCon_Load);
            this.Titlebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.FlowLayoutPanel RequestConsole;
        public System.Windows.Forms.Button appExit;
        public System.Windows.Forms.TextBox SLog;
        private System.Windows.Forms.SaveFileDialog ExportRequests;
        private System.Windows.Forms.ToolStrip mMenu;
        private System.Windows.Forms.ToolStripButton AOT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton HCRT;
        private System.Windows.Forms.ToolStripButton HPRT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Export;
    }
}