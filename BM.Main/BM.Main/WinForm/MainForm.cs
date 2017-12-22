using BM.BaseUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.Main
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_cms_about_EventHandler(object sender, EventArgs e)
        {
            BM.BaseUI.About about = new BaseUI.About();
            about.Show();
        }

        private void MainForm_cms_setting_EventHandler(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainBMbk mbm = new MainBMbk();
            mbm.TopLevel = false;
            mbm.Parent = this.panelMain;
            mbm.FormBorderStyle = FormBorderStyle.None;
            mbm.Dock = DockStyle.Fill;
            mbm.BackColor = SystemColors.HighlightText;
            mbm.Show();
        }
    }
}
