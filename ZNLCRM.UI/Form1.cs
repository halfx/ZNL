using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLFrame.Entity;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.Logic.CRM;

namespace ZNLCRM.UI
{
    public partial class Form1 : frmBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        void TestLog()
        {
            //ZNLCRM.Utility.LogHandler.WriteDebug(MethodBase.GetCurrentMethod().DeclaringType, "testksdlfjlsfjsldfjdsl", new Exception("this is test debug"));
            List<ZNLCRM.Controls.UcBlockList.UcBlockListInfo> lstData = new List<Controls.UcBlockList.UcBlockListInfo>();
            lstData.Add(new Controls.UcBlockList.UcBlockListInfo()
            {
                LinkName = "查看",
                TaskDesc = "客户自定义颜色表示",
                TaskID = "1"
            });
            lstData.Add(new Controls.UcBlockList.UcBlockListInfo()
            {
                LinkName = "查看",
                TaskDesc = "客户自定义颜色表示",
                TaskID = "2"
            });
            lstData.Add(new Controls.UcBlockList.UcBlockListInfo()
            {
                LinkName = "查看",
                TaskDesc = "客户自定义颜色表示",
                TaskID = "3"
            });
            this.ucBlockList1.SetDataSource(lstData);
            this.ucBlockList1.BlockLinkClick += delegate(string key)
            {
                MessageBox.Show(key);
            };
            this.ucBlockList1.BlockMoreClick += delegate()
            {
                MessageBox.Show("kdskfjldsfjajdfkl;saflk");
            };
            this.ucBlockList1.TitleText = "待审批列表";
            this.ucBlockList2.TitleText = "已审批列表";
            this.ucBlockList2.SetDataSource(lstData);
            this.ucBlockList2.BlockLinkClick += delegate(string key)
            {
                MessageBox.Show(key);
            };
            this.ucBlockList2.BlockMoreClick += delegate()
            {
                MessageBox.Show("kdskfjldsfjajdfkl;saflk");
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowMessage("1.很遗憾的说：Windows7不自带SMTP服务器http://stackoverflow.com/questions/1120132/smtp-not-working-in-windows-7");
            //TestLog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime? dtaNow= ZNLCRM.Client.Entry.WCFBLL.GetServerTime();
            this.ShowMessage(dtaNow.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRM_CompanyLogic logic = new CRM_CompanyLogic(this);
            CRM_CompanyParam param=new CRM_CompanyParam();
            PageList<CRM_CompanyResult> rst = logic.GetCustPageList(param);
            this.ShowMessage(rst.TotalCount.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
