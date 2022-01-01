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
    public class Computer:ModelBase
    {

      

	
	
        public string CpuName {get;set;}
        public string CpuId {get;set;}
        public string MotherBoardName  {get;set;}
        public string MotherBoardId {get;set;}
        public decimal Ram {get;set;}
        public string MacAddress {get;set;}
        public string Os { get; set; }
        public string SystemType {get;set;}
        public string CompName {get;set;}
        public string Domain {get;set;}
        public string UserName {get;set;}
        public string HddFullName {get;set;}
        public string HddDeviceId {get;set;}
        public decimal HddSize {get;set;}
        public string VideoCard { get; set; }
        public string VideoId { get; set; }
        public string VideoSize { get; set; }
        public string Ip { get; set; }
        public string InverNumber { get; set; }
        public string Search { get; set; }
        public int PersonId { get; set; }
        public int HistoryId { get; set; }
        public string Note { get; set; }
        public string Device { get; set; }
        public Computer(string connectionString)
        : base(connectionString,null)
        { 
        
        }

        public DataTable Delete()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.Delete(this.Id);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable Insert()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.Insert(this.CpuName, this.CpuId, this.MotherBoardName, this.MotherBoardId, this.Ram, this.MacAddress, this.Os, this.SystemType, this.CompName, this.Domain, this.UserName, this.HddFullName, this.HddDeviceId, this.HddSize, this.VideoCard, this.VideoId, this.VideoSize, this.Ip);
            CheckForError(computerHelper);
            return dt;
        }
        public DataTable ListUnReg()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.ListUnReg();
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable ModifyRegComp()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.RegComp(this.Id,this.InverNumber);
            CheckForError(computerHelper);
            return dt;
        }
        public DataTable ListRegComp()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.ListRegComps(this.Search);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable CompDetail()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.CompDetail(this.Id);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable InsertCompToUser()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.InsertCompToUser(this.Id, this.PersonId);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable ListALerts()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.ListAlerts(this.Search);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable Upgrate()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.Upgrate(this.Id, this.HistoryId, this.Note);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable CompHistory()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.History(this.Id);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable ListDevice()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.ListDevices(this.Id);
            CheckForError(computerHelper);
            return dt;
        }

        public DataTable InsertDevice()
        {
            ComputerHelper computerHelper = new ComputerHelper(this.ConnectionString);
            DataTable dt = computerHelper.InsertDevices(this.Id, this.Device, this.InverNumber);
            CheckForError(computerHelper);
            return dt;
        }
        ////public DataTable Modify()
        ////{
        //    //DocumentHelper documentHelper = new DocumentHelper(this.ConnectionString, this.LanguageCode);
        //    //DataTable dt = documentHelper.Modify(this.UserId, this.Id, this.DepartmentId, this.ToDepartmentId, this.DocumentTypeId,this.Comment);
        //    //CheckForError(documentHelper);
        //    //return dt;
        ////}
    }
}
