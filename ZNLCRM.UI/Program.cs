using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZNLCRM.UI.HR;
using ZNLCRM.UI.SYS;
using ZNLCRM.UI.CRM;
using ZNLCRM.UI.FIN;
using ZNLCRM.UI.SPM;
using ZNLCRM.UI.PPM;
using ZNLCRM.UI.STK;

namespace ZNLCRM.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("./log4net.xml"));

            Application.Run(new frmLogin());//new ZNLCRM.UI.HR.frmJobEdit("日报",null)
            //Application.Run(new ZNLCRM.UI.HR.frmJobManage());
        }
    }
}
