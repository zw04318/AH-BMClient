namespace BM.BaseUI
{
    partial class BaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_windowstools = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_menu = new System.Windows.Forms.Label();
            this.cms_tools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_item_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_item_update = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_item_web = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_item_question = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_item_about = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_windowstools.SuspendLayout();
            this.cms_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.Control;
            this.panelBottom.Controls.Add(this.labelRight);
            this.panelBottom.Controls.Add(this.labelLeft);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 668);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(999, 32);
            this.panelBottom.TabIndex = 2;
            // 
            // labelRight
            // 
            this.labelRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelRight.Location = new System.Drawing.Point(853, 8);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(124, 17);
            this.labelRight.TabIndex = 1;
            this.labelRight.Text = "版权所有 © 翻版必究";
            // 
            // labelLeft
            // 
            this.labelLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLeft.AutoSize = true;
            this.labelLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLeft.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelLeft.Location = new System.Drawing.Point(28, 8);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(97, 17);
            this.labelLeft.TabIndex = 0;
            this.labelLeft.Text = "ZhangUi 1.0.0.1";
            // 
            // panel_top
            // 
            this.panel_top.BackgroundImage = global::BM.BaseUI.Properties.Resources.panel_top_BackgroundImage;
            this.panel_top.Controls.Add(this.pictureBox_logo);
            this.panel_top.Controls.Add(this.panel_windowstools);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(999, 81);
            this.panel_top.TabIndex = 3;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_logo.Location = new System.Drawing.Point(10, 11);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(162, 55);
            this.pictureBox_logo.TabIndex = 101;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_windowstools
            // 
            this.panel_windowstools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_windowstools.BackColor = System.Drawing.Color.Transparent;
            this.panel_windowstools.Controls.Add(this.label_close);
            this.panel_windowstools.Controls.Add(this.label_max);
            this.panel_windowstools.Controls.Add(this.label_min);
            this.panel_windowstools.Controls.Add(this.label_menu);
            this.panel_windowstools.Location = new System.Drawing.Point(866, 3);
            this.panel_windowstools.Name = "panel_windowstools";
            this.panel_windowstools.Size = new System.Drawing.Size(132, 39);
            this.panel_windowstools.TabIndex = 100;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Image = global::BM.BaseUI.Properties.Resources.close_normal;
            this.label_close.Location = new System.Drawing.Point(102, 7);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(25, 23);
            this.label_close.TabIndex = 103;
            this.label_close.Click += new System.EventHandler(this.label_windowstool_Click);
            this.label_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_windowstool_MouseDown);
            this.label_close.MouseEnter += new System.EventHandler(this.label_windowstool_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_windowstool_MouseLeave);
            // 
            // label_max
            // 
            this.label_max.BackColor = System.Drawing.Color.Transparent;
            this.label_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_max.Image = global::BM.BaseUI.Properties.Resources.max_normal;
            this.label_max.Location = new System.Drawing.Point(71, 7);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(25, 23);
            this.label_max.TabIndex = 102;
            this.label_max.Click += new System.EventHandler(this.label_windowstool_Click);
            this.label_max.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_windowstool_MouseDown);
            this.label_max.MouseEnter += new System.EventHandler(this.label_windowstool_MouseEnter);
            this.label_max.MouseLeave += new System.EventHandler(this.label_windowstool_MouseLeave);
            // 
            // label_min
            // 
            this.label_min.BackColor = System.Drawing.Color.Transparent;
            this.label_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_min.Image = global::BM.BaseUI.Properties.Resources.min_normal;
            this.label_min.Location = new System.Drawing.Point(40, 7);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(25, 23);
            this.label_min.TabIndex = 101;
            this.label_min.Click += new System.EventHandler(this.label_windowstool_Click);
            this.label_min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_windowstool_MouseDown);
            this.label_min.MouseEnter += new System.EventHandler(this.label_windowstool_MouseEnter);
            this.label_min.MouseLeave += new System.EventHandler(this.label_windowstool_MouseLeave);
            // 
            // label_menu
            // 
            this.label_menu.BackColor = System.Drawing.Color.Transparent;
            this.label_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_menu.Image = global::BM.BaseUI.Properties.Resources.label_menu_Image;
            this.label_menu.Location = new System.Drawing.Point(9, 7);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(25, 23);
            this.label_menu.TabIndex = 100;
            this.label_menu.Click += new System.EventHandler(this.label_windowstool_Click);
            this.label_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_windowstool_MouseDown);
            this.label_menu.MouseEnter += new System.EventHandler(this.label_windowstool_MouseEnter);
            this.label_menu.MouseLeave += new System.EventHandler(this.label_windowstool_MouseLeave);
            // 
            // cms_tools
            // 
            this.cms_tools.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cms_tools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cms_tools.BackgroundImage")));
            this.cms_tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cms_tools.DropShadowEnabled = false;
            this.cms_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_item_setting,
            this.cms_item_update,
            this.cms_item_web,
            this.cms_item_question,
            this.cms_item_about});
            this.cms_tools.Name = "cms_tools";
            this.cms_tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cms_tools.Size = new System.Drawing.Size(150, 143);
            // 
            // cms_item_setting
            // 
            this.cms_item_setting.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms_item_setting.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cms_item_setting.Image = global::BM.BaseUI.Properties.Resources.menu_set;
            this.cms_item_setting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cms_item_setting.Name = "cms_item_setting";
            this.cms_item_setting.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cms_item_setting.Size = new System.Drawing.Size(149, 27);
            this.cms_item_setting.Text = "系统设置";
            this.cms_item_setting.Click += new System.EventHandler(this.cms_item_Click);
            this.cms_item_setting.MouseEnter += new System.EventHandler(this.cms_item_MouseEnter);
            this.cms_item_setting.MouseLeave += new System.EventHandler(this.cms_item_MouseLeave);
            // 
            // cms_item_update
            // 
            this.cms_item_update.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms_item_update.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cms_item_update.Image = global::BM.BaseUI.Properties.Resources.menu_update;
            this.cms_item_update.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cms_item_update.Name = "cms_item_update";
            this.cms_item_update.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.cms_item_update.Size = new System.Drawing.Size(149, 28);
            this.cms_item_update.Text = "检查更新";
            this.cms_item_update.Click += new System.EventHandler(this.cms_item_Click);
            this.cms_item_update.MouseEnter += new System.EventHandler(this.cms_item_MouseEnter);
            this.cms_item_update.MouseLeave += new System.EventHandler(this.cms_item_MouseLeave);
            // 
            // cms_item_web
            // 
            this.cms_item_web.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms_item_web.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cms_item_web.Image = global::BM.BaseUI.Properties.Resources.menu_bbs;
            this.cms_item_web.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cms_item_web.Name = "cms_item_web";
            this.cms_item_web.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.cms_item_web.Size = new System.Drawing.Size(149, 28);
            this.cms_item_web.Text = "官方网站";
            this.cms_item_web.Click += new System.EventHandler(this.cms_item_Click);
            this.cms_item_web.MouseEnter += new System.EventHandler(this.cms_item_MouseEnter);
            this.cms_item_web.MouseLeave += new System.EventHandler(this.cms_item_MouseLeave);
            // 
            // cms_item_question
            // 
            this.cms_item_question.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms_item_question.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cms_item_question.Image = global::BM.BaseUI.Properties.Resources.menu_feedback;
            this.cms_item_question.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cms_item_question.Name = "cms_item_question";
            this.cms_item_question.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.cms_item_question.Size = new System.Drawing.Size(149, 28);
            this.cms_item_question.Text = "问题意见";
            this.cms_item_question.Click += new System.EventHandler(this.cms_item_Click);
            this.cms_item_question.MouseEnter += new System.EventHandler(this.cms_item_MouseEnter);
            this.cms_item_question.MouseLeave += new System.EventHandler(this.cms_item_MouseLeave);
            // 
            // cms_item_about
            // 
            this.cms_item_about.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms_item_about.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cms_item_about.Image = global::BM.BaseUI.Properties.Resources.menu_about;
            this.cms_item_about.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cms_item_about.Name = "cms_item_about";
            this.cms_item_about.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.cms_item_about.Size = new System.Drawing.Size(149, 28);
            this.cms_item_about.Text = "关于软件";
            this.cms_item_about.Click += new System.EventHandler(this.cms_item_Click);
            this.cms_item_about.MouseEnter += new System.EventHandler(this.cms_item_MouseEnter);
            this.cms_item_about.MouseLeave += new System.EventHandler(this.cms_item_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 81);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(999, 587);
            this.panelMain.TabIndex = 4;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(999, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panelBottom);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_windowstools.ResumeLayout(false);
            this.cms_tools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_windowstools;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.ContextMenuStrip cms_tools;
        private System.Windows.Forms.ToolStripMenuItem cms_item_setting;
        private System.Windows.Forms.ToolStripMenuItem cms_item_update;
        private System.Windows.Forms.ToolStripMenuItem cms_item_web;
        private System.Windows.Forms.ToolStripMenuItem cms_item_question;
        private System.Windows.Forms.ToolStripMenuItem cms_item_about;
        public System.Windows.Forms.Panel panelMain;
    }
}