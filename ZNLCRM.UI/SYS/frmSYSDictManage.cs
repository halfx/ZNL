using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSYSDictManage : frmBaseForm 
    {
         SYS_DictItemLogic dictLogic = null;
         SYS_DictItemLineLogic dictLineLogic = null;
         BindingSource bsDict = new BindingSource();
         List<SYS_DictItemLineResult> tempList=new List<SYS_DictItemLineResult> ();
         List<SYS_DictItemLineResult> addOrModifyList = new List<SYS_DictItemLineResult> ();
         List<SYS_DictItemLineResult> delList = new List<SYS_DictItemLineResult>();
         int dictItemID = 0;
         string dictGroupName = string.Empty;
         int dictItemLineID =0;
         string nodeName = string.Empty;
        public frmSYSDictManage()
        {
            InitializeComponent();
            dictLogic = new SYS_DictItemLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
        }

        #region 清除字典面板里控件的内容
        private void ClearDictConent()
        {
            txtDictItemID.Text = string.Empty;
            txtDictGroupName.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtItemName.Text = string.Empty;
            cboValueType.Text = string.Empty;
        }
        #endregion

        #region  添加数据字典
        private void btnAddDict_Click(object sender, EventArgs e)
        {
            this.ShowEditWindow("添加数据字典", grpDict);
            ClearDictConent();
            txtDictGroupName.Text = dictGroupName;
        }
        #endregion
        #region 右键添加数据字典
        private void tsmiAddDict_Click(object sender, EventArgs e)
        {
            btnAddDict_Click(sender, e);
        }
        #endregion

        #region  编辑数据字典
        private void btnEditDict_Click(object sender, EventArgs e)
        {
            ClearDictConent();

            txtDictItemID.Text = dictItemID.ToStringHasNull();
            if (txtDictItemID.Text.ToInt32()>0)
            {
                ShowEditWindow("编辑数据字典", grpDict);
                SYS_DictItemResult info = new SYS_DictItemResult();
                info = dictLogic.GetInfo(new SYS_DictItemParam() {  DictItemID=txtDictItemID.Text.ToInt32() });
                this.ConvertEntityToControl<SYS_DictItemResult>(this.grpDict.Controls, info, null);
            }
            else
                ShowMessage("请选择需要修改的数据字典！");
        }
        #endregion

        #region 右键编辑数据字典
        private void tsmiEditDict_Click(object sender, EventArgs e)
        {
            btnEditDict_Click(sender, e);
        }
        #endregion

        #region 保存数据字典
        private void btnSaveDict_Click(object sender, EventArgs e)
        {
            SYS_DictItemResult info = new SYS_DictItemResult();
            info.DictItemID =txtDictItemID.Text.ToInt32();
            info = this.ConvertControlToEntity<SYS_DictItemResult>(this.grpDict.Controls, info, null);
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, SYS_DictItemResult>(info, dictLogic.AddOrUpdate, (a) =>
            {
                if (a.Key > 0)
                {
                    this.HidEditWindow();
                    BindDictTree();
                }
               
            });
        }
        #endregion

        #region 删除数据字典
        private void btnDelDict_Click(object sender, EventArgs e)
        {
            
            SYS_DictItemParam param = new SYS_DictItemParam();
            param.DictItemID = dictItemID;
            SYS_DictItemResult rst = dictLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除数据字典：【" + rst.ItemName + "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, SYS_DictItemParam>(param, dictLogic.DelInfo, (a) => { if (a.Key > 0) { 
                        
                        BindDictTree();
                    } });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的数据字典！");
            }
        }
        #endregion

        #region 右键删除数据字典
        private void tsmiDelDict_Click(object sender, EventArgs e)
        {
            btnDelDict_Click(sender, e);
        }
        #endregion 

        #region 取消数据字典编辑
        private void btnCancelDict_Click(object sender, EventArgs e)
        {
            this.HidEditWindow();
        }
        #endregion

       

     

        #region 窗体加载事件
        private void frmSYSDictManage_Load(object sender, EventArgs e)
        {
            BindDictTree();
            InitData();
            
        }
        #endregion 

        void InitData()
        { 
            List<KeyValuePair<string,string>> list=new List<KeyValuePair<string,string>> ();
          
            list.Add(new KeyValuePair<string,string>("字符串","String"));
            list.Add(new KeyValuePair<string,string>("32位整数","Int32"));
            list.Add(new KeyValuePair<string,string>("XML文档","XML"));
            list.Add(new KeyValuePair<string,string>("Json格式","JSON"));
            list.Add(new KeyValuePair<string,string>("布尔型","Boolean"));
            list.Add(new KeyValuePair<string,string>("数值型","Decimal"));
            cboValueType.DataSource = list;
            cboValueType.DisplayMember = "Key";
            cboValueType.ValueMember = "Value";
        
        }

        #region 绑定字典树
        private void BindDictTree()
        {


            this.atDict.Nodes.Clear();
            Dictionary<string, int> dict = dictLogic.GetDictGroup(new SYS_DictItemParam() { Condition= !string.IsNullOrEmpty(txtCondition.Text.Trim())
                ?txtCondition.Text.Trim():null});

            List<SYS_DictItemResult> dictList = dictLogic.GetList(new SYS_DictItemParam() { Condition= !string.IsNullOrEmpty(txtCondition.Text.Trim())
              ?txtCondition.Text.Trim():null});
            DevComponents.AdvTree.Node dictGroupNode=null;
            foreach (string key in dict.Keys)
            {
                dictGroupNode = new DevComponents.AdvTree.Node();
                dictGroupNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                dictGroupNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                dictGroupNode.Text = key + ",共[" + dict[key] + "]个";
                dictGroupNode.Name = "trnGroup" + key;
                dictGroupNode.Tag = key +","+ dictGroupNode.Level;
                dictGroupNode.Image = global::ZNLCRM.UI.Properties.Resources.flag_1;
                atDict.Nodes.Add(dictGroupNode);
                List<SYS_DictItemResult> tempDictList=  dictList.Where(a => a.DictGroupName == key && !string.IsNullOrEmpty(key)).ToList();
                DevComponents.AdvTree.Node dictNode = null;
                foreach (SYS_DictItemResult rst in tempDictList)
                {
                    dictNode = new DevComponents.AdvTree.Node();
                    dictNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                    dictNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                    dictNode.Text = rst.ItemName + "[" + rst.ItemCode + "]";
                    dictNode.Name = "trnDict" + rst.DictItemID;
                    dictNode.Tag = key+","+rst.DictItemID + "," + rst.ItemCode;
                    dictNode.Image = global::ZNLCRM.UI.Properties.Resources.flag_2;
                    dictGroupNode.Nodes.Add(dictNode);
                }
                if (nodeName == dictGroupNode.Name) dictGroupNode.Expand();
                
              
            }
       
        }
        #endregion

        #region 树状菜单选择事件
        private void atDict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (atDict.SelectedNode != null)
            {
                   
                    string[] arr = atDict.SelectedNode.Tag.ToString().Split(',');
                    dictGroupName = arr[0];
                    if (atDict.SelectedNode.Name.Contains("trnDict"))
                    {
                        dictItemID = arr[1].ToInt32();
                        delList = new List<SYS_DictItemLineResult>();
                        BindDataGridView();
                    }
                    else
                    {
                        nodeName = atDict.SelectedNode.Name;
                        dictItemID = 0;
                    }
            }
        }
        #endregion

        #region 绑定表格
        public void BindDataGridView()
        {
            try
            {
                dgvDictItem.DataSource = null;
                bsDict.DataSource = null;
                addOrModifyList = dictLineLogic.GetList(new SYS_DictItemLineParam() { DictItemID = dictItemID });
                bsDict.DataSource = addOrModifyList;
                dgvDictItem.DataSource = bsDict;
            }
            catch (Exception e)
            {

                this.ShowMessage(e.Message);
            }
        }
        #endregion

        private void btnAddDictLine_Click(object sender, EventArgs e)
        {
            
            bsDict.AddNew();
        }

        private void btnDelDictLine_Click(object sender, EventArgs e)
        {
            
            if (this.bsDict.Current != null)
            {
               
                int dictItemLineID = 0;
                SYS_DictItemLineResult delResult = this.bsDict.Current as SYS_DictItemLineResult;
                dictItemLineID = delResult.DictItemLineID.ToInt32();
                if (dictItemLineID > 0)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsDict.RemoveCurrent();
                
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bsDict.EndEdit();
            tempList.Clear();
            if (dictItemID <= 0) {
                this.ShowMessage("未选中要操作的数据字典！");
                return;
            }
            foreach (SYS_DictItemLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    if (rst.DictItemLineID == 0)
                    {
                        rst.DictItemID = dictItemID;
                        rst.IsDeleted = false;
                    }
                    tempList.Add(rst);
                }
            }
            tempList.AddRange(delList);
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, List<SYS_DictItemLineResult>>(tempList, dictLineLogic.UpdateOrInsertList, (a) =>
            {
                if (a.Key > 0)
                {
                    BindDataGridView();
                }

            });
            delList.Clear();
        }

        private void txtCondition_ButtonCustomClick(object sender, EventArgs e)
        {
            BindDictTree();
            BindDataGridView();
        }

        private void txtCondition_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtCondition.Text = string.Empty;
            txtCondition_ButtonCustomClick(sender, e);
        }

       

    }
}
