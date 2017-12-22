using BM.BaseUI.Properties;
using BM.SkinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.BaseUI
{
    /// <summary>
    /// 消息
    /// </summary>
    public partial class ZwMessageBox : SkinMain
    {

        public ZwMessageBox()
        {
            InitializeComponent();
        }

        public ZwMessageBox(string content)
        {
            InitializeComponent();
            Content = content;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        public static void ShowMsg(string content)
        {
            ZwMessageBox mb = new ZwMessageBox(content);
            mb.ShowDialog();
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get { return label_context.Text; }
            set { label_context.Text = value; }
        }

        #region 属性
        [Category("MessageBox")]
        [Description("左上角标题")]
        public string TitleInfo
        {
            get { return label_title.Text; }
            set
            {
                label_title.Text = value;
            }
        }
        #endregion

        #region  ok or cancel

        /// <summary>
        /// Ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region close事件
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
    }
}
