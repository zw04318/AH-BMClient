using BM.BaseUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.BaseUI.ControlsUI
{
    public partial class ZwComboBox : ComboBox
    {
        public ZwComboBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.UpdateStyles();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            if (!DesignMode && this.Items.Count != 0)
            {
                this.DropDownHeight = (int)(this.Items.Count * this.Height);
            };
        }

        const int WM_ERASEBKGND = 0x14;
        const int WM_PAINT = 0xF;
        const int WM_NC_HITTEST = 0x84;
        const int WM_NC_PAINT = 0x85;
        const int WM_PRINTCLIENT = 0x318;
        const int WM_SETCURSOR = 0x20;

        protected override void WndProc(ref Message m)
        {
            IntPtr hDC = IntPtr.Zero;
            Graphics gdc = null;

            switch (m.Msg)
            {
                case 133:
                    hDC = Win32.GetWindowDC(m.HWnd);
                    gdc = Graphics.FromHdc(hDC);
                    Win32.SendMessage(this.Handle, WM_ERASEBKGND, hDC.ToInt32(), 0);
                    SendPrintClientMsg();
                    Win32.SendMessage(this.Handle, WM_PAINT, 0, 0);
                    OverrideControlBorder(gdc);
                    m.Result = (IntPtr)1;	// indicate msg has been processed
                    Win32.ReleaseDC(m.HWnd, hDC);
                    gdc.Dispose();
                    break;
                case WM_PAINT:
                    base.WndProc(ref m);
                    hDC = Win32.GetWindowDC(m.HWnd);
                    gdc = Graphics.FromHdc(hDC);

                    //OverrideDropDown(gdc);
                    OverrideControlBorder(gdc);
                    Win32.ReleaseDC(m.HWnd, hDC);
                    gdc.Dispose();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
            //base.WndProc(ref m);
            //if (m.Msg == 0xf || m.Msg == 0x133)
            //{
            //    Shared.ResetBorderColor(m, this);
            //}
        }
       

        private void OverrideControlBorder(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.FromArgb(7, 174, 185), 2), new Rectangle(0, 0, this.Width, this.Height));

        }

        private void SendPrintClientMsg()
        {
            // We send this message for the control to redraw the client area
            Graphics gClient = this.CreateGraphics();
            IntPtr ptrClientDC = gClient.GetHdc();
            Win32.SendMessage(this.Handle, WM_PRINTCLIENT, ptrClientDC.ToInt32(), 0);
            gClient.ReleaseHdc(ptrClientDC);
            gClient.Dispose();
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            //绘制区域
            Rectangle r = e.Bounds;

            Font fn = null;
            if (e.Index >= 0)
            {
                //设置字体、字符串格式、对齐方式
                fn = e.Font;
                string s = this.Items[e.Index].ToString();
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                //根据不同的状态用不同的颜色表示
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected || (e.State & DrawItemState.HotLight) == DrawItemState.HotLight)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(7, 174, 185)), r);
                    e.Graphics.DrawString(s, fn, new SolidBrush(SystemColors.ButtonHighlight), r, sf);
                    e.DrawFocusRectangle();
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.HighlightText), r);
                    e.Graphics.DrawString(s, fn, new SolidBrush(SystemColors.ControlText), r, sf);
                    e.DrawFocusRectangle();
                }
            }

            //base.OnDrawItem(e);
            //g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(this.Width - 20, 0, 20, this.Height));

        }

      


  


       

      

    }
}
