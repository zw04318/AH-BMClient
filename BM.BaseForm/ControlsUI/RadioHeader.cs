using BM.BaseUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.BaseUI.ControlsUI
{
    public partial class RadioHeader : RadioButton
    {
        public RadioHeader()
        {
            InitializeComponent();
            this.Appearance = System.Windows.Forms.Appearance.Button;
            this.BackColor = System.Drawing.Color.Transparent;
            //this.Checked = true;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Size = new System.Drawing.Size(49, 66);
            this.TabStop = true;
            this.AutoSize = false;
            this.UseVisualStyleBackColor = false;
        }


        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            if (this.Checked)
                this.Image = Resources.tab_flag_icon_select;
            else
                this.Image = null;
        }

        protected override void OnMouseEnter(EventArgs eventargs)
        {
            base.OnMouseEnter(eventargs);
            if (!this.Checked)
            {
                this.Image = Resources.tab_flag_icon_hover;
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.Image = Resources.tab_flag_icon_select;
        }

        protected override void OnMouseLeave(EventArgs eventargs)
        {
            base.OnMouseLeave(eventargs);
            if (!this.Checked)
            {
                this.Image = null;
            }
        }
    }
}
