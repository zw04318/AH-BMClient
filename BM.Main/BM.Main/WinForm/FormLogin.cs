using BM.BaseUI;
using BM.BaseUI.ControlsUI;
using BM.BLL;
using BM.Model;
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
    public partial class FormLogin : FormList
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLabelReg_Click(object sender, EventArgs e)
        {
            FormRegister fr = new FormRegister();
            fr.ShowDialog();
        }

        private void FormLogin_BtOk(object sender, EventArgs e)
        {
            AHUsers usr = new AHUsers()
            {
                 PhoneNum = tb_Phone.Value.ToString(),
                 Password = tb_Pwd.Value.ToString()
            };

            string msg = string.Empty;

            if(!UserBLL.Instance.Login(usr, ref msg))
            {
                ZwMessageBox.ShowMsg(msg);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void FormLogin_BtCancel(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void buttonLabelForget_Click(object sender, EventArgs e)
        {
            FormForget ff = new FormForget();
            ff.ShowDialog();
        }
    }
}
