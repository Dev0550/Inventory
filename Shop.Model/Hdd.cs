using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

//using Inventory.Framework;
using Inventory.DB;

namespace Inventory.Model
{
    public class Hdd:ModelBase
    {
        public int UserId { get; set; }


        public string HddFullName { get; set; }
        public decimal HddSize { get; set; }
        public int CompId { get; set; }
        public string HddDeviceId { get; set; }

        public Hdd(string connectionString)
            : base(connectionString, null)
        {

        }

        public DataTable Insert()
        {

            HddHelper hddHelper = new HddHelper(this.ConnectionString);
            DataTable dt = hddHelper.Insert(this.HddFullName, HddDeviceId, this.HddSize, CompId);
            CheckForError(hddHelper);
            return dt;
        }

        public DataTable ListById()
        {

            HddHelper hddHelper = new HddHelper(this.ConnectionString);
            DataTable dt = hddHelper.ListById(this.CompId);
            CheckForError(hddHelper);
            return dt;
        }
        public DataTable ListALertById()
        {

            HddHelper hddHelper = new HddHelper(this.ConnectionString);
            DataTable dt = hddHelper.ListAlertById(this.CompId);
            CheckForError(hddHelper);
            return dt;
        }
  
     
        
    }
}
