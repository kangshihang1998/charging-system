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
    public partial class QueryCashOpertion : Form
    {
        public QueryCashOpertion()
        {
            InitializeComponent();
        }

        private void QueryCashOpertion_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBll = new FactoryBLL();
            //调用查询余额的业务接口和实例化BLL层的工厂，实例化BLL层具体的类
            QueryCashIBLL querIBLL = (QueryCashIBLL)factBll.CreateUser("QueryCashBLL");
            //调用查询余额方法，获取当前用户余额
            string strMsg = querIBLL.SelectCash(txtCardno.Text, this);
            txtCash.Text = strMsg;//显示余额
        }

        private void QueryCashOpertion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变查询余额窗体状态
            QueryOperton.quercashopertion = null;
        }
    }
}
