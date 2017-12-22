using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Diagnostics;


namespace BM.BaseUI.ControlsUI
{

    [Designer(typeof(ScrollbarControlDesigner))]
    public class ZwHScrollBar : UserControl
    {

        protected Color moChannelColor = Color.Empty;
       

        protected int moLargeChange = 10;
        protected int moSmallChange = 1;
        protected int moMinimum = 0;
        protected int moMaximum = 100;
        protected int moValue = 0;
        private int nClickPoint;

        protected int moThumbLeft = 0;

        protected bool moAutoSize = false;

        private bool moThumbDown = false;
        private bool moThumbDragging = false;

        public new event EventHandler Scroll = null;
        public event EventHandler ValueChanged = null;

        private int GetThumbWidth()
        {
            int nTrackHeight = (this.Width - (upSide + downSide));
            float fThumbHeight = ((float)LargeChange / (float)Maximum) * nTrackHeight;
            int nThumbHeight = (int)fThumbHeight;

            if (nThumbHeight > nTrackHeight)
            {
                nThumbHeight = nTrackHeight;
                fThumbHeight = nTrackHeight;
            }
            if (nThumbHeight < 56)
            {
                nThumbHeight = 56;
                fThumbHeight = 56;
            }

            return nThumbHeight;
        }

        public Color inColor = Color.FromArgb(7, 174, 185);

        public Color PressInColor = Color.FromArgb(0x09, 0xDC, 0xEB);

        public Color backColor = SystemColors.Control;

