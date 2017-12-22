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
    public partial class ZwDataGridView : DataGridView
    {
        public ZwDataGridView()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnCreateControl()
        {
            this.EnableHeadersVisualStyles = false;
            
            this.ColumnHeadersHeight = 29;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HighlightText;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(7, 174, 185);
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(7, 174, 185);
            this.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.ButtonHighlight;
            this.ColumnHeadersDefaultCellStyle.Font = _font;

            this.RowHeadersDefaultCellStyle.Font = _font;
            this.RowHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RowHeadersDefaultCellStyle.BackColor = SystemColors.HighlightText;
            this.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(7, 174, 185); ;
            this.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0x09, 0xDC, 0xEB);
            this.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.ButtonHighlight;
            this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DefaultCellStyle.Font = _font;
            this.DefaultCellStyle.BackColor = SystemColors.HighlightText;
            this.DefaultCellStyle.ForeColor = SystemColors.GrayText;
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0x09, 0xDC, 0xEB);
            this.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonHighlight;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridColor = Color.FromArgb(7, 174, 185);
            this.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllowUserToOrderColumns = true;
            this.AutoGenerateColumns = true;

            base.OnCreateControl();

            _hScrollBarEx = new ZwHScrollBar();
            _vScrollBarEx = new ZwVScrollBar();
            this.Controls.Add(_hScrollBarEx);
            this.Controls.Add(_vScrollBarEx);
            base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.HorizontalScrollBar.VisibleChanged += new EventHandler(ScrollBar_VisibleChanged);
            this.VerticalScrollBar.VisibleChanged += new EventHandler(ScrollBar_VisibleChanged);
            this.SizeChanged += new EventHandler(ScrollBar_VisibleChanged);
            this._vScrollBarEx.ValueChanged += new EventHandler(VScrollBarEx_ValueChanged);
            this._hScrollBarEx.ValueChanged += new EventHandler(HScrollBarEx_ValueChanged);
            this.Scroll += new ScrollEventHandler(DataGridViewEx_Scroll);
            this.ColumnHeadersHeightChanged += new EventHandler(ScrollBar_VisibleChanged);
            this.ColumnWidthChanged += new DataGridViewColumnEventHandler(ScrollBar_VisibleChanged);
            this.RowHeadersWidthChanged += new EventHandler(ScrollBar_VisibleChanged);
            this.RowHeightChanged += new DataGridViewRowEventHandler(ScrollBar_VisibleChanged);
            this.RowsAdded += new DataGridViewRowsAddedEventHandler(ScrollBar_VisibleChanged);
            this.RowsRemoved += new DataGridViewRowsRemovedEventHandler(ScrollBar_VisibleChanged);
            this.ColumnAdded += new DataGridViewColumnEventHandler(ScrollBar_VisibleChanged);
            this.ColumnRemoved += new DataGridViewColumnEventHandler(ScrollBar_VisibleChanged);
            this.DataSourceChanged += new EventHandler(ScrollBar_VisibleChanged);
            SetScrollBarEx();
        }

        #region scrollbar
        private int _displayRowCount = 0;
        private int _displayWidth = 0;
        private ZwHScrollBar _hScrollBarEx;
        private ZwVScrollBar _vScrollBarEx;
        private bool dgvScroll = false;
        private void VScrollBarEx_ValueChanged(object sender, EventArgs e)
        {
            if (!this.dgvScroll)
            {
                this.FirstDisplayedScrollingRowIndex = _vScrollBarEx.Value;
                
                Application.DoEvents();
            }
        }
 
        private void HScrollBarEx_ValueChanged(object sender, EventArgs e)
        {
            if (!this.dgvScroll)
            {
                this.HorizontalScrollingOffset = _hScrollBarEx.Value;
                GetDisplayWidth();
                Application.DoEvents();
            }
        }
 
        private void DataGridViewEx_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgvScroll = true;
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                _vScrollBarEx.Value = this.FirstDisplayedScrollingRowIndex;
            }
            else
            {
                _hScrollBarEx.Value = this.HorizontalScrollingOffset;
            }
            this.dgvScroll = false;
        }
 
        private void ScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            SetScrollBarEx();
        }
 
        private void SetScrollBarEx()
        {
            if (this.VerticalScrollBar.Visible)
            {
                _vScrollBarEx.Visible = true;
                _vScrollBarEx.Location = new Point(this.DisplayRectangle.Width, 0);
                this.VerticalScrollBar.SendToBack();
                _vScrollBarEx.Height = this.DisplayRectangle.Height;
 
                GetDisplayRowCount();
            }
            else
            {
                _vScrollBarEx.Visible = false;
            }
 
            if (this.HorizontalScrollBar.Visible)
            {
               _hScrollBarEx.Visible = true;
                _hScrollBarEx.Location = new Point(0, this.DisplayRectangle.Height);
                this.HorizontalScrollBar.SendToBack();
                _hScrollBarEx.Width = this.DisplayRectangle.Width ;
 
                GetDisplayWidth();
                _hScrollBarEx.Value = this.HorizontalScrollingOffset;
            }
            else
            {
                _hScrollBarEx.Visible = false;
            }
        }
 
        public int GetDisplayWidth()
        {
            int width = 0;
            for (int i = 0; i < this.Columns.Count; i++)
            {
                width += this.Columns[i].Width;
            }
            _displayWidth = width;
            this._hScrollBarEx.Maximum = width;
            this._hScrollBarEx.LargeChange = _hScrollBarEx.Maximum / _hScrollBarEx.Width + this.DisplayRectangle.Width - this.RowHeadersWidth;
            return width;
        }
 
        public int GetDisplayRowCount()
        {
            int j = 0;
           int height = 0;
            int i = this.FirstDisplayedScrollingRowIndex;
            if (i < 0)
            {
                i = 0;
            }
            for (; i < this.Rows.Count; i++)
            {
                height += this.Rows[i].Height;
                if (height < this.DisplayRectangle.Height - this.ColumnHeadersHeight)
                {
                    j++;
                }
                else
                {
                    break;
                }
 
            }
            j = this.Rows.Count - j;
            if (j < 0)
            {
                j = 0;
            }
            if (_displayRowCount != j)
            {
                _displayRowCount = j;
                _vScrollBarEx.Maximum = j + _vScrollBarEx.Minimum + _vScrollBarEx.LargeChange - 1;
                if (this.FirstDisplayedScrollingRowIndex < 0)
                {
                    _vScrollBarEx.Value = 0;
                }
                else if (this.FirstDisplayedScrollingRowIndex > _vScrollBarEx.Maximum)
                {
                    _vScrollBarEx.Value = _vScrollBarEx.Maximum;
                }
                else
                {
                    _vScrollBarEx.Value = this.FirstDisplayedScrollingRowIndex;
                }
            }
            return j;
        }
   
        #endregion

        private Font _font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        [Category("bmDataGridView")]
        [Description("类型检查")]
        public Font MyFont
        {
            get { return _font; }
            set
            {
                _font = value;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(7, 174, 185)), new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        //移到单元格时的颜色
        protected override void OnCellMouseMove(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseMove(e);
            try
            {
                Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Control;
                Rows[e.RowIndex].DefaultCellStyle.ForeColor = SystemColors.GrayText;

            }
            catch { }
        }

        //进入单元格时保存当前的颜色
        Color defaultcolor;
        Color forColor;
        protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
        {
            base.OnCellMouseEnter(e);
            try
            {
                defaultcolor = Rows[e.RowIndex].DefaultCellStyle.BackColor;
                forColor = Rows[e.RowIndex].DefaultCellStyle.ForeColor;
            }
            catch { }
        }

        //离开时还原颜色
        protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
        {
            base.OnCellMouseLeave(e);
            try
            {
                Rows[e.RowIndex].DefaultCellStyle.BackColor = defaultcolor;
                Rows[e.RowIndex].DefaultCellStyle.ForeColor = forColor;
            }
            catch { }
        }

        //在生成列表时添加一个行号，颜色默认为红色
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            //自动编号与数据库无关
            if (this.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, RowHeadersWidth - 4, e.RowBounds.Height);
            Color fcolor = this.Rows[e.RowIndex].Selected ? RowHeadersDefaultCellStyle.SelectionForeColor : RowHeadersDefaultCellStyle.ForeColor;
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), RowHeadersDefaultCellStyle.Font, rectangle,
            fcolor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

    }
}
