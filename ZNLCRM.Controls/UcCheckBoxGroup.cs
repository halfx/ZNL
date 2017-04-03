using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace ZNLCRM.Controls
{
    public partial class UcCheckBoxGroup : UserControl
    {
        #region 私有变量
        List<KeyValuePair<string, object>> _kvList = null;

        #endregion

        #region 事件委托
        public delegate void CheckBoxGroupValueChangedEventHandler(object sender, CheckBoxGroupValueChangedArgs e);
        [Description("ValueChanged"), Category("属性已更改")]
        public event CheckBoxGroupValueChangedEventHandler ItemCheckedChanged;
        #endregion

        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public FlowLayoutPanel CheckBoxControls 
        {
            get { return flpCheckBox; }
        }
        [Description("单选列表"), Category("行为")]
        public List<KeyValuePair<string, object>> KvList
        {
            get
            {
                if (_kvList == null)
                {
                    _kvList = new List<KeyValuePair<string, object>>();
                }
                return _kvList;
            }
            set//初始化Radio
            {
                flpCheckBox.Controls.Clear();
                if (value != null && value.Count > 0)
                {
                    foreach (KeyValuePair<string, object> kv in value)
                    {
                        CheckBoxX cbx = new CheckBoxX();
                        cbx.BackgroundStyle.Class = "";
                        cbx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                        cbx.Style = eDotNetBarStyle.StyleManagerControlled;
                        cbx.AutoSize = true;
                        cbx.Text = kv.Key;
                        cbx.Tag = kv.Value;
                        flpCheckBox.Controls.Add(cbx);
                        //增加事件
                        cbx.CheckedChanged += delegate(object sender, EventArgs e)
                        {
                            if (this.ItemCheckedChanged != null)
                            {
                                CheckBoxX cb = sender as CheckBoxX;
                                this.ItemCheckedChanged(this, new CheckBoxGroupValueChangedArgs(cb.Checked, cb.Text, cb.Tag));
                            }
                        };
                    }
                }
                _kvList = value;
            }
        }

        [Description("值"), Category("行为")]
        public string Value
        {
            get
            {
                string strRet = string.Empty;
                foreach (Control c in flpCheckBox.Controls)
                {
                    if (c.GetType() == typeof(CheckBoxX))
                    {
                        if (((CheckBoxX)c).Checked)
                        {
                            strRet += c.Tag.ToString() + ",";
                        }
                    }
                }
                if (!string.IsNullOrEmpty(strRet))
                {
                    strRet = strRet.Remove(strRet.Length - 1);
                }
                return strRet;
            }
            set
            {
                foreach (Control c in flpCheckBox.Controls)
                {
                    if (c.GetType() == typeof(CheckBoxX))
                    {
                        ((CheckBoxX)c).Checked = false;
                    }
                }

                if (!string.IsNullOrEmpty(value))
                {
                    string[] checks = value.Split(',');
                    foreach (string chk in checks)
                    {
                        foreach (Control c in flpCheckBox.Controls)
                        {
                            if (c.GetType() == typeof(CheckBoxX) && c.Tag != null && c.Tag.ToString().Equals(chk))
                            {
                                ((CheckBoxX)c).Checked = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        [Description("文本"), Category("行为")]
        public override string Text
        {
            get
            {
                string strRet = string.Empty;
                foreach (Control c in flpCheckBox.Controls)
                {
                    if (c.GetType() == typeof(CheckBoxX))
                    {
                        if (((CheckBoxX)c).Checked)
                        {
                            strRet += c.Text + ",";
                        }
                    }
                }
                if (!string.IsNullOrEmpty(strRet))
                {
                    strRet = strRet.Remove(strRet.Length - 1);
                }
                return strRet;
            }
        }
        #endregion

        public UcCheckBoxGroup()
        {
            InitializeComponent();
        }

        public void AutoHeight()
        {
            if (_kvList.Count > 0)
            {
                this.Height = flpCheckBox.Controls[_kvList.Count - 1].Bottom + 3;
            }
        }
        /// <summary>
        /// 把值转换为显示文本
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ValueToText(string value)
        {
            string res = string.Empty;
            if (!string.IsNullOrEmpty(value))
            {
                string[] vs = value.Split(',');
                foreach (string v in vs)
                {
                    foreach (KeyValuePair<string, object> kv in _kvList)
                    {
                        if (kv.Value != null && v == kv.Value.ToString())
                        {
                            res += kv.Key + ",";
                            break;
                        }
                    }
                }
                if (res.Length > 0)
                {
                    res = res.Substring(0, res.Length - 1);
                }
            }
            return res;
        }

        /// <summary>
        /// 清除所有的复选框
        /// </summary>
        public void Clear()
        {
            KvList.Clear();
            flpCheckBox.Controls.Clear();
        }

        /// <summary>
        /// 往容器里添加一个复选框
        /// </summary>
        /// <param name="kvp"></param>
        public void AddItem(KeyValuePair<string, object> kvp)
        {
            if (_kvList == null)
            {
                _kvList = new List<KeyValuePair<string, object>>();
            }
            if (_kvList.Count(a=>a.Value.ToString() == kvp.Value.ToString()) == 0)
            {
                _kvList.Add(kvp);
            }
            CheckBoxX cbx = new CheckBoxX();
            cbx.BackgroundStyle.Class = "";
            cbx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            cbx.Style = eDotNetBarStyle.StyleManagerControlled;
            cbx.AutoSize = true;
            cbx.Text = kvp.Key;
            cbx.Tag = kvp.Value;
            flpCheckBox.Controls.Add(cbx);
            //增加事件
            cbx.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (this.ItemCheckedChanged != null)
                {
                    CheckBoxX cb = sender as CheckBoxX;
                    this.ItemCheckedChanged(this, new CheckBoxGroupValueChangedArgs(cb.Checked, cb.Text, cb.Tag));
                }
            };
        }

        public void DelItemByValue(string value)
        {
            SetCheckByValue(value, false);
            if (_kvList != null)
            {
                if (_kvList.Count(a => a.Value.ToString() == value) > 0)
                {
                    _kvList.Remove(_kvList.Find(a => a.Value.ToString() == value));
                }
            }
            foreach (Control c in flpCheckBox.Controls)
            {
                if (c.GetType() == typeof(CheckBoxX) && c.Tag != null && c.Tag.ToString().Equals(value))
                {
                    flpCheckBox.Controls.Remove(c);
                    break;
                }
            } 
        }

        public void SetCheckByValue(string value,bool check)
        {
            foreach (Control c in flpCheckBox.Controls)
            {
                if (c.GetType() == typeof(CheckBoxX) && c.Tag != null && c.Tag.ToString().Equals(value))
                {
                    ((CheckBoxX)c).Checked = check;
                    break;
                }
            } 
        }

        /// <summary>
        /// 全选
        /// </summary>
        public void SelectAll()
        {
            foreach (Control c in flpCheckBox.Controls)
            {
                if (c.GetType() == typeof(CheckBoxX))
                {
                    ((CheckBoxX)c).Checked = true;
                }
            } 
        }

        /// <summary>
        /// 反选(清除所有的选中项)
        /// </summary>
        public void ClearSelected()
        {
            foreach (Control c in flpCheckBox.Controls)
            {
                if (c.GetType() == typeof(CheckBoxX))
                {
                    ((CheckBoxX)c).Checked = false;
                }
            }
        }
    }

    #region CheckBoxGroup值改变事件参数
    public class CheckBoxGroupValueChangedArgs : EventArgs
    {
        bool _checked;
        /// <summary>
        /// 改变的CheckBox的Checked值
        /// </summary>
        public bool Checked
        {
            get
            {
                return _checked;
            }
        }

        string _text;
        /// <summary>
        /// 改变的CheckBox的Text值
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
        }

        object _value;
        /// <summary>
        /// 改变的CheckBox的Tag值
        /// </summary>
        public object Value
        {
            get
            {
                return _value;
            }
        }

        public CheckBoxGroupValueChangedArgs(bool check, string text, object value)
        {
            _checked = check;
            _text = text;
            _value = value;
        }
    }
    #endregion
}
