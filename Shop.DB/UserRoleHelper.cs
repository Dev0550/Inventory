using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DB
{
    public class UserRoleHelper:DBHelper
    {
        public UserRoleHelper(string connectionString,string languageCode)
        : base(connectionString, languageCode)
        { 
        
        }

        public DataTable List()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_UserRoles_Proc]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }   
        }
        public DataTable Modify(int? id, int userId, int roleId, int departmentId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Modify_UserRole_Proc]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;

                    sqlcomm.Parameters.AddWithValue("Id", id);
                    sqlcomm.Parameters.AddWithValue("UserId", userId);
                    sqlcomm.Parameters.AddWithValue("RoleId", roleId);
                    sqlcomm.Parameters.AddWithValue("DepartmentId", departmentId);

                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
    }
}
