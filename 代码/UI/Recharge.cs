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
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }

        private void Recharge_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBll = new FactoryBLL();
            //调用充值的业务接口，和创建BLL层的工厂实例化BLL层的具体类’
            RechargeIBLL RecarIBLL = (RechargeIBLL)factBll.CreateUser("RechargeBLL");
            //调用充值的方法
            string StrRecardno = RecarIBLL.Rechargebll(txtCardno.Text,this,txtCash.Text);
            MessageBox.Show(StrRecardno);//显示返回信息
        }

        private void Recharge_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变注册窗体状态
            UI.OperatorMain.recharge = null;
        }
    }
}
