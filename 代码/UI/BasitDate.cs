using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBLL;
using Factory;
using Enitity;
namespace UI
{
    public partial class BasitDate : Form
    {
        public BasitDate()
        {
            InitializeComponent();
        }
        //实例化创建BLL层的工厂
        FactoryBLL factBll = new FactoryBLL();
        private void BasitDate_Load(object sender, EventArgs e)
        {
            BasitDateIBLL basitIBLL = (BasitDateIBLL)factBll.CreateUser("BasitDateBLL");
            string Strmsg="";//接受返回的提示信息
            DataTable SelectBasitTable = basitIBLL.SelectBasitInfo(out Strmsg);
            if (SelectBasitTable.Rows.Count!=0)
            {
                txtLimeOnCash.Text = SelectBasitTable.Rows[0][0].ToString();
                txtLimtRegCash.Text = SelectBasitTable.Rows[0][1].ToString();
                txtPreOnCash.Text = SelectBasitTable.Rows[0][2].ToString();
                txtFixtCash.Text = SelectBasitTable.Rows[0][3].ToString();
                txtTimeCash.Text = SelectBasitTable.Rows[0][4].ToString();
                txtge.Text = SelectBasitTable.Rows[0][5].ToString();
                label6.Text = SelectBasitTable.Rows[0][6].ToString();
                lblDate.Text = SelectBasitTable.Rows[0][7].ToString();
                lblTime.Text = SelectBasitTable.Rows[0][8].ToString();
            }
            this.Text = Strmsg;//改变标题状态
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //文本框改为可用
            txtLimeOnCash.Enabled = true;
            txtLimtRegCash.Enabled = true;
            txtPreOnCash.Enabled = true;
            txtFixtCash.Enabled = true;
            txtTimeCash.Enabled = true;
            txtge.Enabled = true;
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //文本框改为可用
            txtLimeOnCash.Enabled = false ;
            txtLimtRegCash.Enabled = false;
            txtPreOnCash.Enabled = false;
            txtFixtCash.Enabled = false;
            txtTimeCash.Enabled = false;
            txtge.Enabled = false;
            
            MessageBox.Show("已取消修改！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasitDateIBLL basitIBLL = (BasitDateIBLL)factBll.CreateUser("BasitDateBLL");
            string Date = DateTime.Now.Date.ToString();//日期
            string Time = DateTime.Now.ToShortTimeString();//时间
            string Strmsg = basitIBLL.InsertBaistInfo(txtLimeOnCash.Text,txtLimtRegCash.Text,txtPreOnCash.Text,txtFixtCash.Text,txtTimeCash.Text,txtge.Text,UserLevel.UserIdall.ToString(),Date,Time,this);
            this.Text = Strmsg;

        }

        private void BasitDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminMain.basit = null;
        }
    }
}
