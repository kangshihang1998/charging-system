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
    public partial class ManIDcardno : Form
    {
        public ManIDcardno()
        {
            InitializeComponent();
        }

        private void ManIDcardno_Load(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBLL = new FactoryBLL();
            //调用查询管理者信息，业务层接口
            ManIDcardnoIBLL manibll = (ManIDcardnoIBLL)factBLL.CreateUser("ManIDcardnoBLL");
            //调用方法
            DataTable manidIfnoTable = manibll.SelectManIDInfo(UserLevel.UserIdall.ToString());
            //显示
            txtCardno.Text = manidIfnoTable.Rows[0][0].ToString();
            txtNumber.Text= manidIfnoTable.Rows[0][1].ToString();
            txtAge.Text= manidIfnoTable.Rows[0][3].ToString();
            cmbSex.Text= manidIfnoTable.Rows[0][2].ToString();
        }

        private void ManIDcardno_FormClosing(object sender, FormClosingEventArgs e)
        {
            OperatorMain.manidcardno = null;
            AdminMain.manidcardno = null;
        }
    }
}
