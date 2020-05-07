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
    public partial class SelectRechargeOpertion : Form
    {
        public SelectRechargeOpertion()
        {
            InitializeComponent();
        }

        private void SelectRechargeOpertion_Load(object sender, EventArgs e)
        {

        }
        string oldCardno = "";//储存上次输入的卡号
        private void button3_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //调用查询充值记录业务层接口，和创建BLL层的工厂创建具体的BLL层类
            SelectRechargeIBLL selectRecharIBLL = (SelectRechargeIBLL)factBLL.CreateUser("SelectRechargeBLL");
            //接受返回的信息
            string Strmsg = "";
            //调用查询充值记录的方法
            DataTable SelectRecharTable = selectRecharIBLL.Selectrechar(txtCardno.Text, this, ref Strmsg);
            //显示数据
            #region 显示数据到DataGridView上
            //防止多次点击查询按钮显示相同内容
            if (txtCardno.Text == oldCardno)
            {
                MessageBox.Show("已经没有可查询信息！");
            }
            else
            {
                //创建表和填充数据
                for (int i = 0; i <= SelectRecharTable.Rows.Count - 1; i++)//获取行数
                {
                    int index = this.dataGridView2.Rows.Add();//添加一行
                    for (int j = 0; j <= SelectRecharTable.Columns.Count - 1; j++)//获取列数
                    {
                        //添加数据
                        dataGridView2.Rows[index].Cells[j].Value = SelectRecharTable.Rows[i][j].ToString();
                    }//end for

                }//end for
            }//end if
            //给oldCardno赋值
            oldCardno =txtCardno.Text;
            #endregion
            this.Text = Strmsg;
        }

        private void SelectRechargeOpertion_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentMain.selectrecharfe = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToExcel.DatatoExcel(dataGridView2);
        }
    }
}
