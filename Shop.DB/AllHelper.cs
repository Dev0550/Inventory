using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DB
{
    public class AllHelper : DBHelper
    {
        public AllHelper(string connectionString)
        : base(connectionString, null)
        { 
        
        }



        public DataTable List_GromPolosa()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_GromPolosa]", cn))
                {

                    
                  
                  
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }

        public DataTable List_MagBox()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_MagBox]", cn))
                {




                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable List_RaspBox()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_RaspBox]", cn))
                {




                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable List_Shkaf()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_Shkaf]", cn))
                {




                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }


     
        
        
    }
}
