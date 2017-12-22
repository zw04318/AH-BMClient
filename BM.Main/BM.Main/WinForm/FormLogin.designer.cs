namespace BM.Main
{
    partial class FormLogin
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
            this.buttonLabelReg = new BM.BaseUI.ControlsUI.ButtonLabel();
            this.buttonLabelForget = new BM.BaseUI.ControlsUI.ButtonLabel();
            this.tb_Phone = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.tb_Pwd = new BM.BaseUI.ControlsUI.CheckTextBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tb_Pwd);
            this.panelMain.Controls.Add(this.tb_Phone);
            this.panelMain.Controls.Add(this.buttonLabelForget);
            this.panelMain.Controls.Add(this.buttonLabelReg);
            this.panelMain.Controls.Add(this.bmLabel2);
            this.panelMain.Controls.Add(this.bmLabel1);
            this.panelMain.Size = new System.Drawing.Size(381, 172);
            // 
            // bmLabel1
            // 
            this.bmLabel1.AutoSize = true;
            this.bmLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmLabel1.Location = new System.Drawing.Point(59, 56);
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
            this.bmLabel2.Location = new System.Drawing.Point(59, 102);
            this.bmLabel2.Name = "bmLabel2";
            this.bmLabel2.Size = new System.Drawing.Size(78, 21);
            this.bmLabel2.TabIndex = 2;
            this.bmLabel2.Text = "登陆密码:";
            // 
            // buttonLabelReg
            // 
            this.buttonLabelReg.AutoSize = true;
            this.buttonLabelReg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLabelReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLabelReg.Location = new System.Drawing.Point(147, 146);
            this.buttonLabelReg.Name = "buttonLabelReg";
            this.buttonLabelReg.Size = new System.Drawing.Size(42, 21);
            this.buttonLabelReg.TabIndex = 3;
            this.buttonLabelReg.Text = "注册";
            this.buttonLabelReg.Click += new System.EventHandler(this.buttonLabelReg_Click);
            // 
            // buttonLabelForget
            // 
            this.buttonLabelForget.AutoSize = true;
            this.buttonLabelForget.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLabelForget.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLabelForget.Location = new System.Drawing.Point(214, 146);
            this.buttonLabelForget.Name = "buttonLabelForget";
            this.buttonLabelForget.Size = new System.Drawing.Size(74, 21);
            this.buttonLabelForget.TabIndex = 4;
            this.buttonLabelForget.Text = "忘记密码";
            this.buttonLabelForget.Click += new System.EventHandler(this.buttonLabelForget_Click);
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.Color.Transparent;
            this.tb_Phone.CanBeNull = false;
            this.tb_Phone.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Phone.Location = new System.Drawing.Point(151, 55);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(164, 29);
            this.tb_Phone.TabIndex = 5;
            this.tb_Phone.Value = "";
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.tb_Pwd.CanBeNull = false;
            this.tb_Pwd.checkType = BM.BaseUI.ControlsUI.CheckType.String;
            this.tb_Pwd.Location = new System.Drawing.Point(151, 101);
            this.tb_Pwd.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.Size = new System.Drawing.Size(164, 29);
            this.tb_Pwd.TabIndex = 6;
            this.tb_Pwd.Value = "";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 322);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.TitleInfo = "登陆";
            this.BtOk += new System.EventHandler(this.FormLogin_BtOk);
            this.BtCancel += new System.EventHandler(this.FormLogin_BtCancel);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseUI.ControlsUI.ZwLabel bmLabel1;
        private BaseUI.ControlsUI.ZwLabel bmLabel2;
        private BaseUI.ControlsUI.ButtonLabel buttonLabelReg;
        private BaseUI.ControlsUI.ButtonLabel buttonLabelForget;
        private BaseUI.ControlsUI.CheckTextBox tb_Pwd;
        private BaseUI.ControlsUI.CheckTextBox tb_Phone;
    }
}