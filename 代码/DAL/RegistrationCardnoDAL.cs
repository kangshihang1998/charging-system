using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引用
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using IDAL;
using Enitity;
namespace DAL
{
    /// <summary>
    /// 注册卡号数据层
    /// </summary>
    public class RegistrationCardnoDAL : RegistrationCardnoIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 向卡号表插入卡号信息
        /// </summary>
        /// <param name="Cardno">卡号实体</param>
        /// <returns></returns>
        public int InsertCarndo(RegistrationCardno Cardno)
        {
            //定义参数
            SqlParameter[] sqlparms = {new SqlParameter("@StudentCardno",Cardno.StudentCardno),//卡号
                                       new SqlParameter("@Studentbalance",Cardno.Studentbalance),//余额
                                       new SqlParameter("@Initialamount",Cardno.Initialamount),//开卡金额
                                       new SqlParameter("@StudentLeve",Cardno.StudentLeve),//卡号类型
                                       new SqlParameter("@State",Cardno.State),//卡号使用状态
                                       new SqlParameter("@OpertionID",Cardno.OpertionID),
                                       new SqlParameter("@AccountsState",Cardno.AccountsState)};//结账状态
            //定义SQL语句
            string sql = @"insert into RegistrationCardno values(@StudentCardno,@Studentbalance,@Initialamount,@StudentLeve,@State,@OpertionID,@AccountsState)";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparms,CommandType.Text);
            return Relust;//返回受影响的行数
        }
        /// <summary>
        /// 向学生信息表插入信息
        /// </summary>
        /// <param name="studentinfo">学生实体</param>
        /// <returns>受影响行数</returns>
        public int InsertStudentInfo(StudentInfo studentinfo)
        {
            //定义参数
            SqlParameter[] sqlparms = { new SqlParameter("@StudentCardno",studentinfo.StudentCardno),
                                       new SqlParameter("@Name",studentinfo.Name),
                                       new SqlParameter("@Sex",studentinfo.Sex),
                                       new SqlParameter("@Age",studentinfo.Age),
                                       new SqlParameter("@CallNumbe",studentinfo.CallNumber),
                                       new SqlParameter("@WeChat",studentinfo.WeChat),
                                       new SqlParameter("@HomeAddres",studentinfo.HomeAddress),
                                       new SqlParameter("@Grade",studentinfo.Grade)};
            //定义SQL语句
            string sql = @"insert into StudentInfo values(@StudentCardno,@Name,@Sex,@Age,@CallNumbe,@WeChat,@HomeAddres,@Grade)";
            //接受返回值
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparms,CommandType.Text);
            return Relust;//受影响行数
        }
        /// <summary>
        /// 向登录表插入信息
        /// </summary>
        /// <param name="userLogin">登录实体</param>
        /// <returns>受影响行数</returns>
        public int InsertUserLogin(UserLevel userLogin)
        {
            //定义参数
            SqlParameter[] sqlparms = { new SqlParameter("@UserID",userLogin.UserID),
                                       new SqlParameter("@Userlevel",userLogin.Userlevel),
                                       new SqlParameter("@Pwd",userLogin.UserPwd)};
            //定义SQL语句
            string sql = @"insert into UserLonin values(@UserID,@Userlevel,@Pwd)";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparms,CommandType.Text);
            return Relust;//返回受影响行数
        }
        /// <summary>
        /// 查询基础表
        /// </summary>
        /// <returns>返回整个基础表信息</returns>
        public DataTable SelectBasit()
        {
            //定义查询SQL语句
            string sql = @"select * from Basis";
            //接受返回值
            DataTable BasiTable = sqlHelper.ExecuteQuery(sql,CommandType.Text);
            return BasiTable;//返回结果
        }
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="CardnoState">卡号实体</param>
        /// <returns>卡号信息</returns>
        public DataTable SelectRegistCardno(RegistrationCardno CardnoState)
        {
            //定义参数
            SqlParameter[] sqlpams = { new SqlParameter("@StudentCardno", CardnoState.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from RegistrationCardno where StudentCardno=@StudentCardno";
            //接受出现结果
            DataTable UserTable = sqlHelper.ExecuteQuery(sql, sqlpams, CommandType.Text);
            return UserTable;//返回查询结果
        }

        /// <summary>
        /// 查询用户是否已经存在
        /// </summary>
        /// <param name="LoginUserID">用户ID</param>
        /// <returns>用户登录表里的信息</returns>
        public DataTable SelectUserLevel(UserLevel LoginUserID)
        {
            //定义参数
            SqlParameter[] sqlpams = { new SqlParameter("@UserID", LoginUserID.UserID) };
            //定义SQL语句
            string sql = @"select * from UserLonin where UserID=@UserID";
            //接受出现结果
            DataTable UserTable = sqlHelper.ExecuteQuery(sql, sqlpams, CommandType.Text);
            return UserTable;//返回查询结果
        }
        /// <summary>
        /// 更新卡号使用状态
        /// </summary>
        /// <param name="CardnoState">卡号使用状态</param>
        /// <returns>受影响的行数</returns>
        public int UpdateCardnoState(RegistrationCardno CardnoState)
        {
            //定义参数
            SqlParameter[] sqlparms = {new SqlParameter("@StudentCardno",CardnoState.StudentCardno),//卡号
                                       new SqlParameter("@State",CardnoState.State) };//卡号使用状态
            //定义SQL语句
            string sql = @"update RegistrationCardno set State=@State where StudentCardno=@StudentCardno";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlparms, CommandType.Text);
            return Relust;//返回受影响的行数
        }
    }
}
