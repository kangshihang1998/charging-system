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
    public partial class ResutUserPwd : Form
    {
        public ResutUserPwd()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBll = new FactoryBLL();
            //调用修改密码的业务员接口和创建BLL层的工厂创建BLL层修改密码类
            RestUserInfoPwdIBLL ResuUserIBLL =(RestUserInfoPwdIBLL) factBll.CreateUser("RestUserInfoPwdBLL");
           string StrMesg=ResuUserIBLL.RestUserPwd(UserLevel.UserIdall.ToString(),txtOldPwd.Text,txtNewPwd.Text,txtNewPwdOk.Text,this);//修改密码
            MessageBox.Show(StrMesg);

        }

        private void ResutUserPwd_Load(object sender, EventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
        }

        private void ResutUserPwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminMain.ResuFrom = null;//改变管理员修改密码状态
            OperatorMain.ResuFrom = null;//改变操作员修改密码状态
            StudentMain.ResuFrom = null;//改变学生修改密码状态
        }
    }
}
