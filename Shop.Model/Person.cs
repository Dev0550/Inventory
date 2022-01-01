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
    public class Person:ModelBase
    {
        public int UserId { get; set; }
    
        //public int Id { get; set; }
        //public int? ParentId { get; set; }
        //public string FullName { get; set; }
        //public string Inn { get; set; }
        //public string Mfo { get; set; }
        //public string Address {get; set;}
        //public int CertificateId { get; set; }
        public string FullName { get; set; }
        public int DepartmentId { get; set; }
        public int PostId { get; set; }
        public string Email { get; set; }
        public string HomeNumber { get; set; }
        public string Mobile { get; set; }
        public string WorkNumber { get; set; }
        public string WorkMobNumber { get; set; }
        public string Fax { get; set; }
        public string AddInfo { get; set; }
        public int NumberId { get; set; }
        public string Search { get; set; }
        public int Flag { get; set; }
        public Person(string connectionString)
            : base(connectionString, null)
        {

        }

        public DataTable List()
        {
            PersonHelper PersonHelper = new PersonHelper(this.ConnectionString);
            DataTable dt = PersonHelper.List(this.Search);
            CheckForError(PersonHelper);
            return dt;
        }
        public DataTable ListPersonComps()
        {
            PersonHelper PersonHelper = new PersonHelper(this.ConnectionString);
            DataTable dt = PersonHelper.ListPersonComps(this.Search,this.DepartmentId);
            CheckForError(PersonHelper);
            return dt;
        }

        public DataTable Insert()
        {
            PersonHelper PersonHelper = new PersonHelper(this.ConnectionString);
            DataTable dt = PersonHelper.Insert(this.FullName, this.DepartmentId, this.PostId);
            CheckForError(PersonHelper);
            return dt;
        }

  

        
    }
}
