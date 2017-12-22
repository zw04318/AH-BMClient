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
    public partial class ButtonLabel : Label
    {
        public ButtonLabel()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Font = new System.Drawing.Font(this.Font,System.Drawing.FontStyle.Underline);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Underline| System.Drawing.FontStyle.Bold);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Underline);
        }
    }
}
