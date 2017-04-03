using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using MySoft.Data;

namespace ZNLCRM.BLL.Sys
{
    public class SYS_DataGridBLL : BaseBLL
    {
        /// <summary>
        /// 删除个人表格列位置及宽度设置
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public int DeleteGridColIndexAndWidthSetting(SYS_DataGridResult param)
        {
            int ret = 0;
            Guid? companyID = this.SessionInfo.CompanyID;
            Guid? userGuid = this.SessionInfo.UserGuid;
            ret += this.Delete<SYS_UserGridColIndex>(SYS_UserGridColIndex._.DGGUID == param.DGGUID &&
                SYS_UserGridColIndex._.CompanyID == companyID && SYS_UserGridColIndex._.UserGUID == userGuid);
            ret += this.Delete<SYS_UserGridColWidth>(SYS_UserGridColWidth._.DGGUID == param.DGGUID &&
                SYS_UserGridColWidth._.CompanyID == companyID && SYS_UserGridColWidth._.UserGUID == userGuid);
            return ret;
        }

        /// <summary>
        /// 删除公司自定义列名设置
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public int DeleteGridColNameSetting(SYS_DataGridResult param)
        {
            int ret = 0;
            Guid? companyID = this.SessionInfo.CompanyID;
            Guid? userGuid = this.SessionInfo.UserGuid;
            ret += this.Delete<SYS_UserGridColName>(SYS_UserGridColName._.DGGUID == param.DGGUID && SYS_UserGridColName._.CompanyID == companyID);
            return ret;
        }

        public List<SYS_DataGridResult> GetGridColList(SYS_DataGridParam param)
        {
            #region condtion defined
            Guid?[] arrDGID = new Guid?[] { };
            List<SYS_DataGridResult> ret = new List<SYS_DataGridResult>();
            if (param.GridNames == null || param.FormNames == null || param.ParentNames == null
                || param.GridNames.Length <= 0 || param.FormNames.Length <= 0 || param.ParentNames.Length <= 0)
            {
                throw new WarnException("请指定表格条件！");
            }
            #endregion
            #region 表格定义配置
            WhereClip whereClip = WhereClip.All;
            string[] parentNames = param.ParentNames.Where(a => a != null).ToArray();
            whereClip = whereClip && SYS_DataGrid._.GridName.In(param.GridNames)
                        && SYS_DataGrid._.FormName.In(param.FormNames);
            if (parentNames.Length > 0)
            {
                whereClip = whereClip && SYS_DataGrid._.ParentName.In(parentNames);
            }
            ret = this.SelectList<SYS_DataGridResult>(whereClip);
            if (ret.Count > 0)
                arrDGID = ret.Select(a => a.DGGUID).ToArray();
            else return ret;
            #endregion
            #region index defined
            Guid? companyID = this.SessionInfo.CompanyID;
            Guid? userGuid = this.SessionInfo.UserGuid;
            List<SYS_UserGridColIndex> colIdxList = this.SelectList<SYS_UserGridColIndex>(SYS_UserGridColIndex._.DGGUID.In(arrDGID)
                                                                                        && SYS_UserGridColIndex._.CompanyID == companyID
                                                                                        && SYS_UserGridColIndex._.UserGUID == userGuid
                                                                                        , SYS_UserGridColIndex._.DisplayIndex.Asc);
            List<SYS_UserGridColIndex> findIdxList = null;
            foreach (SYS_DataGridResult info in ret)
            {
                findIdxList = colIdxList.Where(a => a.DGGUID == info.DGGUID).ToList();
                info.ColIndexList = findIdxList;
            }
            #endregion
            #region width defined
            List<SYS_UserGridColWidth> colWdthList = this.SelectList<SYS_UserGridColWidth>(SYS_UserGridColWidth._.DGGUID.In(arrDGID)
                                                                                         && SYS_UserGridColWidth._.CompanyID == companyID
                                                                                         && SYS_UserGridColWidth._.UserGUID == userGuid
                                                                                         , SYS_UserGridColWidth._.CWID.Asc);
            List<SYS_UserGridColWidth> findWdthList = null;
            foreach (SYS_DataGridResult info in ret)
            {
                findWdthList = colWdthList.Where(a => a.DGGUID == info.DGGUID).ToList();
                info.ColWidthList = findWdthList;
            }
            #endregion
            #region name defined
            List<SYS_UserGridColName> colNameList = this.SelectList<SYS_UserGridColName>(SYS_UserGridColName._.DGGUID.In(arrDGID)
                                                                                         && SYS_UserGridColName._.CompanyID == companyID
                                                                                         , SYS_UserGridColName._.CNID.Asc);
            List<SYS_UserGridColName> findNameList = null;
            foreach (SYS_DataGridResult info in ret)
            {
                findNameList = colNameList.Where(a => a.DGGUID == info.DGGUID).ToList();
                info.ColNameList = findNameList;
            }
            #endregion
            return ret;
        }
        public List<SYS_DataGridResult> GetAllGridColList(SYS_DataGridParam param)
        {
            #region condtion defined
            Guid?[] arrDGID = new Guid?[] { };
            List<SYS_DataGridResult> ret = new List<SYS_DataGridResult>();
            #endregion
            #region 表格定义配置
            WhereClip whereClip = WhereClip.All;
            ret = this.SelectList<SYS_DataGridResult>(whereClip);
            if (ret.Count > 0)
                arrDGID = ret.Select(a => a.DGGUID).ToArray();
            else return ret;
            #endregion
            #region index defined
            Guid? companyID = this.SessionInfo.CompanyID;
            Guid? userGuid = this.SessionInfo.UserGuid;
            List<SYS_UserGridColIndex> colIdxList = this.SelectList<SYS_UserGridColIndex>(SYS_UserGridColIndex._.DGGUID.In(arrDGID)
                                                                                        && SYS_UserGridColIndex._.CompanyID == companyID
                                                                                        && SYS_UserGridColIndex._.UserGUID == userGuid
                                                                                        , SYS_UserGridColIndex._.DGGUID.Asc && SYS_UserGridColIndex._.DisplayIndex.Asc);
            List<SYS_UserGridColIndex> findIdxList = null;
            foreach (SYS_DataGridResult info in ret)
            {
                findIdxList = colIdxList.Where(a => a.DGGUID == info.DGGUID).ToList();
                info.ColIndexList = findIdxList;
            }
            #endregion
            #region width defined
            List<SYS_UserGridColWidth> colWdthList = this.SelectList<SYS_UserGridColWidth>(SYS_UserGridColWidth._.DGGUID.In(arrDGID)
                                                                                         && SYS_UserGridColWidth._.CompanyID == companyID
                                                                                         && SYS_UserGridColWidth._.UserGUID == userGuid
                                                                                         , SYS_UserGridColWidth._.DGGUID.Asc && SYS_UserGridColWidth._.CWID.Asc);
            List<SYS_UserGridColWidth> findWdthList = null;
            foreach (SYS_DataGridResult info in ret)
            {
                findWdthList = colWdthList.Where(a => a.DGGUID == info.DGGUID).ToList();
                info.ColWidthList = findWdthList;
            }
            #endregion
            #region name defined
            List<SYS_UserGridColName> colNameList = this.SelectList<SYS_UserGridColName>(SYS_UserGridColName._.DGGUID.In(arrDGID)
                                                                                         && SYS_UserGridColName._.CompanyID == companyID
                                                                                         , SYS_UserGridColName._.DGGUID.Asc && SYS_UserGridColName._.CNID.Asc);
            List<SYS_UserGridColName> findNameList = null;
            foreach (SYS_DataGridResult info in ret)
            {
                findNameList = colNameList.Where(a => a.DGGUID == info.DGGUID).ToList();
                info.ColNameList = findNameList;
            }
            #endregion
            return ret;
        }

