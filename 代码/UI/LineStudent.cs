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
    public partial class LineStudent : Form
    {
        public LineStudent()
        {
            InitializeComponent();
        }

        private void LineStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LineStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void LineStudent_Load_1(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //调用上机记录业务接口和创建BLL层工厂，实例化BLL层类
            LineStudentIBLL LinStudentIBLL = (LineStudentIBLL)factBLL.CreateUser("LineStudentBLL");
            //获取上机记录
            string StrMsg = "";//接受返信息
            DataTable LineStudentTable = LinStudentIBLL.SelectLineStudent(UserLevel.UserIdall.ToString(), this, ref StrMsg);
            #region 显示数据到DataGridView上
            #region 创建表
            //创建表
            //for (int i = 0; i <= LineStudentTable.Rows.Count - 1; i++)// 增加行数
            //{
            //    int index = this.dataGridView1.Rows.Add();
            //    for (int j = 0; j <= LineStudentTable.Columns.Count - 1; j++)// 增加列数
            //    {
            //        dataGridView1.Rows[index].Cells[j].Value = ""; 
            //    }

            //}
            #endregion
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
            #endregion
            //提示,改变窗体标题栏内容
            this.Text = StrMsg;
        }

        private void LineStudent_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //改变窗体状态
            StudentMain.LineStudentForm = null;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToExcel.DatatoExcel(dataGridView2);
        }
    }
}
