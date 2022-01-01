using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DB
{
    public class DepartmentHelper:DBHelper
    {
        public DepartmentHelper(string connectionString)
        : base(connectionString, null)
        { 
        
        }
       
        public DataTable List()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_Departments]", cn))
                {
                    
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }   
        }
        public DataTable ListPost()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_Posts]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }

        public DataTable InsertDepartment(string FullName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Insert_Department]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@FullName", FullName);
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable InsertPost(string FullName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Insert_Post]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@FullName", FullName);
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
      
  
    }
}
