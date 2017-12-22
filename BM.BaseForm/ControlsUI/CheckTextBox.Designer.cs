namespace BM.BaseUI.ControlsUI
{
    partial class CheckTextBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bmTextBoxBase = new BM.BaseUI.ControlsUI.ZwTextBox();
            this.bmLabel1 = new BM.BaseUI.ControlsUI.ZwLabel();
            this.SuspendLayout();
            // 
            // bmTextBoxBase
            // 
            this.bmTextBoxBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmTextBoxBase.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmTextBoxBase.Location = new System.Drawing.Point(0, 0);
            this.bmTextBoxBase.Margin = new System.Windows.Forms.Padding(0);
            this.bmTextBoxBase.Name = "bmTextBoxBase";
            this.bmTextBoxBase.Size = new System.Drawing.Size(146, 29);
            this.bmTextBoxBase.TabIndex = 2;
            this.bmTextBoxBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bmTextBoxBase_KeyPress);
            // 
            // bmLabel1
            // 
            this.bmLabel1.AutoSize = true;
            this.bmLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bmLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bmLabel1.Location = new System.Drawing.Point(146, 0);
            this.bmLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bmLabel1.Name = "bmLabel1";
            this.bmLabel1.Size = new System.Drawing.Size(27, 21);
            this.bmLabel1.TabIndex = 0;
            this.bmLabel1.Text = "  *";
            this.bmLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bmTextBoxBase);
            this.Controls.Add(this.bmLabel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CheckTextBox";
            this.Size = new System.Drawing.Size(173, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZwLabel bmLabel1;
        private ZwTextBox bmTextBoxBase;

    }
}
