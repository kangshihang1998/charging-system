using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ReCheckDay : Form
    {
        public ReCheckDay()
        {
            InitializeComponent();
        }

        private void ReCheckDay_Load(object sender, EventArgs e)
        {
            
            label1.Text = DateTime.Now.Date.ToString();
            // TODO: 这行代码将数据加载到表“DataSet1.Recheck”中。您可以根据需要移动或删除它。
            this.RecheckTableAdapter.Fill(this.DataSet1.Recheck,label1.Text);

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
         
        }

        private void OK_Click(object sender, EventArgs e)
        {
            label5.Visible=true;
            label1.Visible = false;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            dateStart.Visible = true;
            dateEnd.Visible = true;
            reportViewer1.Visible = false;//隐藏日报表
            reportViewer2.Visible = true;//显示周报表
            this.Text = "周报表";
            this.reportViewer2.RefreshReport();
            // TODO: 这行代码将数据加载到表“DataSet2.RechecWeek”中。您可以根据需要移动或删除它。
            this.RechecWeekTableAdapter.Fill(this.DataSet2.RechecWeek,DateTime.Parse(dateStart.Text).ToString(),DateTime.Parse(dateEnd.Text).ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label5.Visible = false; 
            label1.Visible = true;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            dateStart.Visible = false;
            dateEnd.Visible = false;
            reportViewer1.Visible = true;//显示日报表
            reportViewer2.Visible = false;//隐藏周报表
            this.Text = "日报表";
            this.reportViewer1.RefreshReport();
        }

        private void ReCheckDay_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminMain.check = null;
        }
    }
}