        public int SaveList(List<SYS_DataGridResult> saveList)
        {
            int ret = 0;
            Guid? companyID = this.SessionInfo.CompanyID;
            if (saveList.Count <= 0) return 0;
            #region 获取所有的表格单据设置
            List<SYS_DataGridResult> allGridRst = this.SelectList<SYS_DataGridResult>(WhereClip.All);
            SYS_DataGridResult findRst = new SYS_DataGridResult();
            #endregion

            List<SYS_UserGridColIndex> lstColIndex = new List<SYS_UserGridColIndex>();
            List<SYS_UserGridColWidth> lstColWidth = new List<SYS_UserGridColWidth>();
            List<SYS_UserGridColName> lstColName = new List<SYS_UserGridColName>();
            List<SYS_DataGridResult> addGrid = new List<SYS_DataGridResult>();
            foreach (SYS_DataGridResult info in saveList)
            {
                #region 查找表格主表
                findRst = allGridRst.Find(a => a.GridName.ToLower() == info.GridName.ToLower()
                                        && a.ParentName.ToLower() == info.ParentName.ToLower()
                                        && a.FormName.ToLower() == info.FormName.ToLower());
                if (findRst == null)
                {
                    addGrid.Add(info);
                }
                #endregion
                #region 重设列索引值的主表关联
                if (info.ColIndexList != null && info.ColIndexList.Count > 0)
                {
                    if (findRst != null)
                    {
                        foreach (SYS_UserGridColIndex idx in info.ColIndexList)
                        {
                            idx.DGGUID = findRst.DGGUID;
                        }
                    }
                    lstColIndex.AddRange(info.ColIndexList);
                }
                #endregion
                #region 重设列宽度值的主表关联
                if (info.ColWidthList != null && info.ColWidthList.Count > 0)
                {
                    if (findRst != null)
                    {
                        foreach (SYS_UserGridColWidth wdth in info.ColWidthList)
                        {
                            wdth.DGGUID = findRst.DGGUID;
                        }
                    }
                    lstColWidth.AddRange(info.ColWidthList);
                }
                #endregion
                #region 重设列名称
                if (info.ColNameList != null && info.ColNameList.Count > 0)
                {
                    if (findRst != null)
                    {
                        foreach (SYS_UserGridColName name in info.ColNameList)
                        {
                            name.DGGUID = findRst.DGGUID;
                        }
                    }
                    lstColName.AddRange(info.ColNameList);
                }
                #endregion
            }
            if (addGrid.Count > 0) ret += this.BatchInsert<SYS_DataGridResult>(addGrid);

            foreach (SYS_UserGridColIndex info in lstColIndex)
            {
                if (info.CIID > 0) info.AttachAll();
            }
            foreach (SYS_UserGridColWidth info in lstColWidth)
            {
                if (info.CWID > 0) info.AttachAll();
            }
            foreach (SYS_UserGridColName info in lstColName)
            {
                if (info.CNID > 0) info.AttachAll();
            }
            if (lstColIndex.Count > 0)
                this.BatchInsertOrUpdate<SYS_UserGridColIndex>(lstColIndex);
            if (lstColWidth.Count > 0)
                this.BatchInsertOrUpdate<SYS_UserGridColWidth>(lstColWidth);
            if (lstColName.Count > 0)
                this.BatchInsertOrUpdate<SYS_UserGridColName>(lstColName);
            ret = this.BatchExecute();
            return ret;
        }
    }
}
