using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.CRM
{
    public partial class frmZoneManage : frmBaseForm
    {
        public CRM_ZoneLogic zoneLogic = null;
        BindingSource bsZone = new BindingSource();
        int pzid = 0;
        int ztype = 0;
        List<CRM_ZoneResult> tempList = new List<CRM_ZoneResult>();
        List<CRM_ZoneResult> delList = new List<CRM_ZoneResult>();
        List<CRM_ZoneResult> addOrModifyList = new List<CRM_ZoneResult> ();
        public frmZoneManage()
        {
            InitializeComponent();
            zoneLogic = new CRM_ZoneLogic(this);
        }

        #region 窗体加载
        private void frmZoneManage_Load(object sender, EventArgs e)
        {
            BindZoneTree();
        }
        #endregion

       

        private void BindZoneTree()
        {
            adtZone.Nodes.Clear();
            DevComponents.AdvTree.Node sysNode=new DevComponents.AdvTree.Node ();
            sysNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
            sysNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;

            sysNode.Name = "trn0";
            sysNode.Text = "区域管理";
            sysNode.Image = global::ZNLCRM.UI.Properties.Resources.org;
            sysNode.Tag = 0;
            adtZone.Nodes.Add(sysNode);
            List<CRM_ZoneResult> zoneList = zoneLogic.GetList(new CRM_ZoneParam() { });
            BindNode(sysNode, 0, zoneList);
            adtZone.ExpandAll();
        
        }
        public void   BindNode (DevComponents.AdvTree.Node parentNode,int pzid,List<CRM_ZoneResult> zoneList)
       {
           List<CRM_ZoneResult> fZoneList=  zoneList.Where(a => a.PZID == pzid).ToList();
           foreach (CRM_ZoneResult rst in fZoneList)
           {
                DevComponents.AdvTree.Node trNode = new DevComponents.AdvTree.Node();
                trNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                trNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                trNode.Name = "trn" + rst.ZID;
                trNode.Text = rst.Name_CN;
                trNode.Tag = rst.ZType;
                BindNode(trNode, rst.ZID, zoneList);
                parentNode.Nodes.Add(trNode);
                if (rst.ZID == pzid) trNode.Expand();
           }
        }

        #region 选中节点改变
        private void adtZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void SetToolStripMenuItemEnable(ToolStripItemCollection items,ToolStripMenuItem targetItem)
        {
            foreach (ToolStripMenuItem item in items)
            {
                if (item.Name == targetItem.Name)
                    item.Visible = true;
                else
                    item.Visible = false;
            }
        }
        #endregion

        private void adtZone_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            switch (adtZone.SelectedNode.Tag.ToString())
            {
                case "0":
                    SetToolStripMenuItemEnable(cmsOper.Items, tsmiArea);
                    break;
                case "1":
                    SetToolStripMenuItemEnable(cmsOper.Items, tsmiCountry);
                    break;
                case "2":
                    SetToolStripMenuItemEnable(cmsOper.Items, tsmiProvince);
                    break;
                case "3":
                    SetToolStripMenuItemEnable(cmsOper.Items, tsmiCity);
                    break;
            }
            
            pzid = adtZone.SelectedNode.Name.Substring(3).ToInt32();
            ztype = adtZone.SelectedNode.Tag.ToInt32();
            BindDataGridView();
        }

        public void BindDataGridView()
        {
           bsZone.DataSource = null;
           addOrModifyList=  zoneLogic.GetList(new CRM_ZoneParam() { ZType=ztype+1,PZID=pzid });
           bsZone.DataSource = addOrModifyList;
           dgvZone.DataSource = bsZone;
        }

        private void txtSZone_ButtonCustomClick(object sender, EventArgs e)
        {
             
        }

       

        private void btnAddZone_Click(object sender, EventArgs e)
        {
            bsZone.AddNew();
        }

        private void ucButton1_Click(object sender, EventArgs e)
        {
            if (this.bsZone.Current != null)
            {

                int zid = 0;
                CRM_ZoneResult delResult = this.bsZone.Current as CRM_ZoneResult;
                zid = delResult.ZID.ToInt32();
                if (zid > 0)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsZone.RemoveCurrent();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bsZone.EndEdit();
            tempList.Clear();
            
            foreach (CRM_ZoneResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    if (rst.ZID == 0)
                    {
                        rst.PZID = pzid;
                        rst.ZType=ztype+1;
                        
                        rst.IsDeleted = false;
                    }
                    tempList.Add(rst);
                }
            }
            tempList.AddRange(delList);
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, List<CRM_ZoneResult>>(tempList,  zoneLogic.UpdateOrInsertList, (a) =>
            {
                    BindZoneTree();
                    BindDataGridView();
                

            });
            delList.Clear();
          
        }


    }
}
