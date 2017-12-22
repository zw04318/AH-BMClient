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
    public enum CheckType
    {
        Int,
        String,
        Double
    }

    public partial class CheckTextBox : UserControl
    {
        public CheckTextBox()
        {
            InitializeComponent();
            SetLable();
            bmTextBoxBase.LostFocus += bmTextBoxBase_LostFocus;
        }

        private void bmTextBoxBase_LostFocus(object sender, EventArgs e)
        {
            CheckValue();
        }

        private CheckType _checkType = CheckType.String;

        private bool _CanBeNull = true;

     

        private object _value = null;

        private bool CheckValue()
        {
            bool valueChecked = true;
            if (string.IsNullOrEmpty(bmTextBoxBase.Text))
            {
                if (!_CanBeNull)
                {
                    valueChecked = false;
                }
                else
                {
                    switch (_checkType)
                    {
                        case CheckType.Int:
                            _value = 0;
                            break;
                        case CheckType.String:
                            _value = bmTextBoxBase.Text;
                            break;
                        case CheckType.Double:
                            _value = 0;
                            break;
                        default:
                            break;
                    }
                }

            }
            else
            {
                switch (_checkType)
                {
                    case CheckType.Int:
                        try
                        {
                            _value = int.Parse(bmTextBoxBase.Text);
                        }
                        catch
                        {
                            valueChecked = false;
                        }
                        break;
                    case CheckType.String:
                        break;
                    case CheckType.Double:
                        try
                        {
                            _value = double.Parse(bmTextBoxBase.Text);
                        }
                        catch
                        {
                            valueChecked = false;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (!valueChecked)
            {
                bmLabel1.ForeColor = Color.Red;
                bmLabel1.AutoSize = false;
                bmLabel1.Visible = true;
            }
            else
            {
                bmLabel1.ForeColor = SystemColors.ControlText;
                if (_CanBeNull)
                {
                    bmLabel1.Visible = false;
                }
            }
            return valueChecked;
        }

        #region 属性
        [Category("bmTextBox")]
        [Description("类型检查")]
        public CheckType checkType
        {
            get { return _checkType; }
            set
            {
                _checkType = value;
            }
        }

        [Category("bmTextBox")]
        [Description("是否可以为null")]
        public bool CanBeNull
        {
            get { return _CanBeNull; }
            set
            {
                _CanBeNull = value;
                SetLable();
            }
        }

        private void SetLable()
        {  
            if (_CanBeNull)
            {
                bmLabel1.Visible = false;
            }
            else
            {
                bmLabel1.AutoSize = false;
                bmLabel1.Visible = true;
            }
        }


        [Category("bmTextBox")]
        [Description("值")]
        public Object Value
        {
            get 
            {
                if (DesignMode)
                {
                    return bmTextBoxBase.Text;
                }
                else
                {
                    if (_value != null)
                    {
                        return _value;
                    }
                    else
                    {
                        return bmTextBoxBase.Text;
                    }
                }
            }
            set
            {
                bmTextBoxBase.Text = value.ToString();
            }
        }

        public bool ValueCheck
        {
            get
            {
                if (DesignMode)
                {
                    return true;
                }
                return CheckValue();
            }
        }
        #endregion

        private void bmTextBoxBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                return;
            }

            switch (_checkType)
            {
                case CheckType.Int:
                    if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
                case CheckType.String:
                    break;
                case CheckType.Double:
                    if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar) && e.KeyChar != 46)
                    {
                        e.Handled = true;
                    }
                    if (e.KeyChar == 46 && !string.IsNullOrEmpty(bmTextBoxBase.Text) && bmTextBoxBase.Text.IndexOf(".") >= 0)
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
            base.OnKeyPress(e);
        }
    }
}
