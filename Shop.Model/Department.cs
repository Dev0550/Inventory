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
    public class Department:ModelBase
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Department(string connectionString)
        : base(connectionString,null)
        { 
        
        }

        public DataTable List()
        {
            DepartmentHelper department = new DepartmentHelper(this.ConnectionString);
            DataTable dt = department.List();
            CheckForError(department);
            return dt;
        }

        public DataTable ListPost()
        {
            DepartmentHelper department = new DepartmentHelper(this.ConnectionString);
            DataTable dt = department.ListPost();
            CheckForError(department);
            return dt;
        }
        public DataTable InsertPost()
        {
            DepartmentHelper department = new DepartmentHelper(this.ConnectionString);
            DataTable dt = department.InsertPost(this.FullName);
            CheckForError(department);
            return dt;
        }
        public DataTable InsertDepartment()
        {
            DepartmentHelper department = new DepartmentHelper(this.ConnectionString);
            DataTable dt = department.InsertDepartment(this.FullName);
            CheckForError(department);
            return dt;
        }

        //public DataTable Modify()
        //{
        //DocumentHelper documentHelper = new DocumentHelper(this.ConnectionString, this.LanguageCode);
        //DataTable dt = documentHelper.Modify(this.UserId, this.Id, this.DepartmentId, this.ToDepartmentId, this.DocumentTypeId,this.Comment);
        //CheckForError(documentHelper);
        //return dt;
        //}
    }
}
