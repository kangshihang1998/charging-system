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
    public partial class QueryOperton : Form
    {
        public QueryOperton()
        {
            InitializeComponent();
        }
        #region 单利模式
        public static LineStudentOpertion lineStudentOperton = null;//查看学生上机记录
        public static QueryCashOpertion quercashopertion = null;//查询余额
        public static SelectRechargeOpertion selectrecharge = null;//查询充值记录
        public static returnCash returnCash = null;//金额返还查询
        public static RechargeCash rechargCash = null;//收取金额查询
        public static GrouOperWokr groupWork = null;//操作员工作记录
        public static GroupStudentOnLineSum groupStudentLine = null;//学生上机统计
        #endregion
        //实例化创建BLL层的工厂
        FactoryBLL factBll = new FactoryBLL();
        private void QueryOperton_Load(object sender, EventArgs e)
        {
            dataOnLineStudent.Visible = true;//可见
            label4.Visible = true;
            string StrMsg = "";
            DataTable SelectonLineStudentTable = SelectOnLineStudent(out StrMsg);
            #region 显示数据到DataGridView2上
            //先清楚上次记录
            dataOnLineStudent.Rows.Clear();
            //创建表和填充数据
            for (int i = 0; i <= SelectonLineStudentTable.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dataOnLineStudent.Rows.Add();//添加一行
                for (int j = 0; j <= SelectonLineStudentTable.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dataOnLineStudent.Rows[index].Cells[j].Value = SelectonLineStudentTable.Rows[i][j].ToString();
                }

            }
            #endregion
            this.Text = StrMsg;
            全部下机ToolStripMenuItem.Visible = true;

        }
        /// <summary>
        /// 查询正在上机学生
        /// </summary>
        /// <returns>以表形式返回，正在上机学生信息</returns>
        private DataTable SelectOnLineStudent(out string StrMsg)
        {
            OnLineStudentIBLL onlinestudentIBLL = (OnLineStudentIBLL)factBll.CreateUser("OnLineStudentBLL");
            DataTable SelectOnLineStudentTable = onlinestudentIBLL.SelectOnlineStudent(out StrMsg);
            return SelectOnLineStudentTable;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtStudent_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ggdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断学生查询余额窗体是否已经被实例化
            if (quercashopertion == null)
            {
                quercashopertion = new QueryCashOpertion();//实例化查询余额窗体
                quercashopertion.Show();//显示窗体
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void QueryOperton_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变查询窗体状态
            OperatorMain.queryOpertion = null;
        }

        private void 学生查看上机记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断学生上机记录是否被实例化
            if (lineStudentOperton==null)
            {
                //实例化学生上机记录
                lineStudentOperton = new LineStudentOpertion();
                lineStudentOperton.Show();//显示学生上机记录
            }
        }

        private void 学生充值查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断充值记录窗体是否被实例化
            if (selectrecharge==null)
            {
                selectrecharge = new SelectRechargeOpertion();
                selectrecharge.Show();
            }
        }

        private void 金额返还查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (returnCash==null)
            {
                returnCash = new returnCash();
                returnCash.Show();
            }
        }

        private void 收取金额查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rechargCash==null)
            {
                rechargCash = new RechargeCash();
                rechargCash.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            dataOnLineStudent.Visible = false;//不可见
            label4.Visible =false;
            全部下机ToolStripMenuItem.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void 全部下机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLineStudentIBLL onlinestudentIBLL = (OnLineStudentIBLL)factBll.CreateUser("OnLineStudentBLL");
           string StrMsg= onlinestudentIBLL.LoginOutAllStudent();
            //清楚表内记录
            dataOnLineStudent.Rows.Clear();
            MessageBox.Show(StrMsg);
        }

        private void 指定学生下机ToolStripMenuItem_Click(object sender, EventArgs e)
        {       
                
              //获取下机学生卡号
                string StudedntCardno = dataOnLineStudent.CurrentCell.Value.ToString();
                OnLineStudentIBLL onlinestudentIBLL = (OnLineStudentIBLL)factBll.CreateUser("OnLineStudentBLL");
                string StrMsg = onlinestudentIBLL.LoginOutAssignStudent(StudedntCardno);//调用指定下机方法
                if (StrMsg== "下机成功！")
                {
                    //清空记录                                                                        //清楚表内记录
                    dataOnLineStudent.Rows.Clear();
                } 
               
                MessageBox.Show(StrMsg);
          
            
           
        }

        private void 操作员工作记录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (groupWork==null)
            {
                groupWork = new GrouOperWokr();
                groupWork.Show();//现场窗体
            }
        }

        private void 学生上机统计记录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (groupStudentLine==null)
            {
                groupStudentLine = new GroupStudentOnLineSum();
                groupStudentLine.Show();
            }
        }
    }
}
