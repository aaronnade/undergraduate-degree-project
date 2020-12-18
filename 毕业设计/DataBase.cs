using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace 毕业设计
{
    /// <summary>
    /// 通用数据库类
    /// </summary>
    public class DataBase
    {
        private string ConnStr = null;

        public DataBase()
        {
            //ConnStr = ConfigurationSettings.AppSettings["ConnStr"];
            ConnStr = ConfigurationManager.ConnectionStrings["backgroundSysConnectionString"].ConnectionString;
        }
        public DataBase(string Str)
        {
            try
            {
                this.ConnStr = Str;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 返回connection对象
        /// </summary>
        /// <returns></returns>
        public SqlConnection ReturnConn()
        {
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();
            return Conn;
        }

        public void Dispose(SqlConnection Conn)
        {
            if(Conn != null)
            {
                Conn.Close();
                Conn.Dispose();
            }
            GC.Collect();
        }

        /// <summary>
        /// 生成Command对象
        /// </summary>
        /// <param name="SQL"></param>
        /// <param name="Conn"></param>
        /// <returns></returns>
        public SqlCommand GetCmd(string SQL, SqlConnection Conn)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand(SQL, Conn);
            return Cmd;
        }

        

        /// <summary>
        ///运行SQL语句返回DataReader
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public SqlDataReader RunSQLGetReader(string SQL)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlCommand Cmd;
            Cmd = GetCmd(SQL, Conn);
            SqlDataReader Dr;
            try
            {
                Dr = Cmd.ExecuteReader(CommandBehavior.Default);
            }
            catch
            {
                throw new Exception(SQL);
            }
            return Dr;
        }

        /// <summary>
        /// 返回adapter对象
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public SqlDataAdapter GetDataAd(string SQL)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlDataAdapter Da;
            Da = new SqlDataAdapter(SQL, Conn);
            return Da;
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="SQL"></param>
        public void RunSQL(string SQL)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlCommand Cmd;
            Cmd = GetCmd(SQL, Conn);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception(SQL);
            }
            Dispose(Conn);
            return;
        }

        /// <summary>
        /// 运行SQL语句，返回DataTable对象
        /// </summary>
        /// <param name="SQL">SQL语句</param>
        /// <param name="Ds">DataSet对象</param>
        /// <returns></returns>
        public DataTable RunSQL(string SQL, DataTable Dt)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlDataAdapter Da;
            Da = new SqlDataAdapter(SQL, Conn);
            try
            {
                Da.Fill(Dt);
            }
            catch(Exception Err)
            {
                throw Err;
            }
            Dispose(Conn);
            return Dt;
        }
        
        /// <summary>
        /// 运行SQL语句，返回DataSet对象
        /// </summary>
        /// <param name="SQL">SQL语句</param>
        /// <param name="Ds">DataSet对象</param>
        /// <returns></returns>

        public DataSet RunSQL(string SQL, DataSet Ds)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlDataAdapter Da;
            Da = new SqlDataAdapter(SQL, Conn);
            try
            {
                Da.Fill(Ds);
            }
            catch (Exception Err)
            {
                throw Err;
            }
            Dispose(Conn);
            return Ds;
        }

        /// <summary>
        /// 运行SQL语句，返回DataSet对象
        /// </summary>
        /// <param name="SQL">SQL语句</param>
        /// <param name="Ds">DataSet对象</param>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        public DataSet RunSQL(string SQL, DataSet Ds, string tablename)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlDataAdapter Da;
            Da = GetDataAd(SQL);
            try
            {
                Da.Fill(Ds, tablename);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            Dispose(Conn);
            return Ds;
        }

        public DataSet RunSQL(string SQL, DataSet Ds, int StartIndex, int PageSize, string tablename)
        {
            SqlConnection Conn;
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlDataAdapter Da;
            Da = GetDataAd(SQL);
            try
            {
                Da.Fill(Ds, StartIndex, PageSize, tablename);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Dispose(Conn);
            return Ds;
        }
    }
}