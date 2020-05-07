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
    public partial class QueryCash : Form
    {
        public QueryCash()
        {
            InitializeComponent();
        }

        private void QueryCash_Load(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBll = new FactoryBLL();
            //调用查询余额的业务接口和实例化BLL层的工厂，实例化BLL层具体的类
            QueryCashIBLL querIBLL =(QueryCashIBLL) factBll.CreateUser("QueryCashBLL");
            txtCardno.Text = UserLevel.UserIdall.ToString();//给卡号赋值，把当前用户的全局变量赋值给卡号。
            //调用查询余额方法，获取当前用户余额
            string strMsg= querIBLL.SelectCash(txtCardno.Text,this);
            txtCash.Text = strMsg;//显示余额
        }

        private void QueryCash_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变余额窗体状态
            StudentMain.querycash = null;
        }
    }
}
