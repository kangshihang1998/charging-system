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
    public partial class LineStudentOpertion : Form
    {  
        public LineStudentOpertion()
        {
            InitializeComponent();
        }
        //储存输入的卡号，用于判断是否多次查询同一个卡号
        string oldCardno = "";
        private void button3_Click(object sender, EventArgs e)
        {
           
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //调用上机记录业务接口和创建BLL层工厂，实例化BLL层类
            LineStudentIBLL LinStudentIBLL = (LineStudentIBLL)factBLL.CreateUser("LineStudentBLL");
            //获取上机记录
            string StrMsg = "";//接受返信息
            DataTable LineStudentTable = LinStudentIBLL.SelectLineStudent(txtcardno.Text, this, ref StrMsg);
            #region 显示数据到DataGridView上
            //防止多次点击查询按钮显示相同内容
            if (txtcardno.Text == oldCardno)
            {
                MessageBox.Show("已经没有可查询信息！");
            }
            else
            {
                //创建表和填充数据
                for (int i = 0; i <= LineStudentTable.Rows.Count - 1; i++)//获取行数
                {
                    int index = this.dataGridView2.Rows.Add();//添加一行
                    for (int j = 0; j <= LineStudentTable.Columns.Count - 1; j++)//获取列数
                    {
                        //添加数据
                        dataGridView2.Rows[index].Cells[j].Value = LineStudentTable.Rows[i][j].ToString();
                    }

                }
            }//end if
            //给oldCardno赋值
            oldCardno = txtcardno.Text;
            #endregion
            //提示,改变窗体标题栏内容
            this.Text = StrMsg;
           
        }

        private void LineStudentOpertion_Load(object sender, EventArgs e)
        {

        }

        private void LineStudentOpertion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变学生上机记录窗体状态
            QueryOperton.lineStudentOperton = null;
        }

        private void txtcardno_TextChanged(object sender, EventArgs e)
       {
            //清除表内上次查询内容
            dataGridView2.Rows.Clear();
            //初始化储存输入的卡号变量
            oldCardno = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToExcel.DatatoExcel(dataGridView2);
        }
    }
}
