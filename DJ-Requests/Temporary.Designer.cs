namespace DJ_Requests
{
    partial class Temporary
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
            this.Reqs = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nick = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Request = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Reqs
            // 
            this.Reqs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reqs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Reqs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reqs.CheckBoxes = true;
            this.Reqs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nick,
            this.ConInfo,
            this.Channel,
            this.Request});
            this.Reqs.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.Reqs.ForeColor = System.Drawing.Color.White;
            this.Reqs.FullRowSelect = true;
            this.Reqs.HideSelection = false;
            this.Reqs.Location = new System.Drawing.Point(171, 30);
            this.Reqs.Name = "Reqs";
            this.Reqs.Size = new System.Drawing.Size(458, 391);
            this.Reqs.TabIndex = 3;
            this.Reqs.UseCompatibleStateImageBehavior = false;
            this.Reqs.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nick
            // 
            this.Nick.Text = "Nick";
            this.Nick.Width = 91;
            // 
            // ConInfo
            // 
            this.ConInfo.Text = "Host@Ident";
            this.ConInfo.Width = 124;
            // 
            // Channel
            // 
            this.Channel.Text = "Channel";
            // 
            // Request
            // 
            this.Request.Text = "Requested Song";
            this.Request.Width = 98;
            // 
            // Temporary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reqs);
            this.Name = "Temporary";
            this.Text = "Temporary";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView Reqs;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nick;
        private System.Windows.Forms.ColumnHeader ConInfo;
        private System.Windows.Forms.ColumnHeader Channel;
        private System.Windows.Forms.ColumnHeader Request;
    }
}