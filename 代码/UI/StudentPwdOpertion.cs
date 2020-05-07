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
    public partial class StudentPwdOpertion : Form
    {
        public StudentPwdOpertion()
        {
            InitializeComponent();
        }

        private void StudentPwdOpertion_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //调用重置学生密码业务层接口和创建BLL层工厂创建具体的BLL层类
            StudentPwdOpertionIBLL studentpwdIBLL = (StudentPwdOpertionIBLL)factBLL.CreateUser("StudentPwdOpertionBLL");
            //调用具体的修改方法
            string StrMsg = studentpwdIBLL.StudentPwdOpertion(txtCardno.Text,txtNewPwd.Text,txtNewPwdOk.Text,this);
            MessageBox.Show(StrMsg);//提示信息
        }

        private void StudentPwdOpertion_FormClosing(object sender, FormClosingEventArgs e)
        {
            UI.OperatorMain.studentpwdopertion = null;
        }
    }
}
