using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using ZNLCRM.Controls;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility;
using System.Drawing;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;

namespace ZNLCRM.UI.Logic.AppHandler
{
    public class SearchAssembleHandler
    {
        private XmlDocument _xmlDoc;
        private XmlNode _currentFormNode;
        SYS_DictItemLineLogic _dictLineLogic = null;
        List<SYS_DictItemLineResult> _dictItemList = null;
        Form _form;
        List<Control> _containers = new List<Control>();
        List<Control> _btnFinds = new List<Control>();
        Graphics _graphics;
        bool _loadComplete = false;

        public SearchAssembleHandler(Form form)
        {
            _dictLineLogic = new SYS_DictItemLineLogic(form);
            _dictItemList = new List<SYS_DictItemLineResult>();
            _form = form;
            _graphics = form.CreateGraphics();
            InitDoc();

        }
        #region 获取配置文档
        private  void InitDoc()
        {
            try
            {
                if (_xmlDoc == null)
                {
                    string path = GetCurrentDirectory() + "SearchAssemble.xml";
                    _xmlDoc = new XmlDocument();
                    _xmlDoc.Load(path);
                }
                
            }
            catch
            {
                throw new Exception("加载搜索条件配置文件出错！");
            }
        }
        void GetDictItemNodeList()
        {
            if (_currentFormNode == null) return;
            try
            {
                string type = "", tableName = "", codeValue = "";
                List<string> lstDictCode = new List<string>();
                #region 获取当前所有基表的代码值
                foreach (XmlNode node in _currentFormNode.ChildNodes)
                {
                    if (!node.HasChildNodes) continue;
                    foreach (XmlNode node1 in node.ChildNodes)
                    {
                        type = node1.Attributes["Type"] != null ? node1.Attributes["Type"].Value : "";
                        if (type.ToStringHasNull() == "") continue;
                        tableName = node1.Attributes["TableName"] != null ? node1.Attributes["TableName"].Value : "";
                        if (tableName == "" && tableName != "sys_dictitem") continue;
                        codeValue = node1.Attributes["CodeValue"] != null ? node1.Attributes["CodeValue"].Value : "";
                        if (codeValue == "") continue;
                        if (!lstDictCode.Exists(a => a.ToLower() == codeValue.ToLower()))
                        {
                            lstDictCode.Add(codeValue);
                        }
                    }
                }
                #endregion
                #region 获取基准表列表
                if (lstDictCode.Count > 0)
                {
                    _dictItemList = _dictLineLogic.GetListByCode(new SYS_DictItemLineParam
                    {
                        ItemCodes = lstDictCode.ToArray()
                    });
                }
                else
                {
                    _dictItemList = new List<SYS_DictItemLineResult>();
                }
                #endregion
            }
            catch (System.Exception exp)
            {
                throw exp;
            }
        }
        #endregion
        #region 根据类名与容器名称获取配置节点
        public  XmlNode GetNodeByClassFullPath(string className,string panelName)
        {
            _xmlDoc = null;
            InitDoc();
            XmlNode ret = null;
            try
            {
                ret = _xmlDoc.SelectSingleNode("//class[@Name='" + className + "']/panel[@Name='" + panelName + "']");
            }
            catch (System.Exception exp)
            {
                throw exp;
            }
            _currentFormNode = ret.ParentNode;
            GetDictItemNodeList();
            return ret;
        }
        #endregion
        #region 在容器中创建控件
        public  void CreateControlInPanel(string className, Control btnFind, Control container)
        {
            if (!_containers.Contains(container))
            {
                _containers.Add(container);
            }
            if (!this._btnFinds.Contains(btnFind))
            {
                _form.Shown+= delegate(object sender, EventArgs e)
                {
                    if (!_loadComplete) { ArrangeForm(); _loadComplete = true; }
                };
                _form.SizeChanged += delegate(object sender, EventArgs e)
                {
                    ArrangeForm();
                };
                _btnFinds.Add(btnFind);
            }
            string panelName = container.Name;
            XmlNode node = GetNodeByClassFullPath(className, panelName);
            try
            {
                Control con = container;
                string type = "";
                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    type = node.ChildNodes[i].Attributes["Type"].Value.ToStringHasNull().ToLower();
                    if (type == "textbox")
                    {
                        CreateTextBox(node.ChildNodes[i], container);
                    }
                    if (type == "dropdownlist")
                    {
                        CreateDropDownList(node.ChildNodes[i], container);
                    }
                    if (type == "dateinput")
                    {
                        CreateDateControl(node.ChildNodes[i], container);
                    }
                    if (type == "checkbox")
                    {
                        CreateCheckBoxControl(node.ChildNodes[i], container);
                    }
                    if (type == "radiobox")
                    {
                        CreateRadioBoxControl(node.ChildNodes[i], container);
                    }
                }
            }
            catch (System.Exception exp)
            {
                throw exp;
            }
        }
        #endregion
        #region 创建不同控件
        Dictionary<string, ControlInfo> _dicControl = new Dictionary<string, ControlInfo>();
        #region 创建文本控件
        void CreateTextBox(XmlNode node, Control container)
        {
            string engName = node.Attributes["Name"] != null ? node.Attributes["Name"].Value : "";
            string chsName = node.Attributes["CHName"] != null ? node.Attributes["CHName"].Value : "";
            string dataType = node.Attributes["DataType"] != null ? node.Attributes["DataType"].Value : "";
            bool isMuti = node.Attributes["IsMuti"] != null ? node.Attributes["IsMuti"].Value.ToBooleanHasNull() : false;
            string idConName = node.Attributes["IDConName"] != null ? node.Attributes["IDConName"].Value : "";
            int w = node.Attributes["Width"] != null ? node.Attributes["Width"].Value.ToInt32() : 80;
            int h = node.Attributes["Height"] != null ? node.Attributes["Height"].Value.ToInt32() : 28;
            string defaultValue = node.Attributes["DefaultValue"] != null ? node.Attributes["DefaultValue"].Value : "";
            ControlInfo conInfo = new ControlInfo(_form);
            #region 标题
            if (chsName != "")
            {
                UcLabelX label = new UcLabelX();
                label.Name = "lbl" + engName;
                label.Text = chsName;
                label.AutoSize = true;
                conInfo.LabelControl = label;
            }
            #endregion
            #region 隐藏的控件
            UcTextBox txtHid = new UcTextBox();
            txtHid.Name = idConName;
            txtHid.Visible = false;
            conInfo.HidInputControl = txtHid;
            #endregion
            #region 创建文本控件
            UcTextBox txt = new UcTextBox();
            txt.Name = engName;
            txt.Width = w;
            txt.Border.Class = "TextBoxBorder";
            conInfo.InputControl = txt;
            conInfo.KeyName = container.Name;
            if (!_dicControl.ContainsKey(engName)) _dicControl.Add(engName, conInfo);
            #endregion
            
            #region 属性行为控制
            defaultValue = GetDefaultValue(defaultValue);
            if (defaultValue != null) txt.Text = defaultValue;
            SetTextDataType(dataType, isMuti, idConName, txt);
            #endregion
        }
        string GetDefaultValue(string defaultValue)
        {
            string ret = null;
            if (defaultValue == null) return ret;
            if (defaultValue.ToLower() == "[lastyear]")
            {
                DateTime now=DateTime.Now.AddYears(-1);
                ret = now.ToString("yyyy-MM-dd");
            }
            if (defaultValue.ToLower() == "[lastmoath]")
            {
                DateTime now = DateTime.Now.AddMonths(-1);
                ret = now.ToString("yyyy-MM-dd");
            }
            if (defaultValue.ToLower() == "[threemonthago]")
            {
                DateTime now = DateTime.Now.AddMonths(-3);
                ret = now.ToString("yyyy-MM-dd");
            }
            if (defaultValue.ToLower() == "[now]")
            {
                DateTime now = DateTime.Now;
                ret = now.ToString("yyyy-MM-dd");
            }
            
            return ret;
        }
        void SetTextDataType(string dataType,bool isMuti,string idConName, UcTextBox txt)
        {
            if(dataType==null)return;
            dataType = dataType.ToLower();
            if (dataType != "")
            {
                txt.ButtonCustom.Visible = true;
                txt.ButtonCustom.Text = "...";
                txt.ButtonCustom2.Visible = true;
                txt.ButtonCustom2.Text = "X";
            }
            if (dataType == "employeselect")//人员选择
            {
                txt.ButtonCustomClick += new EventHandler(txtEmpSlk_ButtonCustomClick);
                txt.ButtonCustom2Click += new EventHandler(txtEmpSlc_ButtonCustom2Click);
            }
            if (dataType == "supplierselect")//供应商选择
            {
                txt.ButtonCustomClick += new EventHandler(txtEmpSlk_ButtonCustomClick);
                txt.ButtonCustom2Click += new EventHandler(txtEmpSlc_ButtonCustom2Click);
            }
            if (dataType == "customerselect")//客户选择
            {
                txt.ButtonCustomClick += new EventHandler(txtEmpSlk_ButtonCustomClick);
                txt.ButtonCustom2Click += new EventHandler(txtEmpSlc_ButtonCustom2Click);
            }
        }
        void txtEmpSlk_ButtonCustomClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void txtEmpSlc_ButtonCustom2Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region 创建下拉列表
        void CreateDropDownList(XmlNode node, Control container)
        {
            string engName = node.Attributes["Name"] != null ? node.Attributes["Name"].Value : "";
            string chsName = node.Attributes["CHName"] != null ? node.Attributes["CHName"].Value : "";
            string dataType = node.Attributes["DataType"] != null ? node.Attributes["DataType"].Value : "";
            bool isMuti = node.Attributes["IsMuti"] != null ? node.Attributes["IsMuti"].Value.ToBooleanHasNull() : false;
            string idConName = node.Attributes["IDConName"] != null ? node.Attributes["IDConName"].Value : "";
            int w = node.Attributes["Width"] != null ? node.Attributes["Width"].Value.ToInt32() : 80;
            int h = node.Attributes["Height"] != null ? node.Attributes["Height"].Value.ToInt32() : 28;
            string defaultValue = node.Attributes["DefaultValue"] != null ? node.Attributes["DefaultValue"].Value : "";
            string codeValue = node.Attributes["CodeValue"] != null ? node.Attributes["CodeValue"].Value : "";
            //ListValue  For ComboBox
            string ListValue = node.Attributes["ListValue"] != null ? node.Attributes["ListValue"].Value : "";
            #region 标题
            ControlInfo conInfo = new ControlInfo(_form);
            if (chsName != "")
            {
                UcLabelX label = new UcLabelX();
                label.Name = "lbl" + engName;
                label.Text = chsName;
                label.AutoSize = true;
                conInfo.LabelControl = label;
            }
            #endregion
            #region 创建文本控件
            UcComboBox cmb = new UcComboBox();
            cmb.Name = engName;
            cmb.Width = w;
            cmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            cmb.DrawMode = DrawMode.OwnerDrawFixed;
            conInfo.InputControl = cmb;
            conInfo.KeyName = container.Name;
            if (!_dicControl.ContainsKey(engName)) _dicControl.Add(engName, conInfo);
            
            #endregion
            #region 属性行为控制
            if (!string.IsNullOrEmpty(ListValue))//绑定用户枚举列表
            {
                List<SYS_DictItemLineResult> lstSR = new List<SYS_DictItemLineResult>();
                string[] arr1 = new string[] { };
                string[] arr2 = new string[] { };
                arr1 = ListValue.Split(';');
                foreach (string s in arr1)
                {
                    arr2 = s.Split(',');
                    if (arr2.Length < 1) continue;
                    lstSR.Add(new SYS_DictItemLineResult() { ItemValue = arr2[0], ItemValue2 = arr2[1] });
                }
                cmb.DisplayMember = "ItemValue2";
                cmb.ValueMember = "ItemValue";
                cmb.DataSource = lstSR;
                cmb.SelectedIndex = -1;
            }
            else if (string.IsNullOrEmpty(codeValue))//绑定字典表数据
                _dictLineLogic.BindComboBox(cmb, codeValue, _dictItemList);
            defaultValue = GetDefaultValue(defaultValue);
            if (defaultValue != null)
            {
                if (string.IsNullOrEmpty(codeValue))
                    SYS_DictItemLineLogic.SetCombolSelectedIndex(cmb, defaultValue, true);
                else cmb.SelectedValue = defaultValue;
            }
            #endregion
        }
        #endregion
        #region 创建日期控件
        void CreateDateControl(XmlNode node, Control container)
        {
            string engName = node.Attributes["Name"] != null ? node.Attributes["Name"].Value : "";
            string chsName = node.Attributes["CHName"] != null ? node.Attributes["CHName"].Value : "";
            string dataType = node.Attributes["DataType"] != null ? node.Attributes["DataType"].Value : "";
            bool isMuti = node.Attributes["IsMuti"] != null ? node.Attributes["IsMuti"].Value.ToBooleanHasNull() : false;
            string idConName = node.Attributes["IDConName"] != null ? node.Attributes["IDConName"].Value : "";
            int w = node.Attributes["Width"] != null ? node.Attributes["Width"].Value.ToInt32() : 110;
            int h = node.Attributes["Height"] != null ? node.Attributes["Height"].Value.ToInt32() : 110;
            string defaultValue = node.Attributes["DefaultValue"] != null ? node.Attributes["DefaultValue"].Value : "";
            string codeValue = node.Attributes["CodeValue"] != null ? node.Attributes["CodeValue"].Value : "";
            #region 标题
            ControlInfo conInfo = new ControlInfo(_form);
            if (chsName != "")
            {
                UcLabelX label = new UcLabelX();
                label.Name = "lbl" + engName;
                label.Text = chsName;
                label.AutoSize = true;
                conInfo.LabelControl = label;
            }
            #endregion
            #region 创建文本控件
            UcDateTimeInput dta = new UcDateTimeInput();
            dta.Name = engName;
            dta.Width = w;
            dta.CustomFormat = "yyyy-MM-dd";
            dta.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            dta.ButtonDropDown.Visible = true;
            dta.ButtonClear.Visible = true;
            conInfo.InputControl = dta;
            conInfo.KeyName = container.Name;
            if (!_dicControl.ContainsKey(engName)) _dicControl.Add(engName, conInfo);
            #endregion
            #region 属性行为控制
            defaultValue = GetDefaultValue(defaultValue);
            if (defaultValue != null) dta.Text = defaultValue;
            #endregion
        }
        #endregion
        #region 创建复选框控件
        void CreateCheckBoxControl(XmlNode node, Control container)
        {
            string engName = node.Attributes["Name"] != null ? node.Attributes["Name"].Value : "";
            string chsName = node.Attributes["CHName"] != null ? node.Attributes["CHName"].Value : "";
            string dataType = node.Attributes["DataType"] != null ? node.Attributes["DataType"].Value : "";
            bool isMuti = node.Attributes["IsMuti"] != null ? node.Attributes["IsMuti"].Value.ToBooleanHasNull() : false;
            string idConName = node.Attributes["IDConName"] != null ? node.Attributes["IDConName"].Value : "";
            int w = node.Attributes["Width"] != null ? node.Attributes["Width"].Value.ToInt32() : 60;
            int h = node.Attributes["Height"] != null ? node.Attributes["Height"].Value.ToInt32() : 110;
            string defaultValue = node.Attributes["DefaultValue"] != null ? node.Attributes["DefaultValue"].Value : "";
            string codeValue = node.Attributes["CodeValue"] != null ? node.Attributes["CodeValue"].Value : "";
            string text = node.Attributes["Text"] != null ? node.Attributes["Text"].Value : "";
            #region 标题
            ControlInfo conInfo = new ControlInfo(_form);
            if (chsName != "")
            {
                UcLabelX label = new UcLabelX();
                label.Name = "lbl" + engName;
                label.Text = chsName;
                label.AutoSize = true;
                conInfo.LabelControl = label;
            }
            #endregion
            #region 创建控件
            UcCheckBox chk = new UcCheckBox();
            chk.Name = engName;
            chk.Width = w;
            chk.Height = 22;
            chk.Text = text;
            chk.AutoSize = false;
            chk.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
            chk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            chk.Visible = true;
            chk.TextVisible = true;
            conInfo.InputControl = chk;
            conInfo.KeyName = container.Name;
            if (!_dicControl.ContainsKey(engName)) _dicControl.Add(engName, conInfo);
            #endregion
            #region 属性行为控制
            defaultValue = GetDefaultValue(defaultValue);
            if (defaultValue != null) chk.Checked = defaultValue.ToLower() == "true" ? true : false;
            #endregion
        }
        #endregion
        #region 创建单选框控件
        Dictionary<string, Control> _dicRadioGroup = new Dictionary<string, Control>();
        void CreateRadioBoxControl(XmlNode node, Control container)
        {
            string engName = node.Attributes["Name"] != null ? node.Attributes["Name"].Value : "";
            string chsName = node.Attributes["CHName"] != null ? node.Attributes["CHName"].Value : "";
            string dataType = node.Attributes["DataType"] != null ? node.Attributes["DataType"].Value : "";
            bool isMuti = node.Attributes["IsMuti"] != null ? node.Attributes["IsMuti"].Value.ToBooleanHasNull() : false;
            string idConName = node.Attributes["IDConName"] != null ? node.Attributes["IDConName"].Value : "";
            int w = node.Attributes["Width"] != null ? node.Attributes["Width"].Value.ToInt32() : 60;
            int h = node.Attributes["Height"] != null ? node.Attributes["Height"].Value.ToInt32() : 20;
            string defaultValue = node.Attributes["DefaultValue"] != null ? node.Attributes["DefaultValue"].Value : "";
            string codeValue = node.Attributes["CodeValue"] != null ? node.Attributes["CodeValue"].Value : "";
            string text = node.Attributes["Text"] != null ? node.Attributes["Text"].Value : "";
            string groupName = node.Attributes["GroupName"] != null ? node.Attributes["GroupName"].Value : "";
            int slcIdx = node.Attributes["SelectIndex"] != null ? node.Attributes["SelectIndex"].Value.ToInt32() : 0;
            Control panel;
            if (_dicRadioGroup.ContainsKey(groupName)) { panel = _dicRadioGroup[groupName]; }
            else { panel = new UcPanel(); panel.Width = 1; }
            #region 标题
            ControlInfo conInfo = new ControlInfo(_form);
            if (chsName != "")
            {
                UcLabelX label = new UcLabelX();
                label.Name = "lbl" + engName;
                label.Text = chsName;
                label.AutoSize = true;
                conInfo.LabelControl = label;
            }
            #endregion
            #region 创建控件
            string[] arrText = text.ToStringHasNull().Split(';');
            string[] arrTextEx;
            UcRadioBox chk; int idx = 0;
            foreach (string s in arrText)
            {
                arrTextEx = s.Split(',');
                chk = new UcRadioBox();
                chk.Name = engName;
                chk.Width = w;
                chk.Text = arrTextEx.Length > 1 ? arrTextEx[1] : "";
                chk.Tag = arrTextEx.Length > 0 ? arrTextEx[0] : "";
                chk.Dock = DockStyle.Left;
                if (slcIdx == idx) chk.Checked = true;
                panel.Width += chk.Width;
                panel.Height = 22;
                panel.Controls.Add(chk);
                idx++;
            }
            conInfo.InputControl = panel;
            conInfo.KeyName = container.Name;
            if (!_dicControl.ContainsKey(engName)) _dicControl.Add(engName, conInfo);
            #endregion
        }
        #endregion
        #region 控件布局
        public void ArrangeForm()
        {
            for (int i = 0; i < _containers.Count; i++)
            {
                ArrangeForm(_btnFinds[i], _containers[i]);
            }
        }
        public void ArrangeForm(Control btnFind, Control container)
        {
            int top = 10, left = 3;
            int width = container.Width, height = container.Height;
            int w = 0, h = 0,w2=btnFind.Width,h2=btnFind.Height;
            int countNum = 0; bool moveFindBtn = false;
            #region 重新排列表控件布局
            foreach (KeyValuePair<string, ControlInfo> keyv in _dicControl)
            {
                if (keyv.Value.KeyName != container.Name) continue;
                w = keyv.Value.Width; h = keyv.Value.Height;
                #region 换行显示
                if (w + left + w2 + 6 > width && countNum == 0 || w + left + 6 > width && countNum > 0)
                {
                    if (countNum == 0)
                    {
                        btnFind.Left = left;
                        btnFind.Top = top;
                        if (!container.Controls.ContainsKey(btnFind.Name))
                            container.Controls.Add(btnFind);
                        moveFindBtn = true;
                    }
                    top = top + 30;
                    left = 3;
                    countNum++;
                }
                #endregion
                #region 标签
                if (keyv.Value.LabelControl != null)
                {
                    keyv.Value.LabelControl.Left = left;
                    keyv.Value.LabelControl.Top = top + 1;
                    Font f = keyv.Value.LabelControl.Font;
                    SizeF z = _graphics.MeasureString(keyv.Value.LabelControl.Text, f);
                    left += Math.Round(z.Width, 0).ToInt32() + 2;
                    if (!container.Controls.ContainsKey(keyv.Value.LabelControl.Name))
                        container.Controls.Add(keyv.Value.LabelControl);
                }
                #endregion
                #region 输入控件
                if (keyv.Value.InputControl != null)
                {
                    keyv.Value.InputControl.Left = left;
                    if (keyv.Value.InputControl.GetType() == typeof(UcPanel) && keyv.Value.InputControl.Controls.Count>0 && keyv.Value.InputControl.Controls[0].GetType()==typeof(UcRadioBox))
                    {
                        keyv.Value.InputControl.Top = top-3;
                    }
                    else keyv.Value.InputControl.Top = top;
                    left += keyv.Value.InputControl.Width + 5;
                    if (!container.Controls.ContainsKey(keyv.Value.InputControl.Name))
                        container.Controls.Add(keyv.Value.InputControl);
                    keyv.Value.InputControl.BringToFront();
                }
                #endregion
                #region 隐藏控件
                if (keyv.Value.HidInputControl != null)
                {
                    if (!container.Controls.ContainsKey(keyv.Value.HidInputControl.Name))
                        keyv.Value.HidInputControl.Visible = false;
                    container.Controls.Add(keyv.Value.HidInputControl);
                }
                #endregion
            }
            #endregion
            #region 查询按钮定位
            if (!moveFindBtn)
            {
                btnFind.Left = left;
                btnFind.Top = top;
                if (!container.Controls.ContainsKey(btnFind.Name))
                    container.Controls.Add(btnFind);
                moveFindBtn = true;
            }
            #endregion
        }
        #endregion
        #endregion
        /// <summary>
        /// 获得服务站点Bin目录
        /// </summary>
        /// <returns></returns>
        private static string GetCurrentDirectory()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory ;
            return path;
        }

    }
    
    public class ControlInfo
    {
        public string KeyName { get; set; }
        public UcLabelX LabelControl=null;
        public Control InputControl=null;
        public Control HidInputControl = null;
        Form _form;
        Graphics _graphics;
        public ControlInfo(Form form)
        {
            _form = form;
            _graphics = form.CreateGraphics();
        }
        public int Width
        {
            get
            {
                int w=0;
                if (LabelControl != null)
                {
                    Font f = LabelControl.Font;
                    SizeF z = _graphics.MeasureString(LabelControl.Text, f);
                    w += Math.Round(z.Width, 0).ToInt32();
                }
                if(InputControl!=null)w+= InputControl.Width;
               return w;
            }
        }
        public int Height
        {
            get
            {
                if(InputControl!=null)return InputControl.Height;
                else return 0;
            }
        }
    }
}
