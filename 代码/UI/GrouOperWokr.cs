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
    public partial class GrouOperWokr : Form
    {
        public GrouOperWokr()
        {
            InitializeComponent();
        }
        //实例化创建BLL层的工厂
        FactoryBLL factBLL = new FactoryBLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 字段
            //字段
            combFile1.Items.Add("ID");
            combFile1.Items.Add("姓名");
            combFile1.Items.Add("登录日期");
            combFile1.Items.Add("退出日期");
            combFile1.Items.Add("电脑名称");

            combFile2.Items.Add("ID");
            combFile2.Items.Add("姓名");
            combFile2.Items.Add("登录日期");
            combFile2.Items.Add("退出日期");
            combFile2.Items.Add("电脑名称");

            combFile3.Items.Add("ID");
            combFile3.Items.Add("姓名");
            combFile3.Items.Add("登录日期");
            combFile3.Items.Add("退出日期");
            combFile3.Items.Add("电脑名称");
            #endregion
            #region 操作符
            combOper1.Items.Add(">");
            combOper1.Items.Add("=");
            combOper1.Items.Add("<");
            
            combOper2.Items.Add(">");
            combOper2.Items.Add("=");
            combOper2.Items.Add("<");

            combOper3.Items.Add(">");
            combOper3.Items.Add("=");
            combOper3.Items.Add("<");
            #endregion
            #region 组合关系
            combRel1.Items.Add("and");
            combRel1.Items.Add("or");
            combRel2.Items.Add("and");
            combRel2.Items.Add("or");
            #endregion

        }
        /// <summary>
        /// 显示具体内容
        /// </summary>
        /// <param name="comf1">字段1</param>
        /// <param name="comf2">字段2</param>
        /// <param name="comf3">字段3</param>
        /// <param name="comoper1">操作符1</param>
        /// <param name="comoper2">操作符2</param>
        /// <param name="comoper3">操作符3</param>
        /// <param name="contetn1">内容1</param>
        /// <param name="content2">内容2</param>
        /// <param name="contetn3">内容3</param>
        /// <param name="rel1">组合关系1</param>
        /// <param name="rel2">组合关系2</param>
        /// <param name="form">组合查询窗体</param>
        /// <returns></returns>
        protected  DataTable ToDgv(string comf1, string comf2, string comf3, string comoper1, string comoper2, string comoper3, string contetn1, string content2, string contetn3, string rel1, string rel2, string DbName, Form form)
        {
            GroupQuerIBLL groupQuerIBLL = (GroupQuerIBLL)factBLL.CreateUser("GroupQuerBLL");
            DataTable dt = groupQuerIBLL.SelectGroupQuer(ToEnglish(comf1), ToEnglish(comf2), ToEnglish(comf3), comoper1, comoper2, comoper3, contetn1, content2, contetn3, rel1, rel2, DbName, this);
            return dt;
        }
        /// <summary>
        /// 将汉字转换成数据库识别的字段
        /// </summary>
        /// <param name="combo">要转换的字段</param>
        /// <returns>转换后的结果</returns>
        public  string ToEnglish(string combo)
        {

            switch (combo)
            {
                case "ID":
                    return "ManID";
                case "登录日期":
                    return "OnDate";
                case "退出日期":
                    return "UpDate";
                case "电脑名称":
                    return "Computer";
                case "姓名":
                    return "ManName";
                default:
                    return "";
            }//end switch
        }
        /// <summary>
        /// 数据库名字
        /// </summary>
        /// <returns>具体的数据库</returns>
        protected  string GetDbName()
        {
            return "OpertionWork";
        }
        
     
        private void query_Click(object sender, EventArgs e)
        {
           
          DataTable dt=ToDgv(combFile1.Text,combFile2.Text,combFile3.Text,combOper1.Text,combOper2.Text,combOper3.Text,txtCont1.Text,txtCont2.Text,txtCont3.Text,combRel1.Text,combRel2.Text, GetDbName(), this);
            dateViConten.Rows.Clear();//显示数据之前先清除上次内容
            #region 显示数据到DataGridView2上
            //创建表和填充数据
            for (int i = 0; i <= dt.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dateViConten.Rows.Add();//添加一行
                for (int j = 0; j <= dt.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dateViConten.Rows[index].Cells[j].Value = dt.Rows[i][j].ToString();
                }

            }
            #endregion
        }

        private void GrouOperWokr_FormClosing(object sender, FormClosingEventArgs e)
        {
            QueryOperton.groupWork = null;
        }

        private void toExcel_Click(object sender, EventArgs e)
        {
            ToExcel.DatatoExcel(dateViConten);
        }

        private void clare_Click(object sender, EventArgs e)
        {
            dateViConten.Rows.Clear();//清空表格内容
            //字段
            combFile1.Text = "";
            combFile2.Text = "";
            combFile3.Text = "";
            //操作符
            combOper1.Text = "";
            combOper2.Text = "";
            combOper3.Text = "";
            //内容
            txtCont1.Text = "";
            txtCont2.Text = "";
            txtCont3.Text = "";
            //组合关系
            combRel1.Text = "";
            combRel2.Text = "";
        }
    }
}
