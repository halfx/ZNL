using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Account;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.BLL.Account
{
    public class SYS_CompanyInfoBLL:BaseBLL
    {
        /// <summary>
        /// 获取收费记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public SYS_ChargeRecordResult GetChargeRecord(SYS_CompanyInfoParam param)
        {
            SYS_CompanyInfoResult ret = new SYS_CompanyInfoResult();
            SYS_ChargeRecordResult ret2 = new SYS_ChargeRecordResult();

            //正式版验证时需要排除平台用户相关的公司
            WhereClip whereClip = SYS_CompanyInfo._.CompanyName == param.CompanyName 
                                && SYS_CompanyInfo._.PartnerCode.IsNull()
                                && SYS_CompanyInfo._.IsActive != ZNLCRM.Utility.CommonEnum.IsActive.Deleted
                                && SYS_CompanyInfo._.IsDeleted==false;

            List<Field> companyFields = new List<Field>();
            companyFields.Add(SYS_CompanyInfo._.CompanyID);
            ret = this.Select<SYS_CompanyInfoResult>(companyFields, whereClip);
            if (ret == null)
                throw new WarnException("输入的公司名称不存在！");

            WhereClip whereClip2 = SYS_ChargeRecord._.CompanyID == ret.CompanyID
                                 && SYS_ChargeRecord._.IsActive != ZNLCRM.Utility.CommonEnum.IsActive.Deleted
                                 && SYS_ChargeRecord._.IsAudited == 1
                                 && SYS_ChargeRecord._.IsDeleted == false;

            List<Field> fields2 = new List<Field>();
            fields2.Add(SYS_ChargeRecord._.ChargeType);
            fields2.Add(SYS_ChargeRecord._.ChargeEndTime);

            OrderByClip orderBy = SYS_ChargeRecord._.ChargeEndTime.Desc;
            ret2 = this.Select<SYS_ChargeRecordResult>(fields2, whereClip2, orderBy);
            return ret2;
        }

        /// <summary>
        /// 获取公司信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public SYS_CompanyInfoResult GetCompanyInfo(SYS_CompanyInfoParam param)
        {
            SYS_CompanyInfoResult ret = new SYS_CompanyInfoResult();
            if (param.CompanyID == null)
            {
                throw new WarnException("请传入公司ID！");
            }
            ret = this.Select<SYS_CompanyInfoResult>(SYS_CompanyInfo._.CompanyID == param.CompanyID && SYS_CompanyInfo._.IsActive != 3);
            return ret;
        }
    }
}
