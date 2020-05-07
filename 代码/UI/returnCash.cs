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
    public partial class returnCash : Form
    {
        public returnCash()
        {
            InitializeComponent();
        }

        private void returnCash_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            returnCashIBLL retuIBLL = (returnCashIBLL)factBLL.CreateUser("returnCashBLL");
            string Strmsg = "";//接受返回信息
            DataTable retuTable = retuIBLL.SelectCardnoCash(dataStart.Text,dataEnd.Text,ref Strmsg);//接受返回的信息
            #region 显示数据到DataGridView2上
            //创建表和填充数据
            for (int i = 0; i <= retuTable.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dataGridView2.Rows.Add();//添加一行
                for (int j = 0; j <= retuTable.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dataGridView2.Rows[index].Cells[j].Value = retuTable.Rows[i][j].ToString();
                }

            }
            #endregion
            this.Text = Strmsg;//改变窗体标题栏
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnCash_FormClosing(object sender, FormClosingEventArgs e)
        {
            QueryOperton.returnCash = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToExcel.DatatoExcel(dataGridView2); 
        }
    }
}
