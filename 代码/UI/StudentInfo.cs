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
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }
   
        private void StudentInfo_Load(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //调用查询学生信息业务层接口，和创建BLL层工厂创建具体的BLL层类
            StudentInfoIBLL studentIBLL = (StudentInfoIBLL)factBLL.CreateUser("StudentInfoBLL");
            //调用查询学生信息方法
            DataTable StudentTable = studentIBLL.StudentInfo(UserLevel.UserIdall);
            txtCardno.Text =StudentTable.Rows[0][0].ToString();//显示卡号
            txtName.Text= StudentTable.Rows[0][1].ToString();//姓名
            cmbSex.Text= StudentTable.Rows[0][2].ToString();//性别
            txtAge.Text= StudentTable.Rows[0][3].ToString();//年龄
            txtGrade.Text= StudentTable.Rows[0][7].ToString();//年级
            txtAddes.Text= StudentTable.Rows[0][6].ToString();//地址
            txtNumber.Text= StudentTable.Rows[0][4].ToString();//手机号
            txtWeixin.Text= StudentTable.Rows[0][5].ToString();//微信号
            

        }

        private void StudentInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变学生窗体状态
            StudentMain.studentinfo = null;
        }
    }
}
