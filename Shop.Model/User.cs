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
    public class User:ModelBase
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        
        public string FullName { get; set; }
        


        public User(string connectionString, string languageCode)
        : base(connectionString,languageCode)
        { 
        
        }
        public User(string connectionString)
            : base(connectionString, null)
        {

        }

        public DataTable Check()
        {
            UserHelper userHelper = new UserHelper(this.ConnectionString, this.LanguageCode);
            DataTable dt = userHelper.Check(this.Login, this.Password);
            CheckForError(userHelper);
            return dt; 
        }

    }
}
