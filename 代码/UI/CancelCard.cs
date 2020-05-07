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
    public partial class CancelCard : Form
    {
        public CancelCard()
        {
            InitializeComponent();
        }

        private void CancelCard_Load(object sender, EventArgs e)
        {
           
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBll = new FactoryBLL();
            CancelCardIBLL cancelCardnoIBLL = (CancelCardIBLL)factBll.CreateUser("CancelCardBLL");
            string str=  cancelCardnoIBLL.CancelCard(txtCardno.Text,this);
            label1.Text = str;
        }

        private void CancelCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            OperatorMain.cancelcar = null;
        }
    }
}
