using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
namespace Factory
{
/// <summary>
/// 创建业务层工厂
/// </summary>
 public   class FactoryBLL
    {

        //获取配置文件，要实例化的程序集名称。
        string StrDB = System.Configuration.ConfigurationManager.AppSettings["FU"];
        /// <summary>
        ///应用反射获得BLL层操作 。
        ///缺点：数据类型是死的，不同数据类型的工厂调用需要在调用处强制转换。
        /// </summary>
        /// <param name="CreatClassName">要实例化的类</param>
        /// <returns>BLL层类</returns>
        public object CreateUser(string CreatClassName)
        {
            //具体要实例化的类
            string ClassName = StrDB + "."+ CreatClassName;
            //利用反射返回要实例化的具体类
            return (object)Assembly.Load(StrDB).CreateInstance(ClassName);
        }
    }
}
