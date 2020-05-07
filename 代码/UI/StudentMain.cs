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
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
        }
        #region 单利模式
        public static ResutUserPwd ResuFrom = null;//修改密码
        public static LineStudent LineStudentForm = null;//上机记录
        public static QueryCash querycash = null;//查询余额
        public static SelectRecharge selectrecharfe = null;//查询充值记录
        public static StudentInfo studentinfo = null;//学生信息
        #endregion
        //获取学生信息
        DataTable StudentInfoTable = new DataTable();
        //在线时间
        DateTime TimeSolt =new DateTime();
        DateTime LoginTime =new DateTime();//上机时间
        DateTime LogOutTime=new DateTime();//下机时间
        //实例化创建BLL层的工厂
        FactoryBLL factBll = new FactoryBLL();
        private void StudentMain_Load(object sender, EventArgs e)
        {
            //获取学生信息
            StudentInfoIBLL studentInfo =(StudentInfoIBLL) factBll.CreateUser("StudentInfoBLL");
            StudentInfoTable = studentInfo.StudentInfo(UserLevel.UserIdall);
            lblName.Text = StudentInfoTable.Rows[0][1].ToString();//显示学生姓名  
            OnLimeTime.Enabled = true;//启用闹钟 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void StudentMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //调用学生下机接口，使用工厂创建BLL层类。
            LoginOutStudentIBLL LogtOUtStuIBLL = (LoginOutStudentIBLL)factBll.CreateUser("LoginOutStudentBLL");
            //传入卡号和姓名
            LogtOUtStuIBLL.LoginOutStudent(UserLevel.UserIdall.ToString(), StudentInfoTable.Rows[0][1].ToString());//下机
            this.Hide();//隐藏本窗体
        }

        private void OnLimeTime_Tick(object sender, EventArgs e)
        {
            //调用上机状态查询接口和工厂创建上机状态查询业务类
            StudentOnLineStateIBLL studentonleStateIBLL = (StudentOnLineStateIBLL)factBll.CreateUser("StudentOnLineStateBLL");
            studentonleStateIBLL.StudnetOnLineState(UserLevel.UserIdall.ToString(),this);
        }

        private void butSond_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            

        }

        private void label11_DoubleClick(object sender, EventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void butSond_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // 将窗体变为最小化
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //判断修改密码窗体是否已经被实例化
            if (ResuFrom == null)
            {
                //如果ResuFrom等于空，就实例化
                ResuFrom = new ResutUserPwd();
                ResuFrom.Show();//显示修改密码窗体
            }//end if
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
             
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //判断上机记录窗体是否已经被实例化
            if (LineStudentForm==null)
            {
                LineStudentForm = new LineStudent(); //实例化上机记录窗体
                LineStudentForm.Show(); //显示窗体
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //判断查询余额窗体是否被实例化
            if (querycash==null)
            {
                querycash = new QueryCash();//实例化余额窗体
                querycash.Show();//显示余额窗体
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //判断充值记录窗体是否被实例化
            if (selectrecharfe==null)
            {
                selectrecharfe = new SelectRecharge();//实例化充值记录窗体
                selectrecharfe.Show();//显示充值记录窗体
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //判断学生信息窗体是否被实例化
            if (studentinfo==null)
            {
                studentinfo = new StudentInfo();//实例化学生信息窗体
                studentinfo.Show();//显示学生信息窗体
            }
        }
    }
}
