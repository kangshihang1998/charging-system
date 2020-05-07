using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using System.Windows.Forms;

namespace Factory
{
/// <summary>
/// 创建UI层窗体，通用工厂。
/// </summary>
  public  class FactoryUI
    {
        /// <summary>
        /// 创建窗体
        /// </summary>
        /// <param name="CreatFrom">窗体名称</param>
        /// <returns>一个窗体实例</returns>
        public Form CreatFrom(string CreatFrom)
        {
            #region 显示管理员窗体
            //获取配置文件
            string StrDB = System.Configuration.ConfigurationManager.AppSettings["UI"];
            string ClassName = StrDB + "." +CreatFrom;//具体要实例化的窗体
            return (Form)Assembly.Load(StrDB).CreateInstance(ClassName);
            #endregion
        }

    }
}
