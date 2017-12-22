using BM.BaseUI.ControlsUI;
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
    public partial class BaseForm :SkinMain
    {
        #region func
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
        private class MqxsColorTable : ProfessionalColorTable
        {
            public override System.Drawing.Color MenuItemSelected
            {
                get { return SystemColors.ButtonFace; }
            }
        }
        #endregion

        public BaseForm()
        {
            InitializeComponent();
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            
        }


        private string[] _HeadItems = new string[0];

        #region 属性

        [Category("BaseForm")]
        [Description("左下角文本")]
        [DefaultValue("ZhangUi 1.0.0.0")]
        public string LeftInfo
        {
            get { return labelLeft.Text; }
            set
            {
                labelLeft.Text = value;
            }
        }

        [Category("BaseForm")]
        [Description("右下角文本")]
        [DefaultValue("版权所有 © 翻版必究")]
        public string RightInfo
        {
            get { return labelRight.Text; }
            set
            {
                labelRight.Text = value;
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
        [Description("头控制区 ")]
        public string[] HeadItems
        {
            get { return _HeadItems; }
            set
            {
                SetHeadItem(value);
            }
        }

        [Category("BaseForm")]
        [Description("是否显示menu ")]
        [DefaultValue(true)]
        public bool ShowMenu
        {
            get { return label_menu.Visible; }
            set
            {
                label_menu.Visible = value;
            }
        } 

        #endregion

        #region 事件

        [Category("BaseForm")]
        [Description("系统设置")]
        public event EventHandler cms_setting_EventHandler;

        [Category("BaseForm")]
        [Description("软件更新")]
        public event EventHandler cms_update_EventHandler;

        [Category("BaseForm")]
        [Description("网站")]
        public event EventHandler cms_web_EventHandler;

        [Category("BaseForm")]
        [Description("问题意见")]
        public event EventHandler cms_question_EventHandler;

        [Category("BaseForm")]
        [Description("关于")]
        public event EventHandler cms_about_EventHandler;

        public delegate void MenuSelectedChanged(object sender, MenuSelectedArgs e);

        [Category("BaseForm")]
        [Description("主菜单更改")]
        public event MenuSelectedChanged MenuSelectedChanged_EventHandler;

        #endregion

        #region 函数
        /// <summary>
        /// 重设头控制区
        /// </summary>
        /// <param name="head"></param>
        private void SetHeadItem(string[] head)
        {
            if (head == null || head.Count() == 0)
            {
                _HeadItems = new string[0];
            }
            else
            {
                _HeadItems = head;
            }

            foreach (var item in panel_top.Controls)
            {
                if (item.GetType().Name == "RadioHeader" || item.GetType().Name == "SplitHeader")
                {
                    panel_top.Controls.Remove((Control)item);
                }
            }


            int lw = 173;
            for (int i = 0; i < _HeadItems.Count(); i++)
            {
                RadioHeader rh = new RadioHeader();

                rh.Text = _HeadItems[i];
                rh.AutoSize = false;
                int w = (int)this.CreateGraphics().MeasureString(rh.Text, rh.Font).Width;
                w += 10;
                rh.Size = new Size(w, 66);
                rh.Location = new Point(lw, 7);
                rh.Click += rh_Click;
                lw += w;
                rh.Tag = i;
                panel_top.Controls.Add(rh);
                //TabPage page = new TabPage();
                //page.Text = "";
                //page.UseVisualStyleBackColor = true;

                if (i != _HeadItems.Count() - 1)
                {
                    lw += 5;
                    SplitHeader sh = new SplitHeader();
                    sh.Size = new Size(10, 29);
                    sh.Location = new Point(lw, 29);
                    lw += 5;
                    panel_top.Controls.Add(sh);
                }
            }
          
        }


        private void rh_Click(object sender, EventArgs e)
        {
            int index = (int)((RadioHeader)sender).Tag;

            if (MenuSelectedChanged_EventHandler != null)
            {
                MenuSelectedChanged_EventHandler(sender, new MenuSelectedArgs() { index = index, MenuName = ((RadioHeader)sender).Text });
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();//使当前控件无效，重绘控件
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
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

        #region ControlBox 
        /// <summary>
        /// 控制box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_windowstool_Click(object sender, EventArgs e)
        {
            Label l = sender as Label;
            switch (l.Name)
            {
                case "label_min": { this.WindowState = FormWindowState.Minimized; } break;
                case "label_max":
                    {

                        if (this.WindowState == FormWindowState.Maximized)
                        { this.WindowState = FormWindowState.Normal; }
                        else { this.WindowState = FormWindowState.Maximized; }

                    } break;
                case "label_menu": { cms_tools.Show(l, l.Left, l.Top + l.Height); } break;
                case "label_close":
                    {
                        var dr = new ZwMessageBox("确定关闭软件？").ShowDialog();
                        if (dr == DialogResult.OK)
                        { this.Close(); } 
                        break;
                    }

            }
        }

        private void label_windowstool_MouseEnter(object sender, EventArgs e)
        {
            Label l = sender as Label;
            switch (l.Name)
            {
                case "label_min": { l.Image = Resources.min_hover; } break;
                case "label_max": { if (this.WindowState == FormWindowState.Maximized) { l.Image = Resources.store_hover; } else { l.Image = Resources.max_hover; } } break;
                case "label_menu": { l.Image = Resources.menu_hover; } break;
                case "label_close": { l.Image = Resources.close_hover; } break;

            }
        }

        private void label_windowstool_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;
            switch (l.Name)
            {
                case "label_min": { l.Image = Resources.min_normal; } break;
                case "label_max": { if (this.WindowState == FormWindowState.Maximized) { l.Image = Resources.store_normal; } else { l.Image = Resources.max_normal; } } break;
                case "label_menu": { l.Image = Resources.menu_normal; } break;
                case "label_close": { l.Image = Resources.close_normal; } break;

            }
        }

        private void label_windowstool_MouseDown(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;
            switch (l.Name)
            {
                case "label_min": { l.Image = Resources.min_press; } break;
                case "label_max": { if (this.WindowState == FormWindowState.Maximized) { l.Image = Resources.store_press; } else { l.Image = Resources.max_press; } } break;
                case "label_menu": { l.Image = Resources.menu_press; } break;
                case "label_close": { l.Image = Resources.close_press; } break;



            }
        }
        #endregion 

        #region cmsContron

        private void cms_item_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            switch (item.Name)
            {
                case "cms_item_setting": { item.Image = Resources.menu_set_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;
                case "cms_item_update": { item.Image = Resources.menu_update_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;
                case "cms_item_web": { item.Image = Resources.menu_bbs_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;
                case "cms_item_question": { item.Image = Resources.menu_feedback_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;
                case "cms_item_about": { item.Image = Resources.menu_about_hot; item.ForeColor = Color.FromArgb(7, 174, 185); } break;
            }
        }

        private void cms_item_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            switch (item.Name)
            {
                case "cms_item_setting": { item.Image = Resources.menu_set; item.ForeColor = SystemColors.GrayText; } break;
                case "cms_item_update": { item.Image = Resources.menu_update; item.ForeColor = SystemColors.GrayText; } break;
                case "cms_item_web": { item.Image = Resources.menu_bbs; item.ForeColor = SystemColors.GrayText; } break;
                case "cms_item_question": { item.Image = Resources.menu_feedback; item.ForeColor = SystemColors.GrayText; } break;
                case "cms_item_about": { item.Image = Resources.menu_about; item.ForeColor = SystemColors.GrayText; } break;
            }
        }

        private void cms_item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            switch (item.Name)
            {
                case "cms_item_setting":
                    if (cms_setting_EventHandler != null)
                    {
                        cms_setting_EventHandler(null, null);
                    }
                    break;
                case "cms_item_update":
                    if (cms_update_EventHandler != null)
                    {
                        cms_update_EventHandler(null, null);
                    }
                    break;
                case "cms_item_web":
                    if (cms_web_EventHandler != null)
                    {
                        cms_web_EventHandler(null, null);
                    }
                    break;
                case "cms_item_question":
                    if (cms_question_EventHandler != null)
                    {
                        cms_question_EventHandler(null, null);
                    }
                    break;
                case "cms_item_about":
                    if (cms_about_EventHandler != null)
                    {
                        cms_about_EventHandler(null, null);
                    }
                    break;
            }
        }

        #endregion cmsContron

    }

    public class MenuSelectedArgs : EventArgs
    {
        public string MenuName { set; get; }
        public int index { set; get; }
    }
}
