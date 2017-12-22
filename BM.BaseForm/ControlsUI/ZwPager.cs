﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.BaseUI.ControlsUI
{
    /// <summary>
    /// 申明委托
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public delegate int EventPagingHandler(EventPagingArg e);
    /// <summary>
    /// 分页控件呈现
    /// </summary>
    public partial class ZwPager : UserControl
    {
        public ZwPager()
        {
            InitializeComponent();
        }
        public event EventPagingHandler EventPaging;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        private int _pageSize = 20;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value;
                GetPageCount();
            }
        }

        private int _nMax = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int NMax
        {
            get { return _nMax; }
            set
            {
                _nMax = value;
                GetPageCount();
            }
        }

        private int _pageCount = 0;
        /// <summary>
        /// 页数=总记录数/每页显示记录数
        /// </summary>
        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        private int _pageCurrent = 0;
        /// <summary>
        /// 当前页号
        /// </summary>
        public int PageCurrent
        {
            get { return _pageCurrent; }
            set { _pageCurrent = value; }
        }

        public BindingNavigator ToolBar
        {
            get { return this.bindingNavigator; }
        }

        private void GetPageCount()
        {
            if (this.NMax > 0)
            {
                this.PageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.NMax) / Convert.ToDouble(this.PageSize)));
            }
            else
            {
                this.PageCount = 0;
            }
        }

        /// <summary>
        /// 翻页控件数据绑定的方法
        /// </summary>
        public void Bind()
        {
            if (this.EventPaging != null)
            {
                this.NMax = this.EventPaging(new EventPagingArg(this.PageCurrent));
            }

            if (this.PageCurrent > this.PageCount)
            {
                this.PageCurrent = this.PageCount;
            }
            if (this.PageCount == 1)
            {
                this.PageCurrent = 1;
            }
            lblPageCount.Text = this.PageCount.ToString();
            this.lblMaxPage.Text = "共" + this.NMax.ToString() + "条记录";
            this.txtCurrentPage.Text = this.PageCurrent.ToString();

            if (this.PageCurrent == 1)
            {
                this.btnPrev.Enabled = false;
                this.btnFirst.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnFirst.Enabled = true;
            }

            if (this.PageCurrent == this.PageCount)
            {
                this.btnLast.Enabled = false;
                this.btnNext.Enabled = false;
            }
            else
            {
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }

            if (this.NMax == 0)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            PageCurrent = 1;
            this.Bind();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            PageCurrent = PageCount;
            this.Bind();
        }

        private void txtCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Bind();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

    }
    /// <summary>
    /// 自定义事件数据基类
    /// </summary>
    public class EventPagingArg : EventArgs
    {
        private int _intPageIndex;
        public EventPagingArg(int PageIndex)
        {
            _intPageIndex = PageIndex;
        }
    }
   
}
