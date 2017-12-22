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
    public partial class FormForget : FormList
    {
        public FormForget()
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
                 Password = tb_Code.Value.ToString()
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

        private void bl_GetCode_Click(object sender, EventArgs e)
        {
            if (!bl_GetCode.Enabled)
            {
                return;
            }
            UserBLL.Instance.GetPhoneCode();
            Task.Factory.StartNew(delegate
            {
                try
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        bl_GetCode.Enabled = false;
                    }));

                    for (int i = 0; i < 30; i++)
                    {
                        this.Invoke(new EventHandler(delegate
                        {
                            bl_GetCode.Text = "请等待" + (30 - i).ToString() + "s";
                        }));

                        System.Threading.Thread.Sleep(1000);
                    }

                    this.Invoke(new EventHandler(delegate
                    {
                        bl_GetCode.Text = "获取验证码";
                        bl_GetCode.Enabled = true;
                    }));
                }
                catch
                {
                }
            });
        }
    }
}
