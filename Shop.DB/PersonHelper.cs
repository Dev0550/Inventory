using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DB
{
    public class PersonHelper : DBHelper
    {
        public PersonHelper(string connectionString)
            : base(connectionString, null)
        {

        }


        public DataTable List(string Search)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_Person]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@Search", Search);
                    return this.GetTable(dt, sqlcomm);
                }
            }

        }
        public DataTable ListPersonComps(string Search , int DepartmentId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_PersonComps]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;

                    sqlcomm.Parameters.AddWithValue("@Search", Search);
                    if (DepartmentId != 0 && DepartmentId != null)
                    {
                        sqlcomm.Parameters.AddWithValue("@DepartmentId", DepartmentId);
                    }
                    else
                    {
                        sqlcomm.Parameters.AddWithValue("@DepartmentId", DBNull.Value);
                    }


                    return this.GetTable(dt, sqlcomm);
                }
            }

        }
        public DataTable Insert(string FullName,int DepartmentId,int PostId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Insert_Person]", cn))
                {
                    sqlcomm.CommandType = CommandType.StoredProcedure;

                    sqlcomm.Parameters.AddWithValue("@FullName", FullName);
                    sqlcomm.Parameters.AddWithValue("@DepartmentId", DepartmentId);
                    sqlcomm.Parameters.AddWithValue("@PostId", PostId);
                 



                    return this.GetTable(dt, sqlcomm);
                }
            }

        }
 
    }
}
