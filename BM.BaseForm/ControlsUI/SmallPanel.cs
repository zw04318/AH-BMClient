using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM.BaseUI.ControlsUI
{
    public partial class SmallPanel : UserControl
    {
        public SmallPanel()
        {
            InitializeComponent();
        }

        public bool Chose { get { return cb_chose.Checked; } set { cb_chose.Checked = value; } }

    }
}
