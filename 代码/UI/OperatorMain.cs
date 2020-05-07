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
    public partial class OperatorMain : Form
    {
        public OperatorMain()
        {
            InitializeComponent();
        }
        #region 单利模式
        public static ResutUserPwd ResuFrom = null;//修改密码
        public static RegistrationCardno RegisFrom = null;//注册卡号
        public static QueryOperton queryOpertion = null;//查询窗体
        public static Recharge recharge = null;//充值窗体
        public static StudentPwdOpertion studentpwdopertion = null;//重置学生密码
        public static ManIDcardno manidcardno = null;//管理者信息
        public static CancelCard cancelcar = null;//退卡
        #endregion
        private void OperatorMain_Load(object sender, EventArgs e)
        {
        
        }
        //实例化创建BLL层的工厂
        FactoryBLL factBll = new FactoryBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            //调用管理者退出接口和创建BLL层的工厂实例化BLL层管理者退出类 
            LoginOutMangerIBLL ManageIBLL = (LoginOutMangerIBLL)factBll.CreateUser("LoginOutMangerBLL");
            ManageIBLL.LoginOutManger(UserLevel.UserIdall.ToString());//管理者退出

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 将窗体变为最小化
            this.WindowState = FormWindowState.Minimized;
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void txtsond_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //判断修改密码窗体是否已经被实例化
            if (ResuFrom == null)
            {
                //如果ResuFrom等于空，就实例化
                ResuFrom = new ResutUserPwd();
                ResuFrom.Show();//显示修改密码窗体
            }//end if
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //判断注册窗体是否被实例化
            if (RegisFrom==null)
            {
                //如果等于空就实例化
                RegisFrom = new RegistrationCardno();
                RegisFrom.Show();//显示注册窗体
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //判断查询窗体是否被实例化
            if (queryOpertion == null)
            {
                //实例化查询窗体
                queryOpertion = new QueryOperton();
                queryOpertion.Show();//显示查询窗体
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //判断充值窗体是否被实例化
            if (recharge==null)
            {
                recharge = new Recharge();//实例化充值窗体
                recharge.Show();//显示充值窗体
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (studentpwdopertion == null)
            {
                studentpwdopertion = new StudentPwdOpertion();
                studentpwdopertion.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (manidcardno==null)
            {
                manidcardno = new ManIDcardno();
                manidcardno.Show();
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateCardIBLL activaIBLL = (ActivateCardIBLL)factBll.CreateUser("ActivateCardBLL");
           string str= activaIBLL.ActicateCardnoInfo(txtCardno.Text,this);
            MessageBox.Show(str);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cancelcar==null)
            {
                cancelcar = new CancelCard();
                cancelcar.Show();
            }
        }
    }
}
