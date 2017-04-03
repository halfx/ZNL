using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
using System.IO;
using ZNLCRM.Utility;
using ZNLCRM.Utility.CommonEnum;

namespace ZNLCRM.BLL.Sys
{
    public  class Sys_AttachFilesBLL:BaseBLL
    {
        /// <summary>
        /// 分页集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<Sys_AttachFilesResult> GetPageList(Sys_AttachFilesParam param)
        {
            this.CheckSession();
            PageList<Sys_AttachFilesResult> ret = new PageList<Sys_AttachFilesResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<Sys_AttachFilesResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), Sys_AttachFiles._.CreatedTime.Desc);

            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<Sys_AttachFilesResult> GetList(Sys_AttachFilesParam param)
        {
            this.CheckSession();
            List<Sys_AttachFilesResult> ret = new List<Sys_AttachFilesResult>();
            try
            {
                
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<Sys_AttachFilesResult>(whereClip, Sys_AttachFiles._.CreatedTime.Asc);
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }

        WhereClip GetWhereClip(Sys_AttachFilesParam param)
        {
            this.CheckSession();
            WhereClip where = Sys_AttachFiles._.IsDeleted == 0 ;
            if (param.AttachID > 0) where = where && Sys_AttachFiles._.AttachID == param.AttachID;
            if (param.AttachGuID != null) where = where && Sys_AttachFiles._.AttachGuID == param.AttachGuID;
            if (param.SourceGuid != null) where = where && Sys_AttachFiles._.SourceGuid == param.SourceGuid;
            if (!string.IsNullOrEmpty(param.AttachName)) where = where && Sys_AttachFiles._.AttachName.Like("%" + param.AttachName + "%");
            return where;
        }


        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public Sys_AttachFilesResult GetInfo(Sys_AttachFilesParam param)
        {
            this.CheckSession();
            Sys_AttachFilesResult rst = new Sys_AttachFilesResult();
            #region 判断
            if (param.AttachGuID == null) throw new WarnException("请指定附件GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<Sys_AttachFilesResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(Sys_AttachFilesParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.AttachGuID == null) throw new WarnException("请指定附件GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                Sys_AttachFilesResult info = new Sys_AttachFilesResult();
                info.IsDeleted = true;
                affect = this.Update<Sys_AttachFilesResult>(info, whereClip);
                #region 设置返回值
                ret.Key = affect;
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return ret;
        }

        /// <summary>
        /// 批量上传
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public List<Sys_AttachFilesResult> UploadAttach(List<Sys_AttachFilesResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                if(list.Exists(a=>a.AttachType==null)) throw new  WarnException("没有设置上传的附件类型！");
                

                #endregion
                AttachType type = list[0].AttachType;
                string   attachType=string.Empty;
                 
                switch(type)
                {
                    case AttachType.Bill:
                        attachType="Bill";
                        break;
                    case AttachType.Pic:
                        attachType="Pic";
                        break;
                }
                Sys_RootDirMappingBLL mBLL = new Sys_RootDirMappingBLL();
                mBLL.SessionInfo = this.SessionInfo;
                //获取根目录
                Sys_RootDirMappingResult mRst=  mBLL.GetInfo(new Sys_RootDirMappingParam() { AttachType = attachType, IsEffect = true });
                if(mRst==null) throw new WarnException("根目录映射表没有有效的设置信息！");
                mRst.PhysicalRootPath = mRst.PhysicalRootPath.Replace("{Company}", this.SessionInfo.CompanyID.ToStringHasNull());
                //设置文件目录
                string folderPath = mRst.PhysicalRootPath + @"\" + DateTime.Now.Year + @"\" + DateTime.Now.ToString("yyyyMMdd");
                string thumbnailFolderPath=string.Empty;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                ////如果有图片才形成压缩图片的存放目录
                //if (list.Exists(a => ".bmp.png.jpg.gif.jpeg.BMP.PNG.JPG.GIF.JPEG".Contains(a.FileSuffix)))
                //{
                //    //设置压缩图片的存放目录
                //     thumbnailFolderPath= folderPath + @"\Thumbnail";
                //    if (!Directory.Exists(thumbnailFolderPath))
                //    {
                //        Directory.CreateDirectory(thumbnailFolderPath);
                //    }
                //}
                foreach (Sys_AttachFilesResult rst in list)
                {
                    
                    rst.FileName = DateTime.Now.ToString("yyyyMMddHHmmssms") + new Random().Next(10000, 99999);
                    rst.FilePath = folderPath + @"\" + rst.FileName + rst.FileSuffix;
                    using (FileStream fs = new FileStream(rst.FilePath, FileMode.CreateNew))
                    {
                        fs.Write(rst.File, 0, rst.FileSize.ToInt32());
                        fs.Close();
                    }

                    if ( rst.TBNFile!=null)
                    {
                        rst.TBNFileName = rst.FileName + "_TBN" + ".JPG"; ;
                        rst.TBNFilePath = folderPath + @"\" + rst.TBNFileName;
                        using (FileStream fs = new FileStream(rst.TBNFilePath, FileMode.CreateNew))
                        {
                            fs.Write(rst.TBNFile, 0, rst.TBNFile.Length.ToInt32());
                            fs.Close();
                        }
                    }
                }            
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {

                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return list;

        }

        /// <summary>
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<Sys_AttachFilesResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                this.BatchInsertOrUpdate<Sys_AttachFilesResult>(list);
                affect = this.BatchExecute();
                #region 设置返回值
                ret.Key = affect;
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {

                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }
    }
}
