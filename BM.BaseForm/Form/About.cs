using BM.BaseUI.Properties;
using BM.SkinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.BaseUI
{
    public partial class About : SkinMain
    {
        #region 窗口移动
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        private const long WM_GETMINMAXINFO = 0x24;

        public struct POINTAPI
        {
            public int x;
            public int y;
        }

        public struct MINMAXINFO
        {
            public POINTAPI ptReserved;
            public POINTAPI ptMaxSize;
            public POINTAPI ptMaxPosition;
            public POINTAPI ptMinTrackSize;
            public POINTAPI ptMaxTrackSize;
        }

        private void paneMain_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 2;

            if (e.Button == MouseButtons.Left) // 按下的是鼠标左键 
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero); // 拖动窗体 
            }
        }

        #endregion

        public About()
        {
            InitializeComponent();
            labelBottom.Location = new Point((this.Width - labelBottom.Size.Width) / 2, labelBottom.Location.Y);
            labelMain.Location = new Point((this.Width - labelMain.Size.Width) / 2, labelMain.Location.Y);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        #region 属性

        [Category("About")]
        [Description("下方文本")]
        public string BottomInfo
        {
            get { return labelBottom.Text; }
            set
            {
                labelBottom.Text = value;
                labelBottom.Location = new Point((this.Width - labelBottom.Size.Width) / 2, labelBottom.Location.Y);
            }
        }

        [Category("About")]
        [Description("正文标题")]
        public string MainTitle
        {
            get { return labelMain.Text; }
            set
            {
                labelMain.Text = value;
                labelMain.Location = new Point((this.Width - labelMain.Size.Width) / 2, labelMain.Location.Y);
            }
        }

        [Category("About")]
        [Description("网站")]
        public string WebRbText
        {
            get { return rb_web.Text; }
            set
            {
                rb_web.Text = value;
            }
        }

        [Category("About")]
        [Description("论坛")]
        public string BBSRbText
        {
            get { return rb_bbs.Text; }
            set
            {
                rb_bbs.Text = value;
            }
        }
        [Category("About")]
        [Description("联系我们")]
        public string ConRbText
        {
            get { return rb_contract.Text; }
            set
            {
                rb_contract.Text = value;
            }
        }

        [Category("BaseForm")]
        [Description("Logo图像")]
        public Image MainLogo
        {
            get { return pictureBox_logo.BackgroundImage; }
            set
            {
                pictureBox_logo.BackgroundImage = value;
            }
        }

        [Category("BaseForm")]
        [Description("网站")]
        public event EventHandler cms_web_EventHandler;

        [Category("BaseForm")]
        [Description("论坛")]
        public event EventHandler cms_bbs_EventHandler;

        [Category("BaseForm")]
        [Description("联系我们")]
        public event EventHandler cms_contract_EventHandler;

        #endregion

        #region close
        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.Image = Resources.close_hover;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.Image = Resources.close_normal;
        }

        private void label_close_MouseDown(object sender, MouseEventArgs e)
        {
            label_close.Image = Resources.close_press;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        
        #region main
        private void rb_web_MouseEnter(object sender, EventArgs e)
        {
            RadioButton item = sender as RadioButton;
            switch (item.Name)
            {
                case "rb_web": { item.Image = Resources.WebSiteAbout_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;
                case "rb_bbs": { item.Image = Resources.WebSiteBBSAbout_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;
                case "rb_contract": { item.Image = Resources.ContractMeAbout_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;

            }
        }

        private void rb_web_MouseLeave(object sender, EventArgs e)
        {
            RadioButton item = sender as RadioButton;
            switch (item.Name)
            {
                case "rb_web": { item.Image = Resources.WebSiteAbout_normal; item.ForeColor = SystemColors.GrayText; } break;
                case "rb_bbs": { item.Image = Resources.WebSiteBBSAbout_normal; item.ForeColor = SystemColors.GrayText; } break;
                case "rb_contract": { item.Image = Resources.ContractMeAbout_normal; item.ForeColor = SystemColors.GrayText; } break;

            }
        }

        private void rb_web_Click(object sender, EventArgs e)
        {
            RadioButton item = sender as RadioButton;
            switch (item.Name)
            {
                case "rb_web": { if (cms_web_EventHandler != null) cms_web_EventHandler(null, null); } break;
                case "rb_bbs": { if (cms_bbs_EventHandler != null) cms_bbs_EventHandler(null, null); } break;
                case "rb_contract": { if (cms_contract_EventHandler != null) cms_contract_EventHandler(null, null); } break;

            }
        }

        #endregion

       

    }
}
