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
    
    public partial class LoginUser : Form
    {
       
        public LoginUser()
        {
           InitializeComponent();
        }
         
        private void LoginUser_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //使用工厂创建登录接口
            LoginIBLL LoginIbll = (LoginIBLL)factBLL.CreateUser("LoginBLL");
            //登录
            string strMsg =LoginIbll.loginFacade(txtUserName.Text, txtUserPwd.Text, this);
            MessageBox.Show(strMsg);
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
          //问题 ：给全局变量赋值如果是空的会报错----未解决
            //UserLevel.UserIdall = int.Parse(txtUserName.Text);//给全局变量赋值
        }
      
    }
}
