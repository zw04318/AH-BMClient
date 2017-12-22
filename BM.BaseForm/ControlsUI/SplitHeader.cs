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
    public partial class SplitHeader : PictureBox
    {
        public SplitHeader()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = Resources.Split_BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Location = new System.Drawing.Point(330, 29);
            this.TabIndex = 105;
            this.TabStop = false;
        }

        public SplitHeader(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
