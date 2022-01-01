using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Inventory.Framework;
using Inventory.DB;

namespace Inventory.Model
{
    public class Report:ModelBase
    {
        public int UserId { get; set; }
        public int DayId { get; set; }
        public string Search { get; set; }
        public string Qty { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public Report(string connectionString)
            : base(connectionString, null)
        {

        }


    
        //public DataTable CloseDayReport()
        //{
        //    ProductHelper reportHelper = new ProductHelper(this.ConnectionString, this.LanguageCode);
        //    DataTable dt = reportHelper.CloseDayReport(this.UserId, this.DayId);
        //    CheckForError(reportHelper);
        //    return dt;
        //}

        
    }
}
