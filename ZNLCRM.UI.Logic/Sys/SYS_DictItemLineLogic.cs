using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
using System.Data;
using ZNLCRM.Utility;
using ZNLCRM.Utility.CommonEnum;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;


namespace ZNLCRM.UI.Logic.Sys
{
    public  class SYS_DictItemLineLogic:BaseLogic
    {
        public SYS_DictItemLineLogic(Form form) : base(form) { }


        public PageList<SYS_DictItemLineResult> GetDictItemLineList(SYS_DictItemLineParam param)
        {
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.SYS_DictItemLineBLL", "GetDictItemLineList", param);
            PageList<SYS_DictItemLineResult> list = (rst == null ? new PageList<SYS_DictItemLineResult>() : rst.Result as PageList<SYS_DictItemLineResult>);
            return list;
        }

        public List<SYS_DictItemLineResult> GetListByCode(SYS_DictItemLineParam param)
        {
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.SYS_DictItemLineBLL", "GetListByCode", param);
            List<SYS_DictItemLineResult> list = (rst == null ? new List<SYS_DictItemLineResult>() : rst.Result as List<SYS_DictItemLineResult>);
            return list;
        }

        public void BindComboBox(object obj, string itemCode, List<SYS_DictItemLineResult> rst)
        {
            DataValueType valueType=DataValueType.String;
            if (obj is Controls.UcComboBox)
            {
                Controls.UcComboBox c = obj as Controls.UcComboBox;
                if (c != null && !string.IsNullOrEmpty(itemCode))
                {
                  
                    List<KeyValuePair<string, object>> kvList = new List<KeyValuePair<string, object>>();
                    List<SYS_DictItemLineResult> list = rst.Where(a => a.ItemCode ==  itemCode).ToList();
                    if (list != null && list.Count > 0)
                    {
                        kvList = list.Select(a => new KeyValuePair<string, object>(a.ItemValue, a.ItemValue2)).ToList();
                        valueType = list[0].ValueType;
                    }
                    kvList.Insert(0, new KeyValuePair<string, object>("", ""));
                    c.ValueMember = "Value";
                    c.DisplayMember = "Key";
                    if (valueType == DataValueType.Int32)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, int?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (int?)a.Value.ToInt32()))).ToList();
                    else if (valueType == DataValueType.Decimal)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, decimal?>(a.Key, (a.Value==null || a.Value.ToStringHasNull()==""?null:(decimal?)a.Value.ToDecimal()))).ToList();
                    else if (valueType == DataValueType.Boolean)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, bool?>(a.Key, (a.Value==null || a.Value.ToStringHasNull()==""?null:(bool?)a.Value.ToBooleanHasNull()))).ToList();
                    else
                        c.DataSource = kvList;
                }
            }
            else if (obj is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxColumn c = obj as DataGridViewComboBoxColumn;
                if (c != null && !string.IsNullOrEmpty(itemCode))
                {
                
                    List<KeyValuePair<string, object>> kvList = new List<KeyValuePair<string, object>>();
                    List<SYS_DictItemLineResult> list = rst.Where(a => a.ItemCode ==  itemCode).ToList();
                    if (list != null && list.Count > 0)
                    {
                        kvList = list.Select(a => new KeyValuePair<string, object>(a.ItemValue, a.ItemValue2)).ToList();
                        valueType = list[0].ValueType;
                    }
                    kvList.Insert(0, new KeyValuePair<string, object>("", ""));
                    c.ValueMember = "Value";
                    c.DisplayMember = "Key";
                    if (valueType == DataValueType.Int32)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, int?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (int?)a.Value.ToInt32()))).ToList();
                    else if (valueType == DataValueType.Decimal)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, decimal?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (decimal?)a.Value.ToDecimal()))).ToList();
                    else if (valueType == DataValueType.Boolean)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, bool?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (bool?)a.Value.ToBooleanHasNull()))).ToList();
                    else
                        c.DataSource = kvList;
                }
            }
            else if (obj is DataGridViewComboBoxExColumn)
            {
                DataGridViewComboBoxExColumn c = obj as DataGridViewComboBoxExColumn;
                if (c != null && !string.IsNullOrEmpty(itemCode))
                {
                   
                    List<KeyValuePair<string, object>> kvList = new List<KeyValuePair<string, object>>();
                    List<SYS_DictItemLineResult> list = rst.Where(a => a.ItemCode == itemCode).ToList();
                    if (list != null && list.Count > 0)
                    {
                        kvList = list.Select(a => new KeyValuePair<string, object>(a.ItemValue, a.ItemValue2)).ToList();
                        valueType = list[0].ValueType;
                    }
                    kvList.Insert(0, new KeyValuePair<string, object>("", ""));
                    c.ValueMember = "Value";
                    c.DisplayMember = "Key";
                    if (valueType == DataValueType.Int32)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, int?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (int?)a.Value.ToInt32()))).ToList();
                    else if (valueType == DataValueType.Decimal)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, decimal?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (decimal?)a.Value.ToDecimal()))).ToList();
                    else if (valueType == DataValueType.Boolean)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, bool?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (bool?)a.Value.ToBooleanHasNull()))).ToList();
                    else
                        c.DataSource = kvList;
                }
            }
            else if (obj is GridComboBoxExEditControl)
            {
                GridComboBoxExEditControl c = obj as GridComboBoxExEditControl;
                if (c != null && !string.IsNullOrEmpty(itemCode))
                {

                    List<KeyValuePair<string, object>> kvList = new List<KeyValuePair<string, object>>();
                    List<SYS_DictItemLineResult> list = rst.Where(a => a.ItemCode == itemCode).ToList();
                    if (list != null && list.Count > 0)
                    {
                        kvList = list.Select(a => new KeyValuePair<string, object>(a.ItemValue, a.ItemValue2)).ToList();
                        valueType = list[0].ValueType;
                    }
                    kvList.Insert(0, new KeyValuePair<string, object>("", ""));
                    c.ValueMember = "Value";
                    c.DisplayMember = "Key";
                    if (valueType == DataValueType.Int32)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, int?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (int?)a.Value.ToInt32()))).ToList();
                    else if (valueType == DataValueType.Decimal)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, decimal?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (decimal?)a.Value.ToDecimal()))).ToList();
                    else if (valueType == DataValueType.Boolean)
                        c.DataSource = kvList.Select(a => new KeyValuePair<string, bool?>(a.Key, (a.Value == null || a.Value.ToStringHasNull() == "" ? null : (bool?)a.Value.ToBooleanHasNull()))).ToList();
                    else
                        c.DataSource = kvList;
                }
            
            }
        }

      
        public WCFAddUpdateResult UpdateOrInsertList(List<SYS_DictItemLineResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemLineBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
         public List<SYS_DictItemLineResult> GetList(SYS_DictItemLineParam param)
         {
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemLineBLL", "GetList", param);
             List<SYS_DictItemLineResult> list = new List<SYS_DictItemLineResult>();
             list = (rst == null ? new List<SYS_DictItemLineResult>() : rst.Result as List<SYS_DictItemLineResult>);
             return list;
         }

        public WCFAddUpdateResult AddOrUpdate(SYS_DictItemLineResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemLineBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public SYS_DictItemLineResult GetInfo(SYS_DictItemLineParam param)
        {
            SYS_DictItemLineResult ret = new SYS_DictItemLineResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemLineBLL", "GetInfo", param);
            ret = rst == null ? new SYS_DictItemLineResult() : rst.Result as SYS_DictItemLineResult;
            return ret;
        }
     
 
        public WCFAddUpdateResult DelInfo(SYS_DictItemLineParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemLineBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        /// <summary>
        /// 设置下拉列表中的值
        /// </summary>
        /// <param name="findCombol">查找文本列表对象</param>
        /// <param name="findValue">查找值</param>
        /// <param name="isFindValue">是否比对值</param>
        public static void SetCombolSelectedIndex(object findCombol,object findValue,bool isFindValue)
        {
            int  step = -1;
            if (findCombol is Controls.UcComboBox)
            {
                Controls.UcComboBox c = findCombol as Controls.UcComboBox;
                string bindValueField = c.ValueMember;
                string bindTextField = c.DisplayMember;
                
                foreach (object info in c.Items)//KeyValuePair<object, object>
                {
                    step++;
                    #region 遍历值
                    if (isFindValue)
                    {
                        object val = info.GetType().GetProperty(bindValueField).GetValue(info, null);
                        if (val.GetType() == typeof(string))
                        {
                            if (val.ToStringHasNull() == findValue.ToStringHasNull())
                            {
                                break;
                            }
                        }
                        else if (val.GetType() == typeof(int))
                        {
                            if (val.ToInt32() == findValue.ToInt32())
                            {
                                break;
                            }
                        }
                        else if (val.GetType() == typeof(decimal))
                        {
                            if (val.ToDecimal() == findValue.ToDecimal())
                            {
                                break;
                            }
                        }
                    }
                    #endregion
                    #region 比对文本
                    else
                    {
                        object val = info.GetType().GetProperty(bindTextField).GetValue(info, null);
                        if (val.GetType() == typeof(string))
                        {
                            if (val.ToStringHasNull() == findValue.ToStringHasNull())
                            {
                                break;
                            }
                        }
                        else if (val.GetType() == typeof(int))
                        {
                            if (val.ToInt32() == findValue.ToInt32())
                            {
                                break;
                            }
                        }
                        else if (val.GetType() == typeof(decimal))
                        {
                            if (val.ToDecimal() == findValue.ToDecimal())
                            {
                                break;
                            }
                        }
                    }
                    #endregion
                   
                }
                c.SelectedIndex = step;
            }
        }
    }
}
