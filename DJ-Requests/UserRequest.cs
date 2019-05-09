using System;
using System.Drawing;
using System.Windows.Forms;

namespace DJ_Requests
{
    public partial class UserRequest : UserControl
    {
        public UserRequest()
        {
            InitializeComponent();
        }

        private void MarkPlayed_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MarkPlayed.BackColor = System.Drawing.ColorTranslator.FromHtml("#00C851");
                MarkPlayed.Text = "Song Played";
                MarkPlayed.Enabled = false;
                rCarrier.BackColor = System.Drawing.ColorTranslator.FromHtml("#007E33");
                rStatus.Image = Properties.Resources.Complete;
            }
            else
            {
                MarkPlayed.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff4444");
                MarkPlayed.Text = "Song Rejected";
                MarkPlayed.Enabled = false;
                rCarrier.BackColor = System.Drawing.ColorTranslator.FromHtml("#cc1807");
                rStatus.Image = Properties.Resources.Error;
            }
        }

        private void UserRequest_Load(object sender, EventArgs e)
        {
            RequestExpand.SetToolTip(rRequest, rRequest.Text + Environment.NewLine + "Double click to copy");
        }

        private string rd; 
        private void rRequest_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(rRequest.Text);
            rd = rRequest.Text;
            rRequest.Text = "Copied to clipboard...";
            rCopied.Enabled = true;
            rCopied.Start();
        }

        private void rCopied_Tick(object sender, EventArgs e)
        {
            rRequest.Text = rd;
            rCopied.Stop();
            rCopied.Enabled = false;
        }
    }
}
