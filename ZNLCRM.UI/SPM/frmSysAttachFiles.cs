using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.DBModel;
using System.IO;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.SPM
{
    public partial class frmSysAttachFiles : frmBaseForm
    {
       
       
        public Guid? SourceGuid;

        BindingSource bsAttach = new BindingSource();
        List<Sys_AttachFilesResult> tempList = new List<Sys_AttachFilesResult>();
        List<Sys_AttachFilesResult> delList = new List<Sys_AttachFilesResult>();
        List<Sys_AttachFilesResult> addOrModifyList = new List<Sys_AttachFilesResult>();
        Sys_AttachFilesLogic fileLogic = null;
        public frmSysAttachFiles()
        {
            InitializeComponent();
            fileLogic = new Sys_AttachFilesLogic(this);
        }

      
        private void tsbImport_Click(object sender, EventArgs e)
        {
            //this.ShowWaitting(enuWaitMsgType.Other);
            List<Sys_AttachFilesResult> rstList = new List<Sys_AttachFilesResult>();
            Sys_AttachFilesResult result=null;
            ofdAttach.Multiselect = true;
            ofdAttach.FileNames.Initialize();
            if (ofdAttach.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ofdAttach.FileNames.Length > 0)
                {
                    try
                    {
                        foreach (string fileName in ofdAttach.FileNames)
                        {
                            string fileSuffix = string.Empty;
                            string attachName = string.Empty;
                            int fileSize = 0;
                            byte[] file = null;
                            byte[] tbnFile = null;
                            if (!string.IsNullOrEmpty(fileName))
                            {
                                if (!File.Exists(fileName))
                                {
                                    throw new Exception(string.Format("{0}文件不存在", fileName));
                                }
                                    using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                                    {
                                        int length = (int)fs.Length;
                                        if (length > 4 * 1024 * 1024)
                                        {
                                            throw new Exception(string.Format("文件{0}大小超过4M,禁止上传！", fileName));
                                            
                                        }
                                        file = new byte[fs.Length];
                                        fs.Seek(0, SeekOrigin.Begin);
                                        fs.Read(file, 0, length);
                                        //生成缩略图
                                        try
                                        {
                                            tbnFile = ZNLCRM.Utility.UITools.MakeThumbnail(fs, 100, 0, "W");
                                        }
                                        catch (Exception ex)
                                        {
                                            
                                        }
                                        fs.Close();
                                        fileSize = length;
                                    }
                                    if (file != null)
                                    {
                                        attachName = Path.GetFileNameWithoutExtension(fileName);// 附件名
                                        fileSuffix = Path.GetExtension(fileName);//附件后缀
                                        result = new Sys_AttachFilesResult();
                                        result.AttachType = AttachType.Bill;
                                        result.FileSize = fileSize;
                                        result.FileSuffix = fileSuffix;
                                        result.AttachName = attachName;
                                        result.File = file;
                                        result.TBNFile = tbnFile;
                                        rstList.Add(result);
                                    }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        this.ShowMessage(ex.Message);
                        return;
                    }
                    rstList=fileLogic.UploadAttach(rstList);
                    addOrModifyList.AddRange(rstList);
                    bsAttach.DataSource = addOrModifyList;
                    dgvAttach.DataSource = null;
                    dgvAttach.DataSource = bsAttach;
                   
                }
            }
            //this.HideWaitting();
        }

        private void frmSysAttachFiles_Load(object sender, EventArgs e)
        {
            BindDataGridView(pgAttach.PageIndex);
        }
        public void BindDataGridView(int pageIndex)
        {
            if (SourceGuid != null)
            {
                Sys_AttachFilesParam param = new Sys_AttachFilesParam();
                param.SourceGuid = SourceGuid;
                PageList<Sys_AttachFilesResult> lst = this.AsyncExecute<PageList<Sys_AttachFilesResult>, Sys_AttachFilesParam>(param, fileLogic.GetPageList, a =>
                {


                    addOrModifyList = a.ResultList;
                    bsAttach.DataSource = addOrModifyList;
                    dgvAttach.DataSource = bsAttach;
                    pgAttach.RecordCount = a.TotalCount;

                });
            }
            
            
        }
        public void SaveAttach(string sourceTable, Guid sourceGuid, string sourceBillNo)
        { 
           
            bsAttach.EndEdit();
            tempList.Clear();
            foreach (Sys_AttachFilesResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    if (rst.AttachID <= 0)
                    {
                        rst.AttachGuID = Guid.NewGuid();
                        rst.SourceTable = sourceTable;
                        rst.SourceGuid = sourceGuid;
                        rst.SourceBillNo = sourceBillNo;
                        rst.CreatedEmpID = this.SessionInfo.UserID;
                        rst.CreatedEmpName = this.SessionInfo.UserName;
                        rst.CreatedTime = DateTime.Now;
                        rst.IsDeleted = false;
                        
                    }
                    else
                    {
                        rst.UpdatedEmpID = this.SessionInfo.UserID;
                        rst.UpdatedEmpName = this.SessionInfo.UserName;
                        rst.UpdatedTime = DateTime.Now;
                    }
                    tempList.Add(rst);
                    
                    
                }
            }
            
            tempList.AddRange(delList);
            if (tempList.Count > 0)
            {
                WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, List<Sys_AttachFilesResult>>(tempList, fileLogic.UpdateOrInsertList, (a) =>
               {
                   if (a.Key > 0)
                   {
                       BindDataGridView(pgAttach.PageIndex);
                   }
               });
            }
        
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            bsAttach.RemoveCurrent();
        }

        private void dgvAttach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvAttach.Rows)
            {

                if (row.Cells["colAttachID"].Value.ToInt32() <= 0)
                    row.Cells["colDownLoad"].Value = "";
                else
                    row.Cells["colDownLoad"].Value = "下载";

            }
        }

        private void dgvAttach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                switch (dgvAttach.Columns[e.ColumnIndex].Name)
                { 
                    case "colDownLoad":
                    string fileID = dgvAttach["colAttachID", e.RowIndex].Value.ToStringHasNull();
                    string fileSuffix = dgvAttach["colFileSuffix", e.RowIndex].Value.ToStringHasNull();
                    string fileName = dgvAttach["colAttachName", e.RowIndex].Value.ToStringHasNull();
                    string filePath = dgvAttach["colFilePath", e.RowIndex].Value.ToStringHasNull();
                    int fileSize = dgvAttach["colFileSize", e.RowIndex].Value.ToInt32();
                    byte[] fileData = null;
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        string ext = fileSuffix.Replace(".","");
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.DefaultExt = ext;
                        sfd.Filter = string.Format("{0}文件 | *.{0}", ext);
                        sfd.FileName = fileName;
                        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            try
                            {
                                if (!File.Exists(filePath)) throw new Exception("文件已经在服务器上已移动或者删除！");
                                //读取文件流
                                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                                {
                                    int length = (int)fs.Length;

                                    fileData = new byte[fs.Length];
                                    fs.Seek(0, SeekOrigin.Begin);
                                    fs.Read(fileData, 0, length);
                                    fs.Close();
                                }

                                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    fs.Write(fileData, 0, fileSize);
                                    fs.Close();
                                }
                              
                            }
                            catch (Exception ex)
                            {

                                this.ShowMessage("文件正在被另一进程使用，请先关闭！");
                                return;
                            }
                        }
                    }
                        break;
                   
                }
            }
        }
    }
}
