using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.Logic.Sys
{
    public   class SYS_CurrencyLogic:BaseLogic
    {
        public SYS_CurrencyLogic(Form form) : base(form) { }

        public Dictionary<string, decimal?> GetExchaneRateDic(DateTime? compareDate, string[] currencyCodes)
        {
            Dictionary<string, decimal?> exchaneRateDic = new Dictionary<string, decimal?>();
            compareDate = compareDate.ToDateTime().Date.Add(new TimeSpan(23, 59, 59));
            List<SYS_CurrencyResult> listRst = this.GetList(new SYS_CurrencyParam() { GetLastRate = true, RateDate = compareDate });
            decimal? exchangeRate = null;
            if (listRst != null && listRst.Count > 0)
            {
                if (currencyCodes == null) currencyCodes = listRst.Select(a => a.CurrencyCode).Distinct().ToArray();
                foreach (string currencyCode in currencyCodes)
                {
                    try
                    {//a.RateDate <= compareDate &&
                        exchangeRate = listRst.Where(a => a.CurrencyCode == currencyCode).OrderByDescending(a => a.RateDate).Select(a => a.ExchangeRate).FirstOrDefault();
                    }
                    catch
                    {
                        exchangeRate = null;
                    }
                    if (!exchaneRateDic.ContainsKey(currencyCode))
                        exchaneRateDic.Add(currencyCode, exchangeRate);
                }
            }
            return exchaneRateDic;
        
        }
        public decimal? GetExchangeRate(DateTime? compareDate,string currency)
        {
            compareDate= compareDate.ToDateTime().Date.Add(new TimeSpan(23, 59, 59));
            SYS_CurrencyParam param = new SYS_CurrencyParam() {GetLastRate = true, RateDate = compareDate, CurrencyCode = currency };
            List<SYS_CurrencyResult> listRst= this.GetList( param);
            decimal? exchangeRate = null;
            try
            {
                if (listRst!=null && listRst.Count>0)
                try
                {
                    exchangeRate = listRst.OrderByDescending(a => a.RateDate).Select(a => a.ExchangeRate).FirstOrDefault();
                }
                catch
                {
                    exchangeRate = null;
                }
            }
            catch ( WarnException exp)
            {
                
            }
            if (exchangeRate != null)
                return exchangeRate;
            else
                return null;
        }
        public List<SYS_CurrencyResult> GetList(SYS_CurrencyParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_CurrencyBLL", "GetList", param);
            List<SYS_CurrencyResult> list = new List<SYS_CurrencyResult>();
            list = (rst == null ? new List<SYS_CurrencyResult>() : rst.Result as List<SYS_CurrencyResult>);
            return list;
        }
        public WCFAddUpdateResult AddOrUpdate(SYS_CurrencyResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_CurrencyBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public SYS_CurrencyResult GetInfo(SYS_CurrencyParam param)
        {
            SYS_CurrencyResult ret = new SYS_CurrencyResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_CurrencyBLL", "GetInfo", param);
            ret = (rst == null ? new SYS_CurrencyResult() : rst.Result as SYS_CurrencyResult);
            return ret;
        }
      

        public WCFAddUpdateResult DelInfo(SYS_CurrencyParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_CurrencyBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
