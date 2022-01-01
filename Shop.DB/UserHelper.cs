using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DB
{
    public class UserHelper:DBHelper
    {
        public UserHelper(string connectionString,string languageCode)
        : base(connectionString, languageCode)
        { 
        
        }

        public DataTable Check(string Username, string Password)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Check_User]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@Username", Username);
                    sqlcomm.Parameters.AddWithValue("@Password", Password);
                    return this.GetTable(dt, sqlcomm);
                }
            }   
        }
        public DataTable RoleList(int userId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_UserRoles_Proc]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;

                    sqlcomm.Parameters.AddWithValue("UserId", userId);

                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable List2(int userId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_User_Proc]", cn))

                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("UserId", userId);
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable DepartmentList(int userId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_UserDepartment_Proc]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("UserId", userId);

                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable Check(string login, string password, string tokenKey, string departmentKey)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Check_User_Proc]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;

                    sqlcomm.Parameters.AddWithValue("@Login", login);
                    sqlcomm.Parameters.AddWithValue("Password", password);
                    sqlcomm.Parameters.AddWithValue("@Key", tokenKey);
                    sqlcomm.Parameters.AddWithValue("@DepKey", departmentKey);

                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable Modify(int? id, string fullName, string login, int roleId, int departmentId, int certificateId, string endDate, int userId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Modify_User_Proc]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    if (id == null || id==0)
                    {
                        sqlcomm.Parameters.AddWithValue("@Id", DBNull.Value);
                    }
                    else
                    {
                        sqlcomm.Parameters.AddWithValue("@Id", id);
                    }
                    sqlcomm.Parameters.AddWithValue("@FullName", fullName);
                    sqlcomm.Parameters.AddWithValue("@Login", login);
                    sqlcomm.Parameters.AddWithValue("@UserId", userId);
                    sqlcomm.Parameters.AddWithValue("@RoleId", roleId);
                    sqlcomm.Parameters.AddWithValue("@DepartmentId", departmentId);
                    sqlcomm.Parameters.AddWithValue("@CertificateId", certificateId);
                    sqlcomm.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(endDate));
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
    }
}
