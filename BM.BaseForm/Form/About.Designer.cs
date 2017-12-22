namespace BM.BaseUI
{
    partial class About
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
            this.labelBottom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_web = new System.Windows.Forms.RadioButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelMain = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_contract = new System.Windows.Forms.RadioButton();
            this.rb_bbs = new System.Windows.Forms.RadioButton();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBottom
            // 
            this.labelBottom.AutoSize = true;
            this.labelBottom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBottom.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBottom.Location = new System.Drawing.Point(160, 423);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(113, 12);
            this.labelBottom.TabIndex = 130;
            this.labelBottom.Text = "版权所有 © ZhangUi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(410, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(238, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 128;
            this.label2.Text = "|";
            // 
            // rb_web
            // 
            this.rb_web.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_web.BackColor = System.Drawing.Color.Transparent;
            this.rb_web.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_web.FlatAppearance.BorderSize = 0;
            this.rb_web.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rb_web.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rb_web.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rb_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_web.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_web.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rb_web.Image = global::BM.BaseUI.Properties.Resources.WebSiteAbout_normal;
            this.rb_web.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_web.Location = new System.Drawing.Point(107, 329);
            this.rb_web.Name = "rb_web";
            this.rb_web.Size = new System.Drawing.Size(122, 40);
            this.rb_web.TabIndex = 125;
            this.rb_web.Text = "官方网站";
            this.rb_web.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_web.UseVisualStyleBackColor = false;
            this.rb_web.Click += new System.EventHandler(this.rb_web_Click);
            this.rb_web.MouseEnter += new System.EventHandler(this.rb_web_MouseEnter);
            this.rb_web.MouseLeave += new System.EventHandler(this.rb_web_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::BM.BaseUI.Properties.Resources.About_BackgroundImage;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMain.Controls.Add(this.labelMain);
            this.panelMain.Controls.Add(this.pictureBox_logo);
            this.panelMain.Controls.Add(this.label_close);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(660, 300);
            this.panelMain.TabIndex = 124;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneMain_MouseDown);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("幼圆", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMain.Location = new System.Drawing.Point(169, 155);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(141, 35);
            this.labelMain.TabIndex = 106;
            this.labelMain.Text = "ZhangUi";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_logo.Location = new System.Drawing.Point(231, 75);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(168, 60);
            this.pictureBox_logo.TabIndex = 105;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Image = global::BM.BaseUI.Properties.Resources.close_normal;
            this.label_close.Location = new System.Drawing.Point(632, 4);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(25, 23);
            this.label_close.TabIndex = 104;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_close_MouseDown);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "关于";
            // 
            // rb_contract
            // 
            this.rb_contract.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_contract.BackColor = System.Drawing.Color.Transparent;
            this.rb_contract.Checked = true;
            this.rb_contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_contract.FlatAppearance.BorderSize = 0;
            this.rb_contract.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rb_contract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rb_contract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rb_contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_contract.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_contract.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rb_contract.Image = global::BM.BaseUI.Properties.Resources.ContractMeAbout_normal;
            this.rb_contract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_contract.Location = new System.Drawing.Point(447, 329);
            this.rb_contract.Name = "rb_contract";
            this.rb_contract.Size = new System.Drawing.Size(122, 40);
            this.rb_contract.TabIndex = 127;
            this.rb_contract.TabStop = true;
            this.rb_contract.Text = "联系我们";
            this.rb_contract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_contract.UseVisualStyleBackColor = false;
            this.rb_contract.Click += new System.EventHandler(this.rb_web_Click);
            this.rb_contract.MouseEnter += new System.EventHandler(this.rb_web_MouseEnter);
            this.rb_contract.MouseLeave += new System.EventHandler(this.rb_web_MouseLeave);
            // 
            // rb_bbs
            // 
            this.rb_bbs.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_bbs.BackColor = System.Drawing.Color.Transparent;
            this.rb_bbs.Checked = true;
            this.rb_bbs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_bbs.FlatAppearance.BorderSize = 0;
            this.rb_bbs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rb_bbs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rb_bbs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rb_bbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_bbs.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_bbs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rb_bbs.Image = global::BM.BaseUI.Properties.Resources.WebSiteBBSAbout_normal;
            this.rb_bbs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_bbs.Location = new System.Drawing.Point(277, 329);
            this.rb_bbs.Name = "rb_bbs";
            this.rb_bbs.Size = new System.Drawing.Size(122, 40);
            this.rb_bbs.TabIndex = 126;
            this.rb_bbs.TabStop = true;
            this.rb_bbs.Text = "官方论坛";
            this.rb_bbs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_bbs.UseVisualStyleBackColor = false;
            this.rb_bbs.Click += new System.EventHandler(this.rb_web_Click);
            this.rb_bbs.MouseEnter += new System.EventHandler(this.rb_web_MouseEnter);
            this.rb_bbs.MouseLeave += new System.EventHandler(this.rb_web_MouseLeave);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(660, 453);
            this.Controls.Add(this.rb_web);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelBottom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_contract);
            this.Controls.Add(this.rb_bbs);
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_web;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_contract;
        private System.Windows.Forms.RadioButton rb_bbs;
    }
}