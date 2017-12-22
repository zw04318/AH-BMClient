namespace BM.Main
{
    partial class FormRegister
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
            this.tb_Phone = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.bmLabel2 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.tb_ShopName = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.tb_RePwd = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.bmLabel3 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.tb_psw = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.bmLabel4 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.tb_Email = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.bmLabel5 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.tb_Remark = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.bmLabel6 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tb_Remark);
            this.panelMain.Controls.Add(this.bmLabel6);
            this.panelMain.Controls.Add(this.tb_Email);
            this.panelMain.Controls.Add(this.bmLabel5);
            this.panelMain.Controls.Add(this.tb_RePwd);
            this.panelMain.Controls.Add(this.bmLabel3);
            this.panelMain.Controls.Add(this.tb_psw);
            this.panelMain.Controls.Add(this.bmLabel4);
            this.panelMain.Controls.Add(this.tb_ShopName);
            this.panelMain.Controls.Add(this.bmLabel2);
            this.panelMain.Controls.Add(this.tb_Phone);
            this.panelMain.Controls.Add(this.bmLabel1);
            this.panelMain.Size = new System.Drawing.Size(593, 334);
            // 
            // bmLabel1
            // 
            this.bmLabel1.AutoSize = true;
            this.bmLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel1.Location = new System.Drawing.Point(85, 27);
            this.bmLabel1.Name = "bmLabel1";
            this.bmLabel1.Size = new System.Drawing.Size(78, 21);
            this.bmLabel1.TabIndex = 0;
            this.bmLabel1.Text = "电话号码:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.Color.Transparent;
            this.tb_Phone.CanBeNull = false;
            this.tb_Phone.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Phone.Location = new System.Drawing.Point(182, 27);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(304, 29);
            this.tb_Phone.TabIndex = 1;
            this.tb_Phone.Value = "";
            // 
            // bmLabel2
            // 
            this.bmLabel2.AutoSize = true;
            this.bmLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel2.Location = new System.Drawing.Point(85, 80);
            this.bmLabel2.Name = "bmLabel2";
            this.bmLabel2.Size = new System.Drawing.Size(62, 21);
            this.bmLabel2.TabIndex = 3;
            this.bmLabel2.Text = "公司名:";
            // 
            // tb_ShopName
            // 
            this.tb_ShopName.BackColor = System.Drawing.Color.Transparent;
            this.tb_ShopName.CanBeNull = false;
            this.tb_ShopName.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_ShopName.Location = new System.Drawing.Point(182, 80);
            this.tb_ShopName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ShopName.Name = "tb_ShopName";
            this.tb_ShopName.Size = new System.Drawing.Size(304, 29);
            this.tb_ShopName.TabIndex = 4;
            this.tb_ShopName.Value = "";
            // 
            // tb_RePwd
            // 
            this.tb_RePwd.BackColor = System.Drawing.Color.Transparent;
            this.tb_RePwd.CanBeNull = false;
            this.tb_RePwd.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_RePwd.Location = new System.Drawing.Point(182, 186);
            this.tb_RePwd.Margin = new System.Windows.Forms.Padding(0);
            this.tb_RePwd.Name = "tb_RePwd";
            this.tb_RePwd.Size = new System.Drawing.Size(304, 29);
            this.tb_RePwd.TabIndex = 8;
            this.tb_RePwd.Value = "";
            // 
            // bmLabel3
            // 
            this.bmLabel3.AutoSize = true;
            this.bmLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel3.Location = new System.Drawing.Point(85, 186);
            this.bmLabel3.Name = "bmLabel3";
            this.bmLabel3.Size = new System.Drawing.Size(78, 21);
            this.bmLabel3.TabIndex = 7;
            this.bmLabel3.Text = "重复密码:";
            // 
            // tb_psw
            // 
            this.tb_psw.BackColor = System.Drawing.Color.Transparent;
            this.tb_psw.CanBeNull = false;
            this.tb_psw.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_psw.Location = new System.Drawing.Point(182, 133);
            this.tb_psw.Margin = new System.Windows.Forms.Padding(0);
            this.tb_psw.Name = "tb_psw";
            this.tb_psw.Size = new System.Drawing.Size(304, 29);
            this.tb_psw.TabIndex = 6;
            this.tb_psw.Value = "";
            // 
            // bmLabel4
            // 
            this.bmLabel4.AutoSize = true;
            this.bmLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel4.Location = new System.Drawing.Point(85, 133);
            this.bmLabel4.Name = "bmLabel4";
            this.bmLabel4.Size = new System.Drawing.Size(46, 21);
            this.bmLabel4.TabIndex = 5;
            this.bmLabel4.Text = "密码:";
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.Transparent;
            this.tb_Email.CanBeNull = true;
            this.tb_Email.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Email.Location = new System.Drawing.Point(182, 239);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(280, 29);
            this.tb_Email.TabIndex = 10;
            this.tb_Email.Value = "";
            // 
            // bmLabel5
            // 
            this.bmLabel5.AutoSize = true;
            this.bmLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel5.Location = new System.Drawing.Point(85, 239);
            this.bmLabel5.Name = "bmLabel5";
            this.bmLabel5.Size = new System.Drawing.Size(46, 21);
            this.bmLabel5.TabIndex = 9;
            this.bmLabel5.Text = "邮箱:";
            // 
            // tb_Remark
            // 
            this.tb_Remark.BackColor = System.Drawing.Color.Transparent;
            this.tb_Remark.CanBeNull = true;
            this.tb_Remark.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Remark.Location = new System.Drawing.Point(182, 292);
            this.tb_Remark.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Remark.Name = "tb_Remark";
            this.tb_Remark.Size = new System.Drawing.Size(280, 29);
            this.tb_Remark.TabIndex = 12;
            this.tb_Remark.Value = "";
            // 
            // bmLabel6
            // 
            this.bmLabel6.AutoSize = true;
            this.bmLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel6.Location = new System.Drawing.Point(85, 292);
            this.bmLabel6.Name = "bmLabel6";
            this.bmLabel6.Size = new System.Drawing.Size(46, 21);
            this.bmLabel6.TabIndex = 11;
            this.bmLabel6.Text = "备注:";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 484);
            this.Name = "FormRegister";
            this.Text = "Form1";
            this.TitleInfo = "注册公司";
            this.BtOk += new System.EventHandler(this.FormRegister_BtOk);
            this.BtCancel += new System.EventHandler(this.FormRegister_BtCancel);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseUI.ControlsUI.ZwLabel bmLabel1;
        private BaseUI.ControlsUI.CheckTextBox tb_Phone;
        private BaseUI.ControlsUI.ZwLabel bmLabel2;
        private BaseUI.ControlsUI.CheckTextBox tb_ShopName;
        private BaseUI.ControlsUI.CheckTextBox tb_Email;
        private BaseUI.ControlsUI.ZwLabel bmLabel5;
        private BaseUI.ControlsUI.CheckTextBox tb_RePwd;
        private BaseUI.ControlsUI.ZwLabel bmLabel3;
        private BaseUI.ControlsUI.CheckTextBox tb_psw;
        private BaseUI.ControlsUI.ZwLabel bmLabel4;
        private BaseUI.ControlsUI.CheckTextBox tb_Remark;
        private BaseUI.ControlsUI.ZwLabel bmLabel6;
    }
}