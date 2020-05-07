using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using Factory;
using IDAL;
using IBLL;
using System.Data;
using System.Windows.Forms;
namespace BLL
{
    /// <summary>
    /// 添加删除用户业务层
    /// </summary>
    public class AddandDeleteUserBLL : AddandDeleteUserIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="UserID">用户DI</param>
        /// <param name="UserLevel">用户级别</param>
        /// <param name="UserPwd">用户密码</param>
        /// <param name="UserName">用户姓名</param>
        /// <param name="State">使用状态</param>
        /// <param name="PhonNumber">手机号</param>
        /// <param name="Sex">性别</param>
        /// <param name="Age">年龄</param>
        /// <param name="form">添加删除窗体</param>
        /// <returns>是否添加成功！</returns>
        public string AddUserManInfo(string UserID, string UserLevel, string UserPwd, string UserName, string State, string PhonNumber, string Sex, string Age, Form form)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受判断用户id和年龄是否是数字
            bool isNumberUserID = IsNull.IsNumber(UserID);
            bool isNumberAge = IsNull.IsNumber(Age);
            //判断文本框是否为空
            if (isNull=="")//没有返回值，说明文本框不为空。
            {
                #region 添加用户
                //判断年龄和管理者id是否为数字
                if (isNumberUserID==true && isNumberAge==true)//如果都是true，说明都是数字。
                {
                    //调用添加删除用户接口，和创建DAL层工厂实例化具体的DAL层类
                    AddandDeleteUserIDAL addanddeleteIDAL = (AddandDeleteUserIDAL)fact.CreateUser("AddandDeleteUserDAL");
                    //转换为实体
                    Managerial manager = new Managerial();
                    manager.ManId = int.Parse(UserID);
                    DataTable SelectManagerTable = addanddeleteIDAL.SelectManagerial(manager);//获取管理者信息
                    //判断用户是否已经存在
                    if (SelectManagerTable.Rows.Count!=0)//不等于零，说明已经存在
                    {
                        strMsger = "此管理者已存在，请从新输入！";
                    }
                    else
                    {
                        
                        UserLevel ManLevel = new Enitity.UserLevel();
                        ManLevel.UserID = int.Parse(UserID);
                        DataTable SelectLevel = addanddeleteIDAL.SelectUserLevel(ManLevel);
                        //判断是否和卡号冲突
                        if (SelectLevel.Rows.Count==0)//等于零说明不冲突
                        {
                            #region 添加管理者
                            //向登录表插入信息
                            UserLevel user = new Enitity.UserLevel();
                            user.UserID = int.Parse(UserID);
                            user.Userlevel = UserLevel;
                            user.UserPwd = UserPwd;
                            addanddeleteIDAL.InsertUserLogin(user);
                            //向管理者插入信息
                            manager.Level = UserLevel;
                            manager.Name = UserName;
                            manager.State = State;
                            addanddeleteIDAL.InsertManagerial(manager);
                            //向管理者身份信息插入信息
                            ManIDcardno manidcardno = new ManIDcardno();
                            manidcardno.Manid = int.Parse(UserID);
                            manidcardno.Age = int.Parse(Age);
                            manidcardno.PhoneNumber = PhonNumber;
                            manidcardno.Sex = Sex;
                            addanddeleteIDAL.InsertManIDcardno(manidcardno);
                            #endregion
                            strMsger = "用户添加成功！";
                        }
                        else
                        {
                            strMsger = "管理者与卡号冲突，请从新输入！";
                        }
                       
                    }
                }
                else
                {
                    strMsger = "用户ID或者年龄不是数字，请输入数字！";
                }
                #endregion
            }
            else
            {
                strMsger = isNull;
            }
            return strMsger;
        }
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="form">添加删除窗体</param>
        /// <returns></returns>
        public string DeleteUserManInfo(string UserID)
        {
            //用于返回信息
            string strMsger = "";
            //接受判断用户id和年龄是否是数字
            bool isNumberUserID = IsNull.IsNumber(UserID);
            //判断UserID是否为空
            if (UserID.Trim()=="")//说明UserID为空
            {
                strMsger = "用户ID不能为空！";
            }
            else
            {
                //判断userid是否是数字
                if (isNumberUserID==true)//是数字
                {
                    #region 删除用户
                    //调用添加删除用户接口，和创建DAL层工厂实例化具体的DAL层类
                    AddandDeleteUserIDAL addanddeleteIDAL = (AddandDeleteUserIDAL)fact.CreateUser("AddandDeleteUserDAL");
                    //转换为实体
                    Managerial manager = new Managerial();
                    manager.ManId = int.Parse(UserID);
                    DataTable SelectManagerTable = addanddeleteIDAL.SelectManagerial(manager);
                    //判断用户是否存在
                    if (SelectManagerTable.Rows.Count != 0)//不等于零说明存在
                    {
                        //判断是否是最后一个管理员
                        if (SelectManagerTable.Rows.Count<=2 && SelectManagerTable.Rows[0][2].ToString()=="管理员")
                        {
                            strMsger = "最后一个管理员不可以删除";
                        }
                        else
                        {
                            //删除登录表信息
                            UserLevel user = new Enitity.UserLevel();
                            user.UserID = int.Parse(UserID);
                            addanddeleteIDAL.DeleteUserLogin(user);
                            //删除管理者信息
                            addanddeleteIDAL.DeletetManagerial(manager);
                            //删除管理者身份信息 
                            ManIDcardno manidcardno = new ManIDcardno();
                            manidcardno.Manid = int.Parse(UserID);
                            addanddeleteIDAL.DeleteManIDcardno(manidcardno);
                            strMsger = "删除成功！";
                        }
                        
                    }
                    else
                    {
                        strMsger = "用户不存在，请从新输入！";
                    }
                    #endregion
                }
                else
                {
                    strMsger = "用户ID请输入数字！";
                }
            }
            return strMsger;
        }

        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="UserLevel">用户级别</param>
        /// <param name="StrMsg">返回信息</param>
        /// <returns>以表形式返回登录信息</returns>
        public DataTable SelectLogin(string userLevel, out string StrMsg)
        {
            //调用添加删除用户接口，和创建DAL层工厂实例化具体的DAL层类
            AddandDeleteUserIDAL addanddeleteIDAL = (AddandDeleteUserIDAL)fact.CreateUser("AddandDeleteUserDAL");
            //转换为实体
            UserLevel userlevel = new UserLevel();
            userlevel.Userlevel = userLevel;
            DataTable SelectLoginTable = addanddeleteIDAL.SelectUserLogin(userlevel);
            //判断是否有数据
            if (SelectLoginTable.Rows.Count!=0)//说明有数据
            {
                StrMsg = "查询完毕！";
            }
            else
            {
                StrMsg = "没有可查询数据！";
            }
            return SelectLoginTable;
        }

    }
}
