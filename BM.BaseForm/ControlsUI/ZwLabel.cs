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
    public partial class ZwLabel : Label
    {
        public ZwLabel()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        
    }
}
