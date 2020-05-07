using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace UI
{
    /// <summary>
    /// 导出Excel表
    /// </summary>
 public static   class ToExcel
    {
        public static void DatatoExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)   //判断控件中是否有数据。
            {
                MessageBox.Show("没有数据");
                return;
            }
            Excel.Application excel = new Excel.Application();   //实例化
            excel.Application.Workbooks.Add(true);
            excel.Visible = true;

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;    //添加第一行的内容=表头
            }
            //导出数据为表格形式
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    #region 类型转换
                    //if (dgv[j, i].ValueType == typeof(string))   //判断控件中的内容的值是否是字符串类型的。
                    //{
                    //    excel.Cells[i + 2, j + 1] = "" + dgv[j, i].Value.ToString();  //把空件中对应行的内容添加到excel中，并进行数据类型的转换。                                                                                  //cells[i,j] 表示表中对应的行和列，i为行，j为列。
                    //}
                    //else
                    //{
                    //    excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                    //}
                    #endregion
                    try
                    {
                        excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                }

            }
        }
    }
}
