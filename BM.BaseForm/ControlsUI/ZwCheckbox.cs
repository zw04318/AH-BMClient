using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BM.BaseUI.ControlsUI
{
    [DefaultEvent("CheckedChanged")]
    public partial class ZwCheckbox : UserControl
    {
        public ZwCheckbox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += new EventHandler(MyCheckBox_Load);
            this.Paint += new PaintEventHandler(MyCheckBox_Paint);
            this.EnabledChanged += new EventHandler(MyCheckBox_EnabledChanged);
            this.MouseDown += new MouseEventHandler(MyCheckBox_MouseDown);
            this.MouseMove += new MouseEventHandler(MyCheckBox_MouseMove);
            this.MouseLeave += new EventHandler(MyCheckBox_MouseLeave);
            this.MouseUp += new MouseEventHandler(MyCheckBox_MouseUp);
            Value = "需要显示的文本";
        }

        bool isDraw = false; //是否画完字符。
        bool isCheck = false;
        Color CheckBackColor = Color.Gainsboro;
        #region 定义一个选中更改事件
        public delegate void CheckedHandle(object sender, EventArgs e);
        public event CheckedHandle CheckedChanged;
        #endregion
        [Category("设置"), Description("需要显示的文本")]
        public string Value
        {
            get { return this.Text; }
            set
            {
                this.Text = value;
                isDraw = false;
                this.Invalidate(new Rectangle(0, 0, this.Width, this.Height));
            }
        }

        private Color _CheckColor = Color.FromArgb(7, 174, 185);
        [Category("设置"), Description("选项框的颜色")]
        public Color CheckColor
        {
            get { return this._CheckColor; }
            set
            {
                this._CheckColor = value;
                this.Invalidate(new Rectangle(0, 0, MySize + jg, this.Height));
            }
        }

        private Color _ActiveColor = Color.FromArgb(7, 174, 185);
        [Category("设置"), Description("当鼠标移到选项框时的颜色")]
        public Color ActiveColor
        {
            get { return this._ActiveColor; }
            set
            {
                this._ActiveColor = value;
            }
        }

        private Color _DefaultColor = Color.FromArgb(7, 174, 185);
        [Category("设置"), Description("选项框的默认颜色")]
        private Color DefaultColor
        {
            get { return this._DefaultColor; }
            set
            {
                this._DefaultColor = value;
            }
        }

        private bool _Checked = false;
        [Category("设置"), Description("表示是否选中")]
        public bool Checked
        {
            get { return this._Checked; }
            set
            {
                this._Checked = value;
                this.Invalidate();
                if (CheckedChanged != null)
                    CheckedChanged(this, new EventArgs());
            }
        }

        private bool _isAvtice = false;
        [Category("设置"), Description("是否启用焦点变换")]
        public bool isAvtice
        {
            get { return this._isAvtice; }
            set
            {
                this._isAvtice = value;
            }
        }

        int MySize = 15;
        int jg = 4;
        void MyCheckBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SizeF DSize = g.MeasureString("√", new Font(new FontFamily("宋体"), 20));
            this.Height = (int)DSize.Height;
            Rectangle Outrect = new Rectangle(0, this.Height / 2 - MySize/2, MySize, MySize);
            //Rectangle Inrect = new Rectangle(1, this.Height / 2 - 6 + 1, 10, 10);
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(Outrect);
            g.DrawPath(new Pen(this.Enabled ? CheckColor : Color.Silver), path);
            g.FillPath(new SolidBrush(CheckBackColor), path);
            //画字(Text)，如果已经画过就不再画了。
            if (!isDraw)
            {
                SizeF thisSize = g.MeasureString(this.Text, this.Font);
                thisSize.Width += MySize + jg;
                this.Width = (int)thisSize.Width;
                g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new PointF(MySize + jg, this.Height / 2 - thisSize.Height / 2 + 1));
            }
            //画对钩
            if (Checked)
            {
                g.DrawString("√", new Font(new FontFamily("宋体"), 20), new SolidBrush(this.Enabled ? CheckColor : Color.Silver), new PointF(MySize/2 - DSize.Width / 2, this.Height / 2 - Height / 2 - 1));
            }
        }
        private void MyCheckBox_MouseLeave(object sender, EventArgs e)
        {
            //鼠标离开时恢复默认状态
            CheckColor = DefaultColor;
            this.Cursor = Cursors.Default;
            this.Invalidate(new Rectangle(0, 0, MySize + jg, this.Height));
        }

        private void MyCheckBox_MouseMove(object sender, MouseEventArgs e)
        {
            //isDraw = true;
            if (!isAvtice)
            { return; }
            CheckColor = ActiveColor;
            this.Invalidate(new Rectangle(0, 0, MySize + jg, this.Height));
        }

        private void MyCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标点击切换选中状态
            Checked = !Checked;
            isDraw = false;
            isCheck = !Checked;
            CheckBackColor = Color.GhostWhite;
            this.Invalidate();
        }

        void MyCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            CheckBackColor = Checked? SystemColors.HighlightText:Color.Gainsboro ;
            this.Invalidate(new Rectangle(0, 0, MySize + jg, this.Height));
        }

        private void MyCheckBox_Load(object sender, EventArgs e)
        {
            DefaultColor = CheckColor;
            this.Invalidate();
        }

        private void MyCheckBox_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.Enabled)
            {
                isDraw = false;
                this.Invalidate();
            }
        }
    }
}
