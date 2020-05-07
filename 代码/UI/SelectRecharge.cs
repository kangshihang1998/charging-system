using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enitity;
using IBLL;
using Factory;
namespace UI
{
    public partial class SelectRecharge : Form
    {
        public SelectRecharge()
        {
            InitializeComponent();
        }

        private void SelectRecharge_Load(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //调用查询充值记录业务层接口，和创建BLL层的工厂创建具体的BLL层类
            SelectRechargeIBLL selectRecharIBLL = (SelectRechargeIBLL)factBLL.CreateUser("SelectRechargeBLL");
            //接受返回的信息
            string Strmsg = "";
            //调用查询充值记录的方法
            DataTable SelectRecharTable = selectRecharIBLL.Selectrechar(UserLevel.UserIdall.ToString(),this,ref Strmsg);
            //显示数据
            #region 显示数据到DataGridView2上
            //创建表和填充数据
            for (int i = 0; i <= SelectRecharTable.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dataGridView2.Rows.Add();//添加一行
                for (int j = 0; j <= SelectRecharTable.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dataGridView2.Rows[index].Cells[j].Value = SelectRecharTable.Rows[i][j].ToString();
                }

            }
            #endregion
            this.Text = Strmsg;
        }

        private void SelectRecharge_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变查询充值记录窗体状态
            StudentMain.selectrecharfe = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToExcel.DatatoExcel(dataGridView2);
        }
    }
}
