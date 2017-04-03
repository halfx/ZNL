using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Utility;

namespace ZNLCRM.UI
{
    public partial class frmTool : Form
    {
        public frmTool()
        {
            InitializeComponent();
        }

        private void btnEncrypPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                txtEncrypPassword.Text = EncrypHandler.Encrypto(txtPassword.Text.Trim());
            }
        }

        private void ucButton1_Click(object sender, EventArgs e)
        {
           // ucTextBox1.Text = DateTime.Now.ToString("yyyyMMddhhmmssms");
           //当天起始
            //ucTextBox1.Text= DateTime.Now.Date.ToStringHasNull();
            //ucTextBox1.Text = DateTime.Now.Date.Add(new TimeSpan(23,59,59)).ToStringHasNull();
            DateTime dt=DateTime.Now;
            //本周一
            DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d"))).Date;
            //本周日
            DateTime endWeek = startWeek.AddDays(6);
            DateTime startMonth = dt.AddDays(1 - dt.Day);  //本月月初  
            DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);  //本月月末  
           // ucTextBox1.Text = startMonth.Date.ToStringHasNull();
            //endWeek.Add(new TimeSpan(23, 59, 59)).ToStringHasNull();
            DateTime startQuarter = dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day);  //本季度初  
            DateTime endQuarter = startQuarter.AddMonths(3).AddDays(-1);  //本季度末  
            ucTextBox1.Text = startQuarter.Date.ToStringHasNull();
            
        }

        private void frmTool_Load(object sender, EventArgs e)
        {
             ucDateTimeInput1.Text= DateTime.Now.ToString();
             
        }
    }
}
