using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


using Inventory.DB;

namespace Inventory.Model
{
    public class Helper : ModelBase
    {
     
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public string Search { get; set; }
        public Helper(string connectionString)
            : base(connectionString, null)
        {

        }
        //public DataTable List()
        //{
        //    SaleHelper taxTypeHelper = new SaleHelper(this.ConnectionString);
        //    DataTable dt = taxTypeHelper.List();
        //    CheckForError(taxTypeHelper);
        //    return dt;
        //}
        public DataTable List_GromPolosa()
        {
            AllHelper Helper = new AllHelper(this.ConnectionString);
            DataTable dt = Helper.List_GromPolosa();
            CheckForError(Helper);
            return dt;
        }
        public DataTable List_MagBox()
        {
            AllHelper Helper = new AllHelper(this.ConnectionString);
            DataTable dt = Helper.List_MagBox();
            CheckForError(Helper);
            return dt;
        }
        public DataTable List_RaspBox()
        {
            AllHelper Helper = new AllHelper(this.ConnectionString);
            DataTable dt = Helper.List_RaspBox();
            CheckForError(Helper);
            return dt;
        }
        public DataTable List_Shkaf()
        {
            AllHelper Helper = new AllHelper(this.ConnectionString);
            DataTable dt = Helper.List_Shkaf();
            CheckForError(Helper);
            return dt;
        }

      
    }
}
