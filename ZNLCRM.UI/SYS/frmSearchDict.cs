using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.UI.Logic.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSearchDict : frmSelectForm
    {

        SYS_DictItemLineLogic dictLineLogic = null;
        string _idColName="colDictItemLineID";
        string _chkColName = "colChk";
        public string ItemCode = string.Empty;
        public string[] NoItemValue;
        public frmSearchDict(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvDict, this.chkAll, _idColName, _chkColName);
            dictLineLogic = new SYS_DictItemLineLogic(this);
        }
       
       
        #region 绑定
        void BindDictList(int pageIndex)
        {
            SYS_DictItemLineParam param = new SYS_DictItemLineParam();
            param.PageIndex = pageIndex;
            param.PageSize = this.pgDict.PageSize;
            param.ItemCode = ItemCode;
            param.NoItemValue = NoItemValue;
            List<SYS_DictItemLineResult> dictList = new List<SYS_DictItemLineResult>();
            PageList<SYS_DictItemLineResult> list = this.AsyncExecute<PageList<SYS_DictItemLineResult>, SYS_DictItemLineParam>(param, dictLineLogic.GetDictItemLineList, a =>
            {
               
                    dgvDict.DataSource = a.ResultJoinList;
                    pgDict.RecordCount = a.TotalCount;
                    foreach (DataRow row in a.ResultJoinList.Rows)
                    {
                        dictList.Add(new SYS_DictItemLineResult {
                            DictItemLineID = row["DictItemLineID"].ToInt32(),
                            ItemValue = row["ItemValue"].ToStringHasNull(),
                            ItemValue2 = row["ItemValue2"].ToStringHasNull()
                        });
                    }
                    this.SetDataSource(dictList);
                    SetGridCheck(this.dgvDict, _idColName, _chkColName);
                 
            });
           
       
        }
       

        #endregion

        private void pagModule_PageIndexChanged(object sender, EventArgs e)
        {
            BindDictList(this.pgDict.PageIndex);
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }
  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDictList(1);
        }

        private void frmSearchDict_Load(object sender, EventArgs e)
        {
            BindDictList(1);
        }

      

       

     


    }
}
