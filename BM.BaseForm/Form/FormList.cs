
using BM.BaseUI.Properties;
using BM.SkinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.BaseUI
{
    /// <summary>
    /// 表单
    /// </summary>
    public partial class FormList : SkinMain
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

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
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

        public FormList()
        {
            InitializeComponent();

            buttonOK.Location = new Point(panelBottom.Width / 3 - buttonOK.Width / 2, buttonOK.Height);
            buttonCancel.Location = new Point(panelBottom.Width * 2 / 3 - buttonCancel.Width / 2, buttonCancel.Height);

        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (buttonCancel != null)
            {
                buttonOK.Location = new Point(panelBottom.Width / 3 - buttonOK.Width / 2, buttonOK.Height);
                buttonCancel.Location = new Point(panelBottom.Width * 2 / 3 - buttonCancel.Width / 2, buttonCancel.Height);
            }
        }

        #region 属性
        [Category("FormList")]
        [Description("左上角标题")]
        public string TitleInfo
        {
            get { return label_title.Text; }
            set
            {
                label_title.Text = value;
            }
        }

        public event EventHandler BtOk;

        public event EventHandler BtCancel;

        #endregion

        #region OK or Cancel


        /// <summary>
        /// OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool ck = true;
            foreach (var item in panelMain.Controls)
            {
                if (item.GetType().Name == "CheckTextBox")
                {
                    if (!((dynamic)item).ValueCheck)
                    {
                        ck = false;
                    }
                }
            }
            if (!ck)
            {
                ZwMessageBox.ShowMsg("输入错误!");
                return;
            }

            if (BtOk != null)
            {
                BtOk(null, null);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (BtCancel != null)
            {
                BtCancel(null, null);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion

        #region 鼠标事件
        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Image = Resources.close_hover;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Image = Resources.close_normal;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                buttonOK_Click(null, null);
                return true;
            }
            if (keyData == Keys.Escape)
            {
                buttonCancel_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
