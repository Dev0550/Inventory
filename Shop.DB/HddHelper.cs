using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DB
{
    public class HddHelper : DBHelper
    {
        public HddHelper(string connectionString)
            : base(connectionString, null)
        {

        }


        public DataTable Insert(string HddFullName, string HddDeviceId, decimal HddSize,int CompId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Insert_Hdd]", cn))
                {

                    sqlcomm.Parameters.AddWithValue("@HddFullName", HddFullName);
                    sqlcomm.Parameters.AddWithValue("@HddDeviceId", HddDeviceId);
                    sqlcomm.Parameters.AddWithValue("@HddSize", HddSize);
                    sqlcomm.Parameters.AddWithValue("@CompId", CompId);
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }

        public DataTable ListById(int CompId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_HddById]", cn))
                {




                    sqlcomm.Parameters.AddWithValue("@CompId", CompId);
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }

        public DataTable ListAlertById(int CompId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_HddAlertById]", cn))
                {




                    sqlcomm.Parameters.AddWithValue("@CompId", CompId);
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
       
 
    }
}