        public ZwHScrollBar()
        {

            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            moChannelColor = Color.FromArgb(51, 166, 3);

            this.Height = upSide;
            base.MinimumSize = new Size( upSide + downSide + GetThumbWidth(),upSide);

            tDown.Tick += tDown_Tick;
            tDown.Interval = 10;
            tUp.Tick += tUp_Tick;
            tUp.Interval = 10;
        }

       

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("Behavior"), Description("LargeChange")]
        public int LargeChange
        {
            get { return moLargeChange; }
            set
            {
                moLargeChange = value;
                Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("Behavior"), Description("SmallChange")]
        public int SmallChange
        {
            get { return moSmallChange; }
            set
            {
                moSmallChange = value;
                Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("Behavior"), Description("Minimum")]
        public int Minimum
        {
            get { return moMinimum; }
            set
            {
                moMinimum = value;
                Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("Behavior"), Description("Maximum")]
        public int Maximum
        {
            get { return moMaximum; }
            set
            {
                moMaximum = value;
                Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("Behavior"), Description("Value")]
        public int Value
        {
            get { return moValue; }
            set
            {
                moValue = value;

                int nTrackWidth = (this.Width - (upSide + downSide));
                float fThumbWidth = ((float)LargeChange / (float)Maximum) * nTrackWidth;
                int nThumbWidth = (int)fThumbWidth;

                if (nThumbWidth > nTrackWidth)
                {
                    nThumbWidth = nTrackWidth;
                    fThumbWidth = nTrackWidth;
                }
                if (nThumbWidth < 56)
                {
                    nThumbWidth = 56;
                    fThumbWidth = 56;
                }

                //figure out value
                int nPixelRange = nTrackWidth - nThumbWidth;
                int nRealRange = (Maximum - Minimum) - LargeChange;
                float fPerc = 0.0f;
                if (nRealRange != 0)
                {
                    fPerc = (float)moValue / (float)nRealRange;

                }

                float fTop = fPerc * nPixelRange;
                moThumbLeft = (int)fTop;


                Invalidate();
            }
        }



       

        private int upSide
        {
            get { return this.Height; }
        }

        private int downSide
        {
            get { return this.Height; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;

           

           
            Color tColor = new Color();
            //画上面的按钮
            int jg = 0;

            e.Graphics.FillRectangle(new SolidBrush(backColor), new Rectangle(new Point(0, 0), new Size(upSide, upSide)));

            if (tUp.Enabled)
            {
                tColor = PressInColor;
            }
            else
            {
                tColor = inColor;
            }

            e.Graphics.FillPolygon(new SolidBrush(tColor), new Point[] { new Point(jg, upSide / 2), new Point(upSide - jg - 1, jg), new Point(upSide - jg - 1, upSide - jg) });




            Brush oBrush = new SolidBrush(backColor);

            Brush oWhiteBrush = new SolidBrush(SystemColors.HighlightText);


            //画通道

            //draw channel

            e.Graphics.FillRectangle(oBrush, new Rectangle(upSide, 0, (this.Width - downSide - upSide), this.Height));



            //draw thumb

            int nTrackWidth = (this.Width - (upSide + downSide));

            float fThumbWidth = ((float)this.LargeChange / (float)this.Maximum) * nTrackWidth;

            int nThumbWidth = (int)fThumbWidth;



            if (nThumbWidth > nTrackWidth)
            {

                nThumbWidth = nTrackWidth;

                fThumbWidth = nTrackWidth;

            }

            //float fSpanHeight = (fThumbHeight - (ThumbMiddleImage.Height + ThumbTopImage.Height + ThumbBottomImage.Height)) / 2.0f;

            //int nSpanHeight = (int)fSpanHeight;



            //float fTop = ((float)this.Value / (float)this.Maximum) * (float)nTrackHeight ;

            int nTop = moThumbLeft;

            nTop += upSide;


            if (moThumbDown)
            {
                tColor = PressInColor;
            }
            else
            {
                tColor = inColor;
            }

            e.Graphics.FillRectangle(new SolidBrush(tColor), new Rectangle(nTop, 0, nThumbWidth, this.Height));






            e.Graphics.FillRectangle(new SolidBrush(backColor), new Rectangle(new Point((this.Width - downSide), 0), new Size(upSide, upSide)));

            if (tDown.Enabled)
            {
                tColor = PressInColor;
            }
            else
            {
                tColor = inColor;
            }

            e.Graphics.FillPolygon(new SolidBrush(tColor), new Point[] { new Point(this.Width - jg, upSide / 2), new Point(this.Width - upSide - jg + 1, jg), new Point(this.Width - upSide - jg + 1, upSide - jg) });

            //画边框
            e.Graphics.DrawRectangle(new Pen(inColor), new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            e.Graphics.DrawLine(new Pen(backColor), new Point(1, 0), new Point(this.Width-2, 0));
            //e.Graphics.DrawLine(new Pen(inColor), new Point(0, this.Height - 1), new Point(this.Width, this.Height-1));
            //e.Graphics.DrawLine(new Pen(inColor), new Point(this.Width-1, this.Height), new Point(this.Width-1, 0));
        }

        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
                if (base.AutoSize)
                {
                    this.Height = upSide;
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // bmVScrollBar
            // 
            this.Name = "bmVScrollBar";
            this.Size = new System.Drawing.Size(150, 17);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomScrollbar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomScrollbar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomScrollbar_MouseUp);
            this.ResumeLayout(false);

        }

        private void CustomScrollbar_MouseDown(object sender, MouseEventArgs e)
        {
            Point ptPoint = this.PointToClient(Cursor.Position);
            int nTrackHeight = (this.Width - (upSide + downSide));
            float fThumbWidth = ((float)LargeChange / (float)Maximum) * nTrackHeight;
            int nThumbWidth = (int)fThumbWidth;

            if (nThumbWidth > nTrackHeight)
            {
                nThumbWidth = nTrackHeight;
                fThumbWidth = nTrackHeight;
            }
            if (nThumbWidth < 56)
            {
                nThumbWidth = 56;
                fThumbWidth = 56;
            }

            int nTop = moThumbLeft;
            nTop += upSide;


            Rectangle thumbrect = new Rectangle(new Point(nTop,1 ), new Size(nThumbWidth,this.Height ));
            if (thumbrect.Contains(ptPoint))
            {

                //hit the thumb
                nClickPoint = (ptPoint.X - nTop);
                //MessageBox.Show(Convert.ToString((ptPoint.Y - nTop)));
                this.moThumbDown = true;
                Application.DoEvents();

                Invalidate();
            }

            Rectangle uparrowrect = new Rectangle(new Point(0,1), new Size(upSide, upSide));
            if (uparrowrect.Contains(ptPoint))
            {
                tUp.Tag = new Point(nTrackHeight, nThumbWidth);
                tUp.Start();
            }

            Rectangle downarrowrect = new Rectangle(new Point(upSide + nTrackHeight,1), new Size(upSide, upSide));
            if (downarrowrect.Contains(ptPoint))
            {
                tDown.Tag = new Point(nTrackHeight, nThumbWidth);
                tDown.Start();
                
            }
        }


        private Timer tUp = new Timer();

        private Timer tDown = new Timer();
        private void tUp_Tick(object sender, EventArgs e)
        {
            if (Value == 0)
            {
                tUp.Stop();
            }
            else
            {
                Value -= 1;
                if (ValueChanged != null)
                    ValueChanged(this, new EventArgs());

                if (Scroll != null)
                    Scroll(this, new EventArgs());

                Invalidate();
            }

        }

        private void tDown_Tick(object sender, EventArgs e)
        {
            if (Value > Maximum - LargeChange)
            {
                tDown.Stop();
            }
            else
            {
                Value += 1;
                if (ValueChanged != null)
                    ValueChanged(this, new EventArgs());

                if (Scroll != null)
                    Scroll(this, new EventArgs());

                Invalidate();
            }
        }
        private void CustomScrollbar_MouseUp(object sender, MouseEventArgs e)
        {
            this.moThumbDown = false;
            this.moThumbDragging = false;

            if (tUp.Enabled)
            {
                tUp.Stop();
            }

            if (tDown.Enabled)
            {
                tDown.Stop();
            }
            Application.DoEvents();

            Invalidate();

        }

        private void MoveThumb(int x)
        {
            int nRealRange = Maximum - Minimum;
            int nTrackWidth = (this.Width - (upSide + downSide));
            float fThumbWidth = ((float)LargeChange / (float)Maximum) * nTrackWidth;
            int nThumbWidth = (int)fThumbWidth;

            if (nThumbWidth > nTrackWidth)
            {
                nThumbWidth = nTrackWidth;
                fThumbWidth = nTrackWidth;
            }
            if (nThumbWidth < 56)
            {
                nThumbWidth = 56;
                fThumbWidth = 56;
            }

            int nSpot = nClickPoint;

            int nPixelRange = (nTrackWidth - nThumbWidth);
            if (moThumbDown && nRealRange > 0)
            {
                if (nPixelRange > 0)
                {
                    int nNewThumbLeft = x - (upSide + nSpot);

                    if (nNewThumbLeft < 0)
                    {
                        moThumbLeft = nNewThumbLeft = 0;
                    }
                    else if (nNewThumbLeft > nPixelRange)
                    {
                        moThumbLeft = nNewThumbLeft = nPixelRange;
                    }
                    else
                    {
                        moThumbLeft = x - (upSide + nSpot);
                    }

                    //figure out value
                    float fPerc = (float)moThumbLeft / (float)nPixelRange;
                    float fValue = fPerc * (Maximum - LargeChange);
                    moValue = (int)fValue;
                    //Debug.WriteLine(moValue.ToString());

                    Application.DoEvents();

                    Invalidate();
                }
            }
        }

        private void CustomScrollbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (moThumbDown == true)
            {
                this.moThumbDragging = true;
            }

            if (this.moThumbDragging)
            {

                MoveThumb(e.X);
            }

            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());

            if (Scroll != null)
                Scroll(this, new EventArgs());
        }

    }

}