
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DJ_Requests
{
    public partial class DJCon : Form
    {
        //link to main plugin
        MainPlugin mp;
        public DJCon(MainPlugin mainPlugin)
        {
            this.mp = mainPlugin;
            InitializeComponent();
            //Used for resizing
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        
        //Resize code
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkOrange, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        //Titlebar Code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); }
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DJCon_Load(object sender, EventArgs e)
        {
            mp.displayed = 1;
            if (Properties.Settings.Default.aott == true)
            {
                AOT.Checked = true;
                AOT.Image = Properties.Resources.on;
                this.TopMost = true;
            }
            else if (Properties.Settings.Default.aott == false)
            {
                AOT.Checked = false;
                AOT.Image = Properties.Resources.off;
                this.TopMost = false;
            }

            if (Properties.Settings.Default.hcr == true)
            {
                HCRT.Checked = true;
                HCRT.Image = Properties.Resources.on;
            }
            else if (Properties.Settings.Default.hcr == false)
            {
                HCRT.Checked = false;
                HCRT.Image = Properties.Resources.off;
            }

            if (Properties.Settings.Default.hpr == true)
            {
                HPRT.Checked = true;
                HPRT.Image = Properties.Resources.on;
            }
            else if (Properties.Settings.Default.hpr == false)
            {
                HPRT.Checked = false;
                HPRT.Image = Properties.Resources.off;
            }
        }

        private void DJCon_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp.displayed = 0;
            mp.con = null;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About showinfo = new About();
            showinfo.ShowDialog();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportSR = new SaveFileDialog();
            ExportSR.InitialDirectory = @"C:\users\";
            ExportSR.Title = "Export Song Requests";
            ExportSR.CheckFileExists = true;
            ExportSR.CheckPathExists = true;
            ExportSR.DefaultExt = "sr.log";
            ExportSR.Filter = "Song Request Log (*.sr.log)|*.sr.log|All files (*.*)|*.*";
            ExportSR.FilterIndex = 2;
            ExportSR.RestoreDirectory = true;
            if (ExportSR.ShowDialog() == DialogResult.OK)
            {
                SLog.Text = ExportSR.FileName;
            }
            mp.Client.ActiveIWindow.OutputText("*** [DJ REQUESTS] Song Request log has been exported.");
        }

        private void HCRT_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.hcr == false)
            {
                HCRT.Checked = true;
                HCRT.Image = Properties.Resources.off;
                Properties.Settings.Default.hcr = true;
                Properties.Settings.Default.Save();
            }
            else if (Properties.Settings.Default.hcr == true)
            {
                HCRT.Checked = false;
                HCRT.Image = Properties.Resources.on;
                Properties.Settings.Default.hcr = false;
                Properties.Settings.Default.Save();
            }
        }

        private void HPRT_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.hpr == false)
            {
                HPRT.Checked = true;
                HPRT.Image = Properties.Resources.off;
                Properties.Settings.Default.hpr = true;
                Properties.Settings.Default.Save();
            }
            else if (Properties.Settings.Default.hpr == true)
            {
                HPRT.Checked = false;
                HPRT.Image = Properties.Resources.on;
                Properties.Settings.Default.hpr = false;
                Properties.Settings.Default.Save();
            }
        }

        private void AOT_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.aott == false)
            {
                AOT.Checked = true;
                AOT.Image = Properties.Resources.on;
                this.TopMost = true;
                Properties.Settings.Default.aott = true;
                Properties.Settings.Default.Save();
            }
            else if (Properties.Settings.Default.aott == true)
            {
                AOT.Checked = false;
                AOT.Image = Properties.Resources.off;
                this.TopMost = false;
                Properties.Settings.Default.aott = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
