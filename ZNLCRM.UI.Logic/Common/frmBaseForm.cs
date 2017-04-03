using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Controls;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Sys;
using System.Reflection;
using ZNLCRM.Utility;
using DevComponents.DotNetBar;
using System.Threading;
using System.Drawing;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.WF;
using ZNLCRM.UI.Logic.WF;

namespace ZNLCRM.UI.Logic.Common
{
    public partial class frmBaseForm : Form
    {
        UcInformationBox _infoBox;//消息框
        UcInfoWaitting _infoWait;//等待窗体
        protected string _modeuleCode;

        public SessionInfo SessionInfo
        {
            get
            {
                return new SessionInfo()
                {
                    UserID = ZNLCRM.Client.Entry.MySession.UserID,
                    UserName = ZNLCRM.Client.Entry.MySession.UserName,
                    UserGuid = ZNLCRM.Client.Entry.MySession.UserGUID,
                    CompanyID = ZNLCRM.Client.Entry.MySession.CompanyID,
                    OrgID = ZNLCRM.Client.Entry.MySession.OrgID,
                    DeptID = ZNLCRM.Client.Entry.MySession.DeptID
                };
            }
        }
        public frmBaseForm()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                Load += frmBaseForm_Load;
                FormClosed += frmBaseForm_Close;
            }
        }
        #region 查找控件
        private Dictionary<string, object> _formControls = null;
        private Control SetFormControls(Control p_Control)
        {
           if(_formControls==null) _formControls = new Dictionary<string, object>();
            if (!p_Control.HasChildren) return p_Control;
            foreach (Control con in p_Control.Controls)
            {
                if (con.Name != "" && !_formControls.ContainsKey(con.Name))
                {
                    _formControls.Add(con.Name, con);
                }
                #region 工具栏对象
                if (con.GetType() == typeof(UcToolStrip))
                {
                    foreach (ToolStripItem item in (con as UcToolStrip).Items)
                    {
                        if (item.Name != "" && !_formControls.ContainsKey(item.Name))
                        {
                            _formControls.Add(item.Name, item);
                        }
                    }
                }
                #endregion
                #region 表格对象
                else if (con.GetType() == typeof(UcDataGridView))
                {
                    foreach (DataGridViewColumn col in (con as UcDataGridView).Columns)
                    {
                        if (col.Name != "" && !_formControls.ContainsKey(col.Name))
                        {
                            _formControls.Add(col.Name, col);
                        }
                    }
                }
                #endregion
                else if (con.HasChildren)
                {
                    SetFormControls(con);
                }
            }
            return null;
        }
        protected object FindControl(string name)
        {
            if (_formControls == null)
            {
               
                SetFormControls(this);
            }
            object ret = _formControls.ContainsKey(name) ? _formControls[name] : null;
            return ret;
        }
        #endregion
        #region 关于权限控制
        bool _breakLoad = false;
        FormLoadResult _frmLoadResult = new FormLoadResult();
        protected void SetFormRight()
        {
            string nameSpace = "";
            string formName = "";
            nameSpace = this.GetType().Namespace;
            formName = this.Name;
            FormLoadLogic logic = new FormLoadLogic(this);
            try
            {
                _frmLoadResult=logic.GetFormLoadResult(new FormLoadParam() { FormName = formName, NameSpace = nameSpace });
                FormLoadResult rst = _frmLoadResult;
                #region 用户窗体控件权限
                if (rst != null && rst.FormRightList.Count > 0)
                {
                    foreach (Sys_FormRightResult info in rst.FormRightList)
                    {
                        if (info.OprControlEngName.ToStringHasNull().Trim() == "")
                        {
                            if (!info.PropertyValue)
                            {
                                _breakLoad = true;
                                break;
                            }
                            continue;
                        }
                        object objCon = this.FindControl(info.OprControlEngName);

                        if (objCon == null)
                        {
                            MessageBox.Show("控件" + info.OprControlEngName + "未定义！", "加载错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (objCon.GetType().BaseType == typeof(ToolStripItem))
                            {
                                if (info.OprPropertyName == "Visible") (objCon as ToolStripItem).Visible = info.PropertyValue;
                                else if (info.OprPropertyName == "Enabled") (objCon as ToolStripItem).Enabled = info.PropertyValue;
                            }
                            else if (objCon.GetType().BaseType == typeof(DataGridViewColumn))
                            {
                                if (info.OprPropertyName == "Visible") (objCon as DataGridViewColumn).Visible = info.PropertyValue;
                                else if (info.OprPropertyName == "Enabled") (objCon as DataGridViewColumn).Visible = info.PropertyValue;
                            }
                            else
                            {
                                Control con = objCon as Control;
                                if (info.OprPropertyName == "Visible") con.Visible = info.PropertyValue;
                                else if (info.OprPropertyName == "Enabled") con.Enabled = info.PropertyValue;
                            }
                        }
                    }
                }
                #endregion
            }
            catch (System.Exception exp)
            {
                this.ShowMessage(exp.Message);
            }
        }
        protected void CheckIsReadOnly<T>(T editInfo) where T:ZNLFrame.Entity.BaseEntity
        {
            if (editInfo.RecStatu == 1)//只读权限
            {
                #region 用户窗体控件权限
                if (_frmLoadResult != null && _frmLoadResult.FormRightList.Count > 0)
                {
                    foreach (Sys_FormRightResult info in _frmLoadResult.FormRightList)
                    {
                        if (info.OprControlEngName.ToStringHasNull().Trim() == "")
                        {
                            continue;
                        }
                        object objCon = this.FindControl(info.OprControlEngName);

                        if (objCon == null)
                        {
                            MessageBox.Show("控件" + info.OprControlEngName + "未定义！", "加载错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (objCon.GetType().BaseType == typeof(ToolStripItem))
                            {
                                if (info.OprPropertyName == "Visible") (objCon as ToolStripItem).Visible = false;
                                else if (info.OprPropertyName == "Enabled") (objCon as ToolStripItem).Enabled = false;
                            }
                            else if (objCon.GetType().BaseType == typeof(DataGridViewColumn))
                            {
                                if (info.OprPropertyName == "Visible") (objCon as DataGridViewColumn).Visible = false;
                                else if (info.OprPropertyName == "Enabled") (objCon as DataGridViewColumn).Visible = false;
                            }
                            else
                            {
                                Control con = objCon as Control;
                                if (info.OprPropertyName == "Visible") con.Visible = false;
                                else if (info.OprPropertyName == "Enabled") con.Enabled = false;
                            }
                        }
                    }
                }
                #endregion
                
            }

        }
        /// <summary>
        /// 设置审核状态
        /// </summary>
        protected void CheckAuditStatus<T>(T editInfo,params Control[] container) where T:ZNLFrame.Entity.BaseEntity
        {
            Type type = editInfo.GetType();
            bool isCancel = false;
            PropertyInfo propertyInfoCancel = type.GetProperty("IsCancel");
            if (propertyInfoCancel != null) isCancel=propertyInfoCancel.GetValue(editInfo, null).ToBooleanHasNull();
            PropertyInfo propertyInfo = type.GetProperty("Status");
            if (propertyInfo == null) return;
            string auditStatus = propertyInfo.GetValue(editInfo, null).ToStringHasNull();

            if (!isCancel && auditStatus.ToLower() != "approve" && auditStatus.ToLower() != "complete" && auditStatus.ToLower() != "nopass")
            {
                return;
            }
            PropertyInfo propertyRead;
            for (int i = 0; i < container.Length; i++)
            {
                foreach (Control con in container[i].Controls)
                {
                    if (con.GetType() == typeof(UcPanel) || con.GetType() == typeof(UcPanelEx) || con.GetType() == typeof(Panel))
                    {
                        continue;
                    }
                    propertyRead = con.GetType().GetProperty("ReadOnly");
                    if (propertyRead != null)
                    {
                        propertyRead.SetValue(con, true, null);
                    }
                    else
                    {
                        con.Enabled = false;
                    }
                }
            }
            T info = (T)Activator.CreateInstance(editInfo.GetType(), null);
            info.RecStatu = 1;
            CheckIsReadOnly<T>(info);
        }
        #endregion
        #region 窗体定时器
        System.Windows.Forms.Timer _timer;
        void StartTime(int ms,Action action)
        {
            if (this._timer == null)
            {
                this._timer = new System.Windows.Forms.Timer();
                this._timer.Tick += ((a, b) => { this._timer.Stop(); if (action != null) action(); _timer.Dispose(); _timer = null; });
            }
            this._timer.Interval = ms;
            this._timer.Start();
        }

        #endregion
        #region 绑定表格用户自定义的设置方法
        
        GridUserSetting _gridUserSetting = new GridUserSetting();
        protected void frmBaseForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            ZNLCRM.Entity.UserModel.Sys.SYS_DataGridParam param = new Entity.UserModel.Sys.SYS_DataGridParam();
            _gridUserSetting.GetAllGridColList(param);
            BindAllGridSetEvent();
            SetFormRight();
            if (_breakLoad)
            {
                this.Controls.Clear();
                MessageBox.Show("您无权限操作当前页面！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StartTime(100, delegate() { if (!this.IsDisposed) { this.Close(); this.Dispose(); } });
            }
        }

        protected void frmBaseForm_Close(object sender, EventArgs e)
        {
            _gridUserSetting.SaveGridSet();
        }
        private void BindAllGridSetEvent()
        {
            try
            {
                List<UcDataGridView> lstGrid = new List<UcDataGridView>();
                foreach (Control con in this.Controls)
                {
                    if (con.GetType() == typeof(UcDataGridView))
                    {
                        lstGrid.Add(con as UcDataGridView);
                        _gridUserSetting.BindApplyGridEvent(con as UcDataGridView);
                    }
                    else
                    {
                        bind_keyPress(con);
                        BindAllGridSetEvent(con, lstGrid);
                    }
                }
            }
            catch (System.Exception exp)
            {
                this.ShowMessage(exp.Message);
            }
        }
        
        private Control BindAllGridSetEvent(Control control, List<UcDataGridView> lstGrid)
        {
            Control ret = new Control();
            foreach (Control con in control.Controls)
            {
                if (con.GetType() == typeof(UcDataGridView))
                {
                    lstGrid.Add(con as UcDataGridView);
                    _gridUserSetting.BindApplyGridEvent(con as UcDataGridView);
                }
                else
                {
                    bind_keyPress(con);
                    BindAllGridSetEvent(con, lstGrid);
                }
            }
            return ret;
        }
        void bind_keyPress(Control con)
        {
            #region 设置控件的回车事件
            if (con.GetType() == typeof(UcTextBox))
            {
                if ((con as UcTextBox).Multiline != true)
                    con.KeyPress += control_KeyPress;
            }
            else if (con.GetType() == typeof(UcDateTimeInput) || con.GetType() == typeof(UcComboBox)
                || con.GetType() == typeof(UcCheckBox))
            {
                con.KeyPress += control_KeyPress;
            }
            #endregion
        }
        void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
        #endregion
        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="message"></param>
        #region 显示执行进度和消息提示窗体
        protected void ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            if (_infoBox == null)
            {
                _infoBox = new UcInformationBox();
                this.Controls.Add(_infoBox);
            }
            _infoBox.BringToFront();
            _infoBox.ShowMessage(message);
        }
        protected void ShowWaitting()
        {
            ShowWaitting("");
        }
        protected void ShowWaitting(enuWaitMsgType waittingType)
        {
            string msg = "";
            if (waittingType == enuWaitMsgType.BindData) msg = "正在装载数据,请稍候...";
            else if (waittingType == enuWaitMsgType.Update) msg = "正在更新数据,请稍候...";
            else if (waittingType == enuWaitMsgType.Del) msg = "正在删除数据,请稍候...";
            else if (waittingType == enuWaitMsgType.Other) msg = "正在执行操作,请稍候...";
            ShowWaitting(msg);
        }
        void ShowWaitting(string msg)
        {
            Action<string> showMsg = ShowAsyWaitting;
            this.Invoke(showMsg, msg);
        }
        void ShowAsyWaitting(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                message = "正在执行操作,请稍候...";
            }
            if (_infoWait == null)
            {
                _infoWait = new UcInfoWaitting();
                this.Controls.Add(_infoWait);
                _infoWait.Refresh();
            }
            _infoWait.BringToFront();
            _infoWait.ShowMessage(message);
            Application.DoEvents();
        }
         protected void HideWaitting()
         {
            Action hideMsg = this._infoWait.HideMsg;
            this.Invoke(hideMsg);
         }
        #endregion
        #region 实体类的相关方法
        protected T ConvertControlToEntity<T>(Control.ControlCollection controls, T obj, List<Type> excludeTypes)
        {
            object control = null;
            Type type = null;
            #region 排除的类型元素
            if (excludeTypes == null)
            {
                excludeTypes = new List<Type>();
                excludeTypes.Add(typeof(UcLabel));
                excludeTypes.Add(typeof(UcLabelX));
                excludeTypes.Add(typeof(UcButton));
            }
            #endregion
            #region 转换为实体
            PropertyInfo propertyInfo = null;
            string propertyName = "";
            object objV = null, objBind = null;//,objT=null
            for (int i = 0; i < controls.Count; i++)
            {
                control = controls[i];
                type = control.GetType();
                if (excludeTypes.Contains(control.GetType())) continue;
                propertyInfo = type.GetProperty("Name");
                if (propertyInfo == null) continue;
                propertyName = propertyInfo.GetValue(control, null).ToString();
                if (propertyName.Length > 3) propertyName = propertyName.Substring(3);
                #region 文本框
                if (type == typeof(UcTextBox))
                {
                    objV = type.GetProperty("Text").GetValue(control, null);
                    if (objV == null) continue;
                }
                #endregion
                #region 下拉列表
                if (type == typeof(UcComboBox))
                {
                    objV = type.GetProperty("SelectedIndex").GetValue(control, null);
                    if (Convert.ToInt32(objV) < 0) continue;
                    objBind = type.GetProperty("SelectedItem").GetValue(control, null);
                    if (objBind == null) continue;
                    if (objBind.GetType().Name == "ComboItem")
                    {
                        objV = objBind.GetType().GetProperty("Text").GetValue(objBind, null);
                    }
                    else
                    {
                        objV = objBind.GetType().GetProperty(type.GetProperty("ValueMember").GetValue(control, null).ToString()).GetValue(objBind, null);
                    }
                    if (objV == null) continue;
                }
                #endregion
                #region 日期控件
                if (type == typeof(UcDateTimeInput))
                {
                    objV = type.GetProperty("Text").GetValue(control, null);
                    if (objV == null) continue;
                }
                #endregion
                #region 复选控件
                if (type == typeof(UcCheckBox))
                {
                    objV = type.GetProperty("Checked").GetValue(control, null);
                    if (objV == null) continue;
                }
                #endregion
                
                #region 富文本控件
                if (type == typeof(UcRichBox) )
                {
                    objV = type.GetProperty("Text").GetValue(control, null);
                    if (objV == null) continue;
                }
                if(type == typeof(WinHtmlEditor.HtmlEditor))
                {
                    objV = type.GetProperty("BodyInnerHTML").GetValue(control, null);
                    if (objV == null) continue;
                }
                #endregion
                #region 设置实体属性值
                propertyInfo = obj.GetType().GetProperty(propertyName);
                if (propertyInfo == null) continue;
                if (propertyInfo.PropertyType == typeof(string))
                {
                    if (objV.ToStringHasNull().Trim().Equals(string.Empty))
                        objV = "";
                }
                else if (propertyInfo.PropertyType.IsGenericType 
                        && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    if (objV.ToStringHasNull().Trim().Equals(string.Empty))
                        objV = null;
                    else if (propertyInfo.PropertyType == typeof(Guid?))
                    {
                        objV = new Guid(objV.ToString());
                    }
                    else if (propertyInfo.PropertyType == typeof(DateTime?))
                    {
                        objV = DateTime.Parse(objV.ToString());
                    }
                    else if (propertyInfo.PropertyType == typeof(Int32?))
                    {
                        objV = objV.ToInt32();
                    }
                    else if (propertyInfo.PropertyType == typeof(decimal?))
                    {
                        objV = objV.ToDecimal();
                    }
                    else if (propertyInfo.PropertyType == typeof(float?) || propertyInfo.PropertyType == typeof(double?))
                    {
                        objV = objV.ToDouble();
                    }
                    else
                    {
                        if (propertyInfo.PropertyType.GetGenericArguments().Length > 0)
                        {
                            objV = Convert.ChangeType(objV, propertyInfo.PropertyType.GetGenericArguments()[0]);
                        }
                        else
                        {
                            objV = Convert.ChangeType(objV, propertyInfo.PropertyType.GetGenericTypeDefinition());
                        }
                    }
                }
                else if (propertyInfo.PropertyType == typeof(Guid))
                {
                    if (objV.ToString().Trim().Equals(string.Empty))
                        objV = Guid.NewGuid();
                }
                else if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    if (objV.ToString().Trim().Equals(string.Empty))
                        objV = DateTime.MinValue;
                }
                else if (propertyInfo.PropertyType == typeof(Int32))
                {
                    objV = objV.ToInt32();
                }
                else if (propertyInfo.PropertyType == typeof(decimal))
                {
                    objV = objV.ToDecimal();
                }
                else if (propertyInfo.PropertyType == typeof(float) || propertyInfo.PropertyType == typeof(double))
                {
                    objV = objV.ToDouble();
                }
                else
                {
                    if (objV.ToString().Trim().Equals(string.Empty))
                        objV = 0;
                    else objV = Convert.ChangeType(objV, propertyInfo.PropertyType);
                }
                propertyInfo.SetValue(obj, objV, null);
                #endregion
            }
            #endregion

            return obj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="controls"></param>
        /// <param name="obj"></param>
        /// <param name="excludeTypes"></param>
        /// <returns></returns>
        protected void ConvertEntityToControl<T>(Control.ControlCollection controls, T obj, List<Type> excludeTypes)
        {
            object control = null;
            Type type = null;
            #region 排除的类型元素
            if (excludeTypes == null)
            {
                excludeTypes = new List<Type>();
                excludeTypes.Add(typeof(UcLabel));
                excludeTypes.Add(typeof(UcLabelX));
                excludeTypes.Add(typeof(UcButton));
            }
            #endregion
            #region 转换为实体
            PropertyInfo propertyInfo = null;
            string propertyName = "";
            object objV = null;
            UcComboBox cmb = null;
            for (int i = 0; i < controls.Count; i++)
            {
                #region 获取属性名称
                control = controls[i];
                type = control.GetType();
                if (excludeTypes.Contains(control.GetType())) continue;
                propertyInfo = type.GetProperty("Name");
                if (propertyInfo == null) continue;
                propertyName = propertyInfo.GetValue(control, null).ToString();
                if (propertyName.Length > 3) propertyName = propertyName.Substring(3);
                #endregion

                #region 设置实体属性值
                propertyInfo = obj.GetType().GetProperty(propertyName);
                if (propertyInfo == null) continue;
                objV = propertyInfo.GetValue(obj, null);
                if (objV == null) objV = "";
                #endregion
                #region 设置控件值
                #region 文本框
                if (type == typeof(UcTextBox))
                {
                    type.GetProperty("Text").SetValue(control, objV.ToString(), null);
                }
                #endregion
                #region 下拉列表
                if (type == typeof(UcComboBox))
                {
                    cmb = (UcComboBox)control;
                    string sv = "";
                    object cmbItem = null;
                    for (int j = 0; j < cmb.Items.Count; j++)
                    {
                        cmbItem = cmb.Items[j];
                        #region 当前一拉列表的的值
                        sv = cmbItem.GetType().GetProperty(cmb.ValueMember).GetValue(cmbItem, null).ToStringHasNull();
                        if (cmbItem.GetType().Name == "ComboItem")
                        {
                            sv = cmbItem.GetType().GetProperty("Text").GetValue(cmbItem, null).ToStringHasNull();
                        }
                        else
                        {
                            sv = cmbItem.GetType().GetProperty(cmb.ValueMember).GetValue(cmbItem, null).ToStringHasNull();
                        }
                        #endregion
                        #region 数字类型赋值
                        if (objV.GetType() == typeof(decimal) || objV.GetType() == typeof(decimal?))
                        {
                            if (sv.ToStringHasNull().Trim() == "" && objV.ToStringHasNull().Trim() == "")
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                            else if (sv.ToStringHasNull().Trim() != "" && sv.ToDecimal() == objV.ToDecimal())
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                        }
                        #endregion
                        #region 整型赋值
                        else if (objV.GetType() == typeof(int) || objV.GetType() == typeof(int?))
                        {
                            if (sv.ToStringHasNull().Trim() == "" && objV.ToStringHasNull().Trim() == "")
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                            else if (sv.ToStringHasNull().Trim() != "" && sv.ToInt32() == objV.ToInt32())
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                        }
                        #endregion
                        #region 布尔型赋值
                        else if (objV.GetType() == typeof(bool) || objV.GetType() == typeof(bool?))
                        {
                            if (sv.ToStringHasNull().Trim() == "" && objV.ToStringHasNull().Trim() == "")
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                            else if (sv.ToStringHasNull().Trim() != "" && sv.ToBooleanHasNull() == objV.ToBooleanHasNull())
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                        }
                        #endregion
                        #region 日期类型赋值
                        else if (objV.GetType() == typeof(DateTime) || objV.GetType() == typeof(DateTime?))
                        {
                            if (sv.ToStringHasNull().Trim() == "" && objV.ToStringHasNull().Trim() == "")
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                            else if (sv.ToStringHasNull().Trim() != "" && sv.ToDateTime() == objV.ToDateTime())
                            {
                                cmb.SelectedIndex = j;
                                break;
                            }
                        }
                        #endregion
                        #region 字符串类型赋值
                        else if (sv == objV.ToString())
                        {
                            cmb.SelectedIndex = j;
                            break;
                        }
                        #endregion
                    }
                }
                #endregion

                #region 日期
                if (type == typeof(UcDateTimeInput))
                {
                    UcDateTimeInput dta = new UcDateTimeInput();
                    dta = (UcDateTimeInput)control;
                    dta.Text = objV.ToString();
                }
                #endregion
                #region 复选框
                if (type == typeof(UcCheckBox))
                {
                    UcCheckBox chk = new UcCheckBox();
                    chk = (UcCheckBox)control;
                    if (objV.ToString() == "1" || objV.ToString().ToLower() == "true")
                        chk.Checked = true;
                    else chk.Checked = false;
                }
                #endregion
                if (type == typeof(UcRichBox) )
                {
                    type.GetProperty("Text").SetValue(control, objV.ToString(), null);
                }
                if(type==typeof(WinHtmlEditor.HtmlEditor))
                {
                    type.GetProperty("BodyInnerHTML").SetValue(control, objV.ToString(), null);
                }
                #endregion
            }
            #endregion
        }

        protected T CloneEntity<T>(T obj1)
        {
            return EntityHandler.Clone<T>(obj1);
        }
        /// <summary>
        /// 比较两个对象是否有修改过
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Q"></typeparam>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
        protected bool EntityIsChanged<T>(T obj1, T obj2)
        {
            return EntityIsChanged(obj1, obj2, true);
        }
        protected bool EntityIsChanged<T>(T obj1, T obj2, bool showMsg)
        {
            List<string> changedProperty = obj1.GetType().GetProperty("UpdateList").GetValue(obj1, null) as List<string>;
            bool isChanged = EntityHandler.CompareObject<T, T>(obj1, obj2, changedProperty);
            if (!isChanged && showMsg) this.ShowMessage("数据未发生修改,操作被取消!");
            return isChanged;
        }
        #endregion
        #region 异步调用的相关方法
        public delegate T _asyncDelegate<T, P>(P param);
        public enum enuWaitMsgType
        {
            BindData,
            Update,
            Del,
            Other
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">逻辑方法执行结果返回的类型</typeparam>
        /// <typeparam name="P">逻辑方法传入的类型</typeparam>
        /// <typeparam name="V">逻辑方法执行完后,</typeparam>
        /// <param name="param"></param>
        /// <param name="exeMothod"></param>
        /// <param name="exeRst"></param>
        /// <returns></returns>
        protected T AsyncExecute<T, P>(P param, _asyncDelegate<T, P> exeMothod, Action<T> exeRst)
        {
            return AsyncExecute<T, P>(param, exeMothod, exeRst, enuWaitMsgType.Other);
        }
        protected T AsyncExecute<T, P>(P param, _asyncDelegate<T, P> exeMothod, Action<T> exeRst, enuWaitMsgType waittingType)
        {
            string msg = "";
            if (waittingType == enuWaitMsgType.BindData) msg = "正在装载数据,请稍候...";
            else if (waittingType == enuWaitMsgType.Update) msg = "正在更新数据,请稍候...";
            else if (waittingType == enuWaitMsgType.Del) msg = "正在删除数据,请稍候...";
            else if (waittingType == enuWaitMsgType.Other) msg = "正在执行操作,请稍候...";
            return AsyncExecute<T, P>(param, exeMothod, exeRst, msg);
        }
        protected T AsyncExecute<T, P>(P param, _asyncDelegate<T, P> exeMothod, Action<T> exeRst, string msg)
        {
            T ret = default(T);
            _asyncDelegate<T, P> asyncDelegate = new _asyncDelegate<T, P>(exeMothod);
            try
            {
                this.ShowWaitting(msg);
                AsyncCallback asyncCallback = new AsyncCallback(a =>
                {
                    _asyncDelegate<T, P> syncDel = (_asyncDelegate<T, P>)a.AsyncState;
                    try
                    {
                        HideWaitting();
                        object rst = syncDel.EndInvoke(a);
                        this.Invoke(exeRst, (T)rst);
                    }
                    catch (System.Exception exp)
                    {
                        if (IsHandleCreated || !IsDisposed)
                        {
                            Thread.CurrentThread.Abort();
                            this.ShowMessage(exp.Message);
                        }
                    }
                });
                asyncDelegate.BeginInvoke(param, asyncCallback, asyncDelegate);
            }
            catch(System.Exception exp)
            {
                if (IsHandleCreated || !IsDisposed)
                {
                    Thread.CurrentThread.Abort();
                    this.ShowMessage(exp.Message);
                }
            }

            
            #region 其他异步处理方式,留做参考
            //IAsyncResult IRst = asyncDelegate.BeginInvoke(param, asyncCallback, asyncDelegate);
            //ThreadPool.QueueUserWorkItem(state =>
            //{
            //    System.Runtime.Remoting.Contexts.Context context = (System.Runtime.Remoting.Contexts.Context)state;
            //    try {
            //        context.DoCallBack(
            //    }
            //    catch (Exception ex){
            //    //context.ex = 
            //    //   if(IsHandleCreated || !IsDisposed){
            //    //       context.
            //    //   }
            //    }
            //}, new Contex<string>());
            #endregion
            return ret;
        }
        #endregion
        #region 弹出编辑小窗体
        UcEditPanel _ucEditPanel = null;
      
        protected void ShowEditWindow(string title, Control editPanel)
        {
            ShowEditWindow(title, editPanel, true);
        }
        protected void ShowEditWindow(string title,Control editPanel,bool inFormCenter)
        {
            if (_ucEditPanel == null) _ucEditPanel = new UcEditPanel();
            _ucEditPanel.Show();
            _ucEditPanel.AddControl(editPanel, title);
            if (inFormCenter || editPanel.Parent == null)
            {
                if (!this.Controls.Contains(_ucEditPanel)) this.Controls.Add(_ucEditPanel);
            }
            else
            {
                if (!editPanel.Parent.Controls.Contains(_ucEditPanel)) this.Controls.Add(_ucEditPanel);
            }
            _ucEditPanel.BringToFront();
        }
        protected void HidEditWindow()
        {
            if (_ucEditPanel == null) return;
            _ucEditPanel.Hide();
        }
        #endregion
        #region 下拉表格
        UcDropDataGridView __dropDataGridView;
        #region 判断输入是否系统字符
        protected bool IsSysKeys(Keys keyCode)
        {
            bool isSysKey = false;
            if (keyCode==Keys.Escape || keyCode == (Keys.LButton | Keys.Back) || keyCode == (Keys.LButton | Keys.ShiftKey) || keyCode == Keys.Enter || keyCode == Keys.Alt || keyCode == Keys.Shift || keyCode == Keys.Left || keyCode == Keys.Right || keyCode == Keys.Cancel)
            {
                isSysKey = true;
            }
            return isSysKey;
        }
        #endregion
        #region 创建下拉表格
        protected void CreateDropGrid<T, R, P>(int width, int height
                                            , List<DropGridCol> colList, P param, Func<P, T> action)
        {
            __dropDataGridView = this.Controls["__dropGrid"] as UcDropDataGridView;
            if (__dropDataGridView == null)
            {
                __dropDataGridView = new UcDropDataGridView();
                __dropDataGridView.Name = "__dropGrid";
                __dropDataGridView.Anchor = AnchorStyles.None;
                this.Controls.Add(__dropDataGridView);
            }
            __dropDataGridView.CreateDropGrid<T, R, P>(width, height, colList, param, action);
        }
        #endregion
        #region 表格的示例代码
        //private void dgvMain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (e.Control is DataGridViewTextBoxEditingControl)
        //    {
        //        UcDataGridView gridView = sender as UcDataGridView;
        //        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)e.Control;
        //        //事件处理器删除
        //        if (gridView.CurrentCell.OwningColumn.DataPropertyName == "ModuleName")
        //        {
        //            editControl.KeyUp -= editControl_KeyDown;
        //            editControl.KeyUp += new KeyEventHandler(editControl_KeyDown);
        //        }
        //    }
        //}
        //void editControl_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (IsSysKeys(e.KeyCode)) return;
        //    DataGridViewCell cell = this.dgvMain.CurrentCell;
        //    if (cell.RowIndex < 0 || cell.ColumnIndex < 0) return;
        //    DataGridViewTextBoxEditingControl txt = sender as DataGridViewTextBoxEditingControl;
        //    int rowIdx = cell.RowIndex;
        //    Sys_ModuleParam param = new Sys_ModuleParam();
        //    param.ModuleName = txt.Text.ToStringHasNull();

        //    List<DropGridCol> lstCol = new List<DropGridCol>();
        //    lstCol.Add(new DropGridCol() { IsDropSource = false, ColName = "ModuleID", HeadText = "模块ID", IsShow = false, ToControl = this.dgvMain.Rows[rowIdx].Cells["col_Sys_FormRight_ModuleID"], Width = 10 });
        //    lstCol.Add(new DropGridCol() { IsDropSource = true, ColName = "ModuleName", HeadText = "模块模块名称", IsShow = true, ToControl = txt, Width = 200 });
        //    Sys_ModuleLogic logic = new Sys_ModuleLogic(this);
        //    CreateDropGrid<PageList<Sys_ModuleResult>, Sys_ModuleResult, Sys_ModuleParam>(300, 200, lstCol, param, logic.GetPageList);
        //}
        #endregion
        #endregion

        #region 获取实体属性值
        protected object GetObjectPropertyValue<T>(T t, string propertyName)
        {
            Type type = typeof(T);
            PropertyInfo property = type.GetProperty(propertyName);
            if (property == null) return null;
            object o = property.GetValue(t, null);
            return o;
        }
        protected void SetObjectPropertyValue(Object objCon, string propertyName,object objValue)
        {
            if (objCon == null) return;
            PropertyInfo objProp = objCon.GetType().BaseType.GetProperty(propertyName);
            if(objProp!=null)
            objProp.SetValue(objCon, objValue, null);
        }
        #endregion

        #region 给实体属性赋值
        protected void SetObjectPropertyValue<T>(T t, string propertyName, object value)
        {
            Type type = typeof(T);
            PropertyInfo property = type.GetProperty(propertyName);
            try
            {
                property.SetValue(t, value, null);
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region 审核相关方法
        protected void CheckAuditButton(string tableName, Guid? sourceGuid
                    , object conSubmit, object conTakeBack, object conAudit, object conCancel)
        {
            #region 判断输入状态
            if (string.IsNullOrEmpty(tableName)) this.ShowMessage("请指定业务单据表名!");
            //if (sourceGuid == null) this.ShowMessage("请指定业务单据ID!");
            if (conSubmit == null && conTakeBack == null && conAudit == null && conCancel == null) this.ShowMessage("请指定审批按钮!");
            #endregion
            #region 如果是新增界面
            if (sourceGuid == null)
            {
                SetObjectPropertyValue(conSubmit, "Enabled", false);
                SetObjectPropertyValue(conAudit, "Enabled", false);
                SetObjectPropertyValue(conCancel, "Enabled", false);
                SetObjectPropertyValue(conTakeBack, "Enabled", false);
                return;
            }
            #endregion
            #region 获取审批状态
            WF_AuditBillResult auditBillRst = new WF_AuditBillResult();
            WF_AuditRecordLogic recLogic = new WF_AuditRecordLogic(this);
            WF_AuditRecordParam param = new WF_AuditRecordParam();
            param.SourceTableEngName = tableName;
            param.SourceBillGuid = sourceGuid;
            auditBillRst = recLogic.GetAuditBillRecord(param);
            SetObjectPropertyValue(conSubmit, "Enabled", false);
            SetObjectPropertyValue(conAudit, "Enabled", false);
            SetObjectPropertyValue(conCancel, "Enabled", false);
            SetObjectPropertyValue(conTakeBack, "Enabled", false);
            if (auditBillRst == null) { this.ShowMessage("未定义当前单据审批流程!"); return; }
            #endregion
            #region 设置按钮状态
            List<WF_AuditRecordResult> lstAudit = auditBillRst.WF_AuditRecordResultList;
            if (lstAudit == null || lstAudit.Count <= 0)//未提交
            {
                SetObjectPropertyValue(conSubmit, "Enabled", true);
                SetObjectPropertyValue(conAudit, "Enabled", false);
                SetObjectPropertyValue(conCancel, "Enabled", false);
                SetObjectPropertyValue(conTakeBack, "Enabled", false);
            }
            else
            {
                int countNum = lstAudit.Where(a => a.IsCurrent.ToInt32() > 0).Count();
                if (countNum > 0)//已提交待审核
                {
                    SetObjectPropertyValue(conSubmit, "Enabled", false);
                    SetObjectPropertyValue(conAudit, "Enabled", true);
                    SetObjectPropertyValue(conCancel, "Enabled", true);
                    SetObjectPropertyValue(conTakeBack, "Enabled", true);
                    if (lstAudit.Where(a => a.AuditEmpIDs.IndexOf("," + this.SessionInfo.UserID + ",") >= 0).Count() <= 0)
                    {
                        SetObjectPropertyValue(conAudit, "Enabled", false);
                    }
                }
                else //已提交待审核
                {
                    if (auditBillRst.BillStatus.ToLower() == "new")
                    {
                        SetObjectPropertyValue(conSubmit, "Enabled", true);
                        SetObjectPropertyValue(conAudit, "Enabled", true);
                        SetObjectPropertyValue(conCancel, "Enabled", false);
                        SetObjectPropertyValue(conTakeBack, "Enabled", false);
                    }
                    else if (auditBillRst.BillStatus.ToLower() == "complete")
                    {
                        SetObjectPropertyValue(conSubmit, "Enabled", false);
                        SetObjectPropertyValue(conAudit, "Enabled", true);
                        SetObjectPropertyValue(conCancel, "Enabled", true);
                        SetObjectPropertyValue(conTakeBack, "Enabled", false);
                    }
                    else if (auditBillRst.BillStatus.ToLower() == "nopass")
                    {
                        SetObjectPropertyValue(conSubmit, "Enabled", false);
                        SetObjectPropertyValue(conAudit, "Enabled", true);
                        SetObjectPropertyValue(conCancel, "Enabled", true);
                        SetObjectPropertyValue(conTakeBack, "Enabled", false);
                    }

                }
            }
            #endregion
        }
        #region 提交审核
        protected void WF_SubmitBill(string tableName, object editInfo, string sourceBillNo, Guid? sourceBillGuid, bool dataIsChanged, Func<bool> saveData, Action loadData)
        {
            bool enableSubmit = true;
            if (dataIsChanged)
            {
                enableSubmit = saveData();
            }
            if (enableSubmit)
            {
                WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
                WCFAddUpdateResult rstAudit = logicWF.SubmitBill(new Entity.UserModel.WF.WF_AuditRecordParam()
                {
                    SourceTableEngName = tableName,
                    SourceBillGuid = sourceBillGuid,
                    SourceBillNo = sourceBillNo
                });
                if (rstAudit.Key > 0)
                {
                    loadData();
                    this.ShowMessage("提交成功!");
                }
            }
        }
        #endregion
        #region 审核单据
        protected void WF_CheckBill(string tableName, string sourceBillNo, Guid? sourceBillGuid, bool dataIsChanged, Func<bool> saveData, Action loadData)
        {
            frmAuditRecordList frmRecord = new frmAuditRecordList(tableName, sourceBillGuid, sourceBillNo);
            frmRecord.BeforePassEvent = delegate() { return (saveData()); };
            frmRecord.AfterPassEvent = delegate() { loadData(); };
            frmRecord.ShowDialog();
        }
        #endregion
        #region 取消审核单据
        protected void WF_CancelCheckBill(string tableName, Guid? sourceBillGuid, Action loadData)
        {
            if (sourceBillGuid != null)
            {
                WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
                WCFAddUpdateResult rstAudit = logicWF.CancelBill(new Entity.UserModel.WF.WF_AuditRecordParam()
                {
                    SourceTableEngName = tableName,
                    SourceBillGuid = sourceBillGuid
                });
                if (rstAudit.Key > 0)
                {
                    loadData();
                    this.ShowMessage("撤单成功!");
                }
            }
        }
        #endregion
        #region 收回
        protected void WF_TakeBackAuditBill(string tableName, Guid? sourceBillGuid, Action loadData)
        {
            if (sourceBillGuid != null)
            {
                WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
                WCFAddUpdateResult rstAudit = logicWF.TakeBackBill(new Entity.UserModel.WF.WF_AuditRecordParam()
                {
                    SourceTableEngName = tableName,
                    SourceBillGuid = sourceBillGuid
                });
                if (rstAudit.Key > 0)
                {
                    loadData();
                    this.ShowMessage("收回成功!");
                }
            }
        }
        #endregion
        #endregion
    }
}
