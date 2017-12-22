namespace BM.Main
{
    partial class FormForget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bmLabel1 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.bmLabel2 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.tb_Phone = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.tb_Code = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.tb_Pwd = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.bmLabel3 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.tb_RePwd = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.bmLabel4 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.bl_GetCode = new BM.BaseUI.ControlsUI.ButtonLabel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.bl_GetCode);
            this.panelMain.Controls.Add(this.tb_RePwd);
            this.panelMain.Controls.Add(this.bmLabel4);
            this.panelMain.Controls.Add(this.tb_Pwd);
            this.panelMain.Controls.Add(this.bmLabel3);
            this.panelMain.Controls.Add(this.tb_Code);
            this.panelMain.Controls.Add(this.tb_Phone);
            this.panelMain.Controls.Add(this.bmLabel2);
            this.panelMain.Controls.Add(this.bmLabel1);
            this.panelMain.Size = new System.Drawing.Size(412, 257);
            // 
            // bmLabel1
            // 
            this.bmLabel1.AutoSize = true;
            this.bmLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel1.Location = new System.Drawing.Point(74, 40);
            this.bmLabel1.Name = "bmLabel1";
            this.bmLabel1.Size = new System.Drawing.Size(78, 21);
            this.bmLabel1.TabIndex = 0;
            this.bmLabel1.Text = "登陆手机:";
            // 
            // bmLabel2
            // 
            this.bmLabel2.AutoSize = true;
            this.bmLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel2.Location = new System.Drawing.Point(74, 107);
            this.bmLabel2.Name = "bmLabel2";
            this.bmLabel2.Size = new System.Drawing.Size(62, 21);
            this.bmLabel2.TabIndex = 2;
            this.bmLabel2.Text = "验证码:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.Color.Transparent;
            this.tb_Phone.CanBeNull = false;
            this.tb_Phone.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Phone.Location = new System.Drawing.Point(166, 40);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(164, 29);
            this.tb_Phone.TabIndex = 5;
            this.tb_Phone.Value = "";
            // 
            // tb_Code
            // 
            this.tb_Code.BackColor = System.Drawing.Color.Transparent;
            this.tb_Code.CanBeNull = false;
            this.tb_Code.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Code.Location = new System.Drawing.Point(166, 107);
            this.tb_Code.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(164, 29);
            this.tb_Code.TabIndex = 6;
            this.tb_Code.Value = "";
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.tb_Pwd.CanBeNull = false;
            this.tb_Pwd.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Pwd.Location = new System.Drawing.Point(166, 155);
            this.tb_Pwd.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.Size = new System.Drawing.Size(164, 29);
            this.tb_Pwd.TabIndex = 8;
            this.tb_Pwd.Value = "";
            // 
            // bmLabel3
            // 
            this.bmLabel3.AutoSize = true;
            this.bmLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel3.Location = new System.Drawing.Point(74, 155);
            this.bmLabel3.Name = "bmLabel3";
            this.bmLabel3.Size = new System.Drawing.Size(78, 21);
            this.bmLabel3.TabIndex = 7;
            this.bmLabel3.Text = "设置密码:";
            // 
            // tb_RePwd
            // 
            this.tb_RePwd.BackColor = System.Drawing.Color.Transparent;
            this.tb_RePwd.CanBeNull = false;
            this.tb_RePwd.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_RePwd.Location = new System.Drawing.Point(166, 203);
            this.tb_RePwd.Margin = new System.Windows.Forms.Padding(0);
            this.tb_RePwd.Name = "tb_RePwd";
            this.tb_RePwd.Size = new System.Drawing.Size(164, 29);
            this.tb_RePwd.TabIndex = 10;
            this.tb_RePwd.Value = "";
            // 
            // bmLabel4
            // 
            this.bmLabel4.AutoSize = true;
            this.bmLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel4.Location = new System.Drawing.Point(74, 203);
            this.bmLabel4.Name = "bmLabel4";
            this.bmLabel4.Size = new System.Drawing.Size(78, 21);
            this.bmLabel4.TabIndex = 9;
            this.bmLabel4.Text = "重复密码:";
            // 
            // bl_GetCode
            // 
            this.bl_GetCode.AutoSize = true;
            this.bl_GetCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bl_GetCode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bl_GetCode.Location = new System.Drawing.Point(215, 77);
            this.bl_GetCode.Name = "bl_GetCode";
            this.bl_GetCode.Size = new System.Drawing.Size(90, 21);
            this.bl_GetCode.TabIndex = 11;
            this.bl_GetCode.Text = "获取验证码";
            this.bl_GetCode.Click += new System.EventHandler(this.bl_GetCode_Click);
            // 
            // FormForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 407);
            this.Name = "FormForget";
            this.Text = "FormLogin";
            this.TitleInfo = "忘记密码";
            this.BtOk += new System.EventHandler(this.FormLogin_BtOk);
            this.BtCancel += new System.EventHandler(this.FormLogin_BtCancel);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseUI.ControlsUI.ZwLabel bmLabel1;
        private BaseUI.ControlsUI.ZwLabel bmLabel2;
        private BaseUI.ControlsUI.CheckTextBox tb_Code;
        private BaseUI.ControlsUI.CheckTextBox tb_Phone;
        private BaseUI.ControlsUI.CheckTextBox tb_RePwd;
        private BaseUI.ControlsUI.ZwLabel bmLabel4;
        private BaseUI.ControlsUI.CheckTextBox tb_Pwd;
        private BaseUI.ControlsUI.ZwLabel bmLabel3;
        private BaseUI.ControlsUI.ButtonLabel bl_GetCode;
    }
}