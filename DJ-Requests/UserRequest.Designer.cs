namespace DJ_Requests
{
    partial class UserRequest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rCarrier = new System.Windows.Forms.Panel();
            this.rTS = new System.Windows.Forms.Label();
            this.rChannel = new System.Windows.Forms.Label();
            this.rRequest = new System.Windows.Forms.Label();
            this.rIDHTS = new System.Windows.Forms.Label();
            this.rNick = new System.Windows.Forms.Label();
            this.MarkPlayed = new System.Windows.Forms.Button();
            this.rStatus = new System.Windows.Forms.PictureBox();
            this.RequestExpand = new System.Windows.Forms.ToolTip(this.components);
            this.MultifunctionButton = new System.Windows.Forms.ToolTip(this.components);
            this.rCopied = new System.Windows.Forms.Timer(this.components);
            this.rCarrier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // rCarrier
            // 
            this.rCarrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(117)))), ((int)(((byte)(8)))));
            this.rCarrier.Controls.Add(this.rTS);
            this.rCarrier.Controls.Add(this.rChannel);
            this.rCarrier.Controls.Add(this.rRequest);
            this.rCarrier.Controls.Add(this.rIDHTS);
            this.rCarrier.Controls.Add(this.rNick);
            this.rCarrier.Controls.Add(this.MarkPlayed);
            this.rCarrier.Controls.Add(this.rStatus);
            this.rCarrier.Location = new System.Drawing.Point(0, 0);
            this.rCarrier.Name = "rCarrier";
            this.rCarrier.Size = new System.Drawing.Size(454, 55);
            this.rCarrier.TabIndex = 1;
            // 
            // rTS
            // 
            this.rTS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rTS.Font = new System.Drawing.Font("Segoe UI Semilight", 7F);
            this.rTS.ForeColor = System.Drawing.Color.Black;
            this.rTS.Location = new System.Drawing.Point(134, 5);
            this.rTS.Name = "rTS";
            this.rTS.Size = new System.Drawing.Size(221, 12);
            this.rTS.TabIndex = 9;
            this.rTS.Text = "Request received on: Mon 12/27/2017 @ 17:32:09";
            // 
            // rChannel
            // 
            this.rChannel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rChannel.Font = new System.Drawing.Font("Segoe UI Semilight", 7F);
            this.rChannel.ForeColor = System.Drawing.Color.Black;
            this.rChannel.Location = new System.Drawing.Point(44, 22);
            this.rChannel.Name = "rChannel";
            this.rChannel.Size = new System.Drawing.Size(87, 12);
            this.rChannel.TabIndex = 8;
            this.rChannel.Text = "#Undernet";
            // 
            // rRequest
            // 
            this.rRequest.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.rRequest.ForeColor = System.Drawing.Color.White;
            this.rRequest.Location = new System.Drawing.Point(43, 34);
            this.rRequest.Name = "rRequest";
            this.rRequest.Size = new System.Drawing.Size(312, 21);
            this.rRequest.TabIndex = 7;
            this.rRequest.Text = "Song name - Song artist";
            this.rRequest.UseMnemonic = false;
            this.rRequest.DoubleClick += new System.EventHandler(this.rRequest_DoubleClick);
            // 
            // rIDHTS
            // 
            this.rIDHTS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rIDHTS.Font = new System.Drawing.Font("Segoe UI Semilight", 7F);
            this.rIDHTS.ForeColor = System.Drawing.Color.Black;
            this.rIDHTS.Location = new System.Drawing.Point(134, 22);
            this.rIDHTS.Name = "rIDHTS";
            this.rIDHTS.Size = new System.Drawing.Size(221, 12);
            this.rIDHTS.TabIndex = 6;
            this.rIDHTS.Text = "Ident@Hostname.com";
            // 
            // rNick
            // 
            this.rNick.AutoSize = true;
            this.rNick.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.rNick.ForeColor = System.Drawing.Color.White;
            this.rNick.Location = new System.Drawing.Point(43, 1);
            this.rNick.Name = "rNick";
            this.rNick.Size = new System.Drawing.Size(38, 19);
            this.rNick.TabIndex = 5;
            this.rNick.Text = "Nick";
            // 
            // MarkPlayed
            // 
            this.MarkPlayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.MarkPlayed.FlatAppearance.BorderSize = 0;
            this.MarkPlayed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.MarkPlayed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(51)))));
            this.MarkPlayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkPlayed.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.MarkPlayed.Location = new System.Drawing.Point(361, 5);
            this.MarkPlayed.Name = "MarkPlayed";
            this.MarkPlayed.Size = new System.Drawing.Size(89, 46);
            this.MarkPlayed.TabIndex = 4;
            this.MarkPlayed.Text = "Awaiting Review";
            this.MultifunctionButton.SetToolTip(this.MarkPlayed, "Left clicking this button marks this song as played.\r\nRight clicking this button " +
        "marks this song as rejected.");
            this.MarkPlayed.UseVisualStyleBackColor = false;
            this.MarkPlayed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MarkPlayed_MouseUp);
            // 
            // rStatus
            // 
            this.rStatus.Image = global::DJ_Requests.Properties.Resources.Received;
            this.rStatus.Location = new System.Drawing.Point(4, 11);
            this.rStatus.Name = "rStatus";
            this.rStatus.Size = new System.Drawing.Size(32, 32);
            this.rStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rStatus.TabIndex = 0;
            this.rStatus.TabStop = false;
            // 
            // RequestExpand
            // 
            this.RequestExpand.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.RequestExpand.ToolTipTitle = "Requested Song";
            // 
            // MultifunctionButton
            // 
            this.MultifunctionButton.AutomaticDelay = 100;
            this.MultifunctionButton.AutoPopDelay = 10000;
            this.MultifunctionButton.InitialDelay = 100;
            this.MultifunctionButton.ReshowDelay = 20;
            this.MultifunctionButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MultifunctionButton.ToolTipTitle = "This request is awaiting review";
            // 
            // rCopied
            // 
            this.rCopied.Interval = 5000;
            this.rCopied.Tick += new System.EventHandler(this.rCopied_Tick);
            // 
            // UserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.rCarrier);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserRequest";
            this.Size = new System.Drawing.Size(454, 55);
            this.Load += new System.EventHandler(this.UserRequest_Load);
            this.rCarrier.ResumeLayout(false);
            this.rCarrier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip RequestExpand;
        public System.Windows.Forms.Label rRequest;
        public System.Windows.Forms.Label rNick;
        public System.Windows.Forms.Button MarkPlayed;
        public System.Windows.Forms.PictureBox rStatus;
        public System.Windows.Forms.Panel rCarrier;
        public System.Windows.Forms.Label rChannel;
        public System.Windows.Forms.Label rIDHTS;
        public System.Windows.Forms.Label rTS;
        private System.Windows.Forms.ToolTip MultifunctionButton;
        private System.Windows.Forms.Timer rCopied;
    }
}
