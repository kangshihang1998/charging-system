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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        #region 单利模式
        public static ResutUserPwd ResuFrom=null;//修改密码
        public static ManIDcardno manidcardno = null;//管理者信息
        public static BasitDate basit = null;//基础数据设定
        public static AddandDeleteUser addanddelete = null;//添加删除用户
        public static ReCheckDay check = null;//报表
        public static SettleAccounts stleAcounts = null;//结账
        #endregion
        //实例化创建BLL层的工厂
        FactoryBLL factBll = new FactoryBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            
            //调用管理者退出接口和创建BLL层的工厂实例化BLL层管理者退出类 
            LoginOutMangerIBLL ManageIBLL =(LoginOutMangerIBLL)factBll.CreateUser("LoginOutMangerBLL");
            ManageIBLL.LoginOutManger(UserLevel.UserIdall.ToString());//管理者退出
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // 将窗体变为最小化
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (stleAcounts==null)
            {
                stleAcounts = new SettleAccounts();
                stleAcounts.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //判断修改密码窗体是否已经被实例化
            if (ResuFrom == null)
            {
                //如果ResuFrom等于空，就实例化
                ResuFrom = new ResutUserPwd();
                ResuFrom.Show();//显示修改密码窗体
            }//end if
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (manidcardno == null)
            {
                manidcardno = new ManIDcardno();
                manidcardno.Show();
            }
        }
        string Manid = "";//记录上次显示的操作员ID
        private void OnWorkOpertion_Tick(object sender, EventArgs e)
        {
            //  this.ShowInTaskbar = false;//隐藏系统图标
           
            
             
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (basit==null)
            {
                basit = new BasitDate();
                basit.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (addanddelete==null)
            {
                addanddelete = new AddandDeleteUser();
                addanddelete.Show();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //显示正在值班的操作员
            OnManWorkIBLL onmanWorkIBLL = (OnManWorkIBLL)factBll.CreateUser("OnManWorkBLL");
            string Strmsg = "";//接受返回信息
            DataTable OnManWorkTable = onmanWorkIBLL.selectOnManWork("操作员", ref Strmsg);
            dateOpertion.Rows.Clear();//显示之前清楚上次显示数据
            #region 显示数据到DataGridView2上
            //创建表和填充数据
            for (int i = 0; i <= OnManWorkTable.Rows.Count - 1; i++)//获取行数
            {

                int index = this.dateOpertion.Rows.Add();//添加一行
                for (int j = 0; j <= OnManWorkTable.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dateOpertion.Rows[index].Cells[j].Value = OnManWorkTable.Rows[i][j].ToString();
                    //给ManID赋值,实时更新ManID的值。
                    Manid = OnManWorkTable.Rows[i][0].ToString();
                }



            }

            #endregion
            label12.Text = Strmsg;//显示提示信息！

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (check==null)
            {
                check = new ReCheckDay();
                check.Show();
            }
        }
    }
}
