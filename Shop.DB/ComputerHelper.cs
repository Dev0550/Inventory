using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DB
{
    public class ComputerHelper:DBHelper
    {
        public ComputerHelper(string connectionString)
        : base(connectionString, null)
        { 
        
        }
      
        public DataTable Insert(string cpuName,string cpuId,string motherBoardName,string motherBoardId,decimal ram,string macAddress,string os,string osType,
            string compName,string domain,string userName,string hddFullName,string hddDeviceId, decimal hddSize,string videoCard,string videoId,string videoSize,string Ip)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Insert_Computers]", cn))
                {
                
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@CpuName",cpuName);
                    sqlcomm.Parameters.AddWithValue("@CpuId",cpuId);
                    sqlcomm.Parameters.AddWithValue("@MotherBoardName",motherBoardName);
                    sqlcomm.Parameters.AddWithValue("@MotherBoardId",motherBoardId);
                    sqlcomm.Parameters.AddWithValue("@Ram",ram);
                    sqlcomm.Parameters.AddWithValue("@MacAddress",macAddress);
                    sqlcomm.Parameters.AddWithValue("@OS",os);
                    sqlcomm.Parameters.AddWithValue("@SystemType",osType);
                    sqlcomm.Parameters.AddWithValue("@CompName",compName);
                    sqlcomm.Parameters.AddWithValue("@Domain",domain);
                    sqlcomm.Parameters.AddWithValue("@UserName",userName);
                    sqlcomm.Parameters.AddWithValue("@HddFullName",hddFullName);
                    sqlcomm.Parameters.AddWithValue("@HddDeviceId",hddDeviceId);
                    sqlcomm.Parameters.AddWithValue("@HddSize",hddSize);
                    sqlcomm.Parameters.AddWithValue("@Ip", Ip);

                    sqlcomm.Parameters.AddWithValue("@VideoCard", videoCard);
                    sqlcomm.Parameters.AddWithValue("@VideoId", videoId);
                    sqlcomm.Parameters.AddWithValue("@VideoSize", videoSize);
                    return this.GetTable(dt, sqlcomm);
                }
            }   
        }

        public DataTable InsertCompToUser(int CompId,int PersonId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Insert_CopmToUser]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@CompId", CompId);
                    sqlcomm.Parameters.AddWithValue("@PersonId", PersonId);
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
        public DataTable ListAlerts(string Search)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_Alerts]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@Search", Search);
                    
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }

      
     public DataTable CompDetail(int CompId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_CompDetailById]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@Id", CompId);
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }
     public DataTable ListUnReg()
            
     {
         DataTable dt = new DataTable();
         using (SqlConnection cn = new SqlConnection(this.ConnectionString))
         {
             cn.Open();
             using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_UnRegComps]", cn))
             {

                 sqlcomm.CommandType = CommandType.StoredProcedure;
               
                 return this.GetTable(dt, sqlcomm);
             }
         }
     }
      
     public DataTable RegComp(int CompId, string InverNumber)
     {
         DataTable dt = new DataTable();
         using (SqlConnection cn = new SqlConnection(this.ConnectionString))
         {
             cn.Open();
             using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Modify_RegComp]", cn))
             {

                 sqlcomm.CommandType = CommandType.StoredProcedure;
                 sqlcomm.Parameters.AddWithValue("@CompId", CompId);
                 sqlcomm.Parameters.AddWithValue("@InverNumber", InverNumber);
                 return this.GetTable(dt, sqlcomm);
             }
         }
     }

     public DataTable ListRegComps(string search)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(this.ConnectionString))
            {
                cn.Open();
                using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_RegComps]", cn))
                {

                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlcomm.Parameters.AddWithValue("@Search", search);
                   
                    return this.GetTable(dt, sqlcomm);
                }
            }
        }

     public DataTable Upgrate(int CompId, int HistoryId,string Note)
     {
         DataTable dt = new DataTable();
         using (SqlConnection cn = new SqlConnection(this.ConnectionString))
         {
             cn.Open();
             using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Modify_Upgrade]", cn))
             {

                 sqlcomm.CommandType = CommandType.StoredProcedure;
                 sqlcomm.Parameters.AddWithValue("@CompId", CompId);
                 sqlcomm.Parameters.AddWithValue("@HistoryId", HistoryId);
                 sqlcomm.Parameters.AddWithValue("@Note", Note);
                 return this.GetTable(dt, sqlcomm);
             }
         }
     }

     public DataTable History(int CompId)
     {
         DataTable dt = new DataTable();
         using (SqlConnection cn = new SqlConnection(this.ConnectionString))
         {
             cn.Open();
             using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_CompHistory]", cn))
             {

                 sqlcomm.CommandType = CommandType.StoredProcedure;
                 sqlcomm.Parameters.AddWithValue("@CompId", CompId);

                 return this.GetTable(dt, sqlcomm);
             }
         }
     }

     public DataTable ListDevices(int CompId)
     {
         DataTable dt = new DataTable();
         using (SqlConnection cn = new SqlConnection(this.ConnectionString))
         {
             cn.Open();
             using (SqlCommand sqlcomm = new SqlCommand("[dbo].[List_Devices]", cn))
             {

                 sqlcomm.CommandType = CommandType.StoredProcedure;
                 sqlcomm.Parameters.AddWithValue("@CompId", CompId);

                 return this.GetTable(dt, sqlcomm);
             }
         }
     }

     public DataTable InsertDevices(int CompId,string Device,string InvNumber)
     {
         DataTable dt = new DataTable();
         using (SqlConnection cn = new SqlConnection(this.ConnectionString))
         {
             cn.Open();
             using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Insert_Device]", cn))
             {

                 sqlcomm.CommandType = CommandType.StoredProcedure;
                 sqlcomm.Parameters.AddWithValue("@CompId", CompId);
                 sqlcomm.Parameters.AddWithValue("@FullName", Device);
                 sqlcomm.Parameters.AddWithValue("@InvNumber", InvNumber);
                 return this.GetTable(dt, sqlcomm);
             }
         }
     }

     public DataTable Delete(int CompId)
     {
         DataTable dt = new DataTable();
         using (SqlConnection cn = new SqlConnection(this.ConnectionString))
         {
             cn.Open();
             using (SqlCommand sqlcomm = new SqlCommand("[dbo].[Delete_Computer]", cn))
             {

                 sqlcomm.CommandType = CommandType.StoredProcedure;
                 sqlcomm.Parameters.AddWithValue("@Id", CompId);
                
                 return this.GetTable(dt, sqlcomm);
             }
         }
     }
    }
}
