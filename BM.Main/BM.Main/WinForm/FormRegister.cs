using BM.BaseUI;
using BM.BLL;
using BM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.Main
{
    public partial class FormRegister : FormList
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_BtCancel(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FormRegister_BtOk(object sender, EventArgs e)
        {
            if (tb_psw.Value.ToString() != tb_RePwd.Value.ToString())
            {
                ZwMessageBox.ShowMsg("两次密码输入不一致");
                return;
            }

            AHAgent agent = new AHAgent()
            {
                PhoneNum = tb_Phone.Value.ToString(),
                Password = tb_psw.Value.ToString(),
                Email = tb_Email.Value.ToString(),
                ShopName = tb_ShopName.ToString(),
                ReMarks = tb_Remark.ToString()
            };

            string msg = string.Empty;

            if (!UserBLL.Instance.RegisterShop(agent, ref msg))
            {
                ZwMessageBox.ShowMsg(msg);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

      
    }
}
