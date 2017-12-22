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
    public partial class ZwButtonCancel : Button
    {
        public ZwButtonCancel()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(174)))), ((int)(((byte)(185)))));
            this.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Size = new System.Drawing.Size(82, 31);
            this.UseVisualStyleBackColor = false;
        }

       
    }
}
