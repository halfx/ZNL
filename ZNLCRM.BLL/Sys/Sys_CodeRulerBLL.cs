using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.BLL.Sys
{
    public class Sys_CodeRulerBLL : BaseBLL
    {
        /// <summary>
        /// 获取某表单据编号
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string GetBillNo(SYS_CredentialCodeRuleParam param)
        {
            string tableName = param.TableName;
            DateTime seedDate = param.BillDate.ToDateTime(DateTime.Today);
            if (tableName.ToStringHasNull().Trim() == "") throw new WarnException("请指定编号规则所属表!");
            string ret = "", ret1 = "", ret2 = "";
            #region 获取编码表中的配置
            string prefix = "", suffix = ""; int len = 0, initValue = 1;
            SYS_CredentialCodeRuleResult codeRuleInfo = this.Select<SYS_CredentialCodeRuleResult>(SYS_CredentialCodeRule._.GCompanyID.IsNull() && SYS_CredentialCodeRule._.TableName == tableName && SYS_CredentialCodeRule._.IsDeleted == 0);
            if (codeRuleInfo == null || codeRuleInfo.RuleID <= 0) throw new WarnException("单据编码规格未找到!");
            prefix = codeRuleInfo.Prefix.ToStringHasNull();
            suffix = codeRuleInfo.Suffix.ToStringHasNull();
            len = codeRuleInfo.Length.ToInt32();
            initValue = codeRuleInfo.InitialValue.ToInt32();
            #endregion
            #region 单号日期拆分
            string year = "", month = "", day = "";
            year = seedDate.Year.ToString();
            month = seedDate.Month.ToString().PadLeft(2, '0');
            day = seedDate.Day.ToString().PadLeft(2, '0');
            #endregion
            #region 前缀组合
            string[] arrSplit = prefix.Split('&');
            WhereClip whereClip = Sys_Seed._.TableName == tableName;
            bool existYearWhere = false, existMonthWhere = false, existDayWhere = false;
            foreach (string s in arrSplit)
            {
                if (s == "YYYY") { ret1 += year; existYearWhere = true; }
                else if (s == "YY") { ret1 += year.Substring(2); existYearWhere = true; }
                else if (s == "Y") { ret1 += year.Substring(3); existYearWhere = true; }
                else if (s == "MM") { ret1 += month; existMonthWhere = true; }
                else if (s == "M") { ret1 += month.Substring(1); existMonthWhere = true; }
                else if (s == "DD") { ret1 += day; existDayWhere = true; }
                else if (s == "D") { ret1 += day.Substring(1); existDayWhere = true; }
                else { ret1 += s; }
            }
            #endregion
            #region 后缀组合
            arrSplit = suffix.Split('&');
            foreach (string s in arrSplit)
            {
                if (s == "YYYY") { ret2 += year; existYearWhere = true; }
                else if (s == "YY") { ret2 += year.Substring(2); existYearWhere = true; }
                else if (s == "Y") { ret2 += year.Substring(3); existYearWhere = true; }
                else if (s == "MM") { ret2 += month; existMonthWhere = true; }
                else if (s == "M") { ret2 += month.Substring(1); existMonthWhere = true; }
                else if (s == "DD") { ret2 += day; existDayWhere = true; }
                else if (s == "D") { ret2 += day.Substring(1); existDayWhere = true; }
                else { ret2 += s; }
            }
            if (existYearWhere) whereClip = whereClip && Sys_Seed._.Year == year.ToInt32();
            if (existMonthWhere) whereClip = whereClip && Sys_Seed._.Month == month.ToInt32();
            if (existDayWhere) whereClip = whereClip && Sys_Seed._.Day == day.ToInt32();
            if (len - (ret2 + ret1).Length <= 0) throw new WarnException("单据编码规则定义的长度太短!");
            #endregion
            #region 插入种子记录
            whereClip = Sys_Seed._.TableName == tableName && Sys_Seed._.GCompanyID == this.SessionInfo.CompanyID;
            Guid? seedGuid = Guid.NewGuid();
            this.Insert<Sys_SeedResult>(new Sys_SeedResult()
            {
                TableName = tableName,
                Year = year.ToInt32(),
                Month = month.ToInt32(),
                Day = day.ToInt32(),
                SeedGuID = seedGuid,
                GCompanyID = this.SessionInfo.CompanyID
            });
            Sys_SeedResult addRst = this.Select<Sys_SeedResult>(new List<Field>() { Sys_Seed._.SeedID }
                        , Sys_Seed._.SeedGuID == seedGuid && Sys_Seed._.GCompanyID == this.SessionInfo.CompanyID);
            if (addRst.SeedID <= 0) throw new WarnException("编码规格定义表插入记录异常!");
            #endregion
            whereClip = whereClip && Sys_Seed._.SeedID <= addRst.SeedID;
            int countNum = this.Count<Sys_Seed>(whereClip);
            ret = ret1 + countNum.ToString().PadLeft(len - (ret1 + ret2).Length, '0') + ret2;
            return ret;
        }
        WhereClip GetWhereClip(SYS_CredentialCodeRuleParam param)
        {
            this.CheckSession();
            WhereClip where = SYS_CredentialCodeRule._.IsDeleted == 0;
            if (param.TableName != null) where = where && SYS_CredentialCodeRule._.TableName.Like("%" + param.TableName + "%");
            if (param.CredentialName != null) where = where && SYS_CredentialCodeRule._.CredentialName.Like("%" + param.CredentialName + "%");
            if (param.ModuleName != null) where = where && SYS_CredentialCodeRule._.ModuleName.Like("%" + param.ModuleName + "%");

            return where;
        }

        public PageList<SYS_CredentialCodeRuleResult> GetPageList(SYS_CredentialCodeRuleParam param)
        {
            this.CheckSession();
            PageList<SYS_CredentialCodeRuleResult> rst = new PageList<SYS_CredentialCodeRuleResult>();
            WhereClip where = GetWhereClip(param);
            List<Field> lstField = new List<Field>()
            {
                SYS_CredentialCodeRule._.RuleID,SYS_CredentialCodeRule._.GCompanyID,SYS_CredentialCodeRule._.CredentialName
                ,SYS_CredentialCodeRule._.IsOrderNo,SYS_CredentialCodeRule._.TableName,SYS_CredentialCodeRule._.CodeFieldName
                ,SYS_CredentialCodeRule._.Prefix,SYS_CredentialCodeRule._.Suffix,SYS_CredentialCodeRule._.InitialValue
                ,SYS_CredentialCodeRule._.IsContinuous,SYS_CredentialCodeRule._.Length,SYS_CredentialCodeRule._.IsManualInput
                ,SYS_CredentialCodeRule._.ModuleID,SYS_CredentialCodeRule._.ModuleName,SYS_CredentialCodeRule._.IsDeleted
            };
            rst = this.SelectList<SYS_CredentialCodeRuleResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(20), lstField, where, SYS_CredentialCodeRule._.TableName.Desc);
            return rst;
        }

        public SYS_CredentialCodeRuleResult GetInfo(SYS_CredentialCodeRuleParam param)
        {
            this.CheckSession();
            SYS_CredentialCodeRuleResult rst = new SYS_CredentialCodeRuleResult();
            #region 判断
            if (param.RuleID == null) throw new WarnException("请指定关键字GUID！");
            #endregion
            #region 保存实体
            WhereClip where = SYS_CredentialCodeRule._.RuleID == param.RuleID;
            rst = this.Select<SYS_CredentialCodeRuleResult>(where);
            #endregion
            return rst;
        }

        public WCFAddUpdateResult AddOrUpdate(SYS_CredentialCodeRuleResult param)
        {
            this.CheckSession();
            int affect = 0;
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (param.TableName.ToStringHasNull().Trim() == "") throw new WarnException("请指定表名！");
                if (param.CodeFieldName.ToStringHasNull().Trim() == "") throw new WarnException("请指定单据名称");
                if (param.CodeFieldName.ToStringHasNull().Trim() == "") throw new WarnException("请指定编号字段！");
                if (param.ModuleName.ToStringHasNull().Trim() == "") throw new WarnException("请指定模块名称！");
                if (param.RuleID > 0)
                {
                    WhereClip where = SYS_CredentialCodeRuleResult._.RuleID == param.RuleID;
                    affect = this.Update<SYS_CredentialCodeRuleResult>(param, where);
                    ret.Key = param.RuleID;
                }
                else
                {
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    affect = this.Insert<SYS_CredentialCodeRuleResult>(param);
                    ret.Key = this.Select<SYS_CredentialCodeRuleResult>(SYS_CredentialCodeRule._.TableName==param.TableName && SYS_CredentialCodeRule._.CodeFieldName==param.CodeFieldName && SYS_CredentialCodeRule._.IsDeleted==false).RuleID;
                }
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

        public WCFAddUpdateResult DelInfo(SYS_CredentialCodeRuleParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.RuleID == -1) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = SYS_CredentialCodeRuleResult._.RuleID == param.RuleID;
                SYS_CredentialCodeRuleResult oldInfo = this.GetInfo(param);
                SYS_CredentialCodeRuleResult info = new SYS_CredentialCodeRuleResult();
                info.IsDeleted = true;
                affect = this.Update<SYS_CredentialCodeRuleResult>(info, where);
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
