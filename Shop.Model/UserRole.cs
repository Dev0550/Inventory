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
    public class UserRole:ModelBase
    {
        public UserRole(string connectionString,string languageCode)
        : base(connectionString, languageCode)
        { 
        
        }

        public DataTable List()
        {
            UserRoleHelper userRoleHelper = new UserRoleHelper(this.ConnectionString, this.LanguageCode);
            DataTable dt = userRoleHelper.List();
            CheckForError(userRoleHelper);
            return dt; 
        }
        public DataTable Modify(int? id, int userId, int roleId, int departmentId)
        {
            UserRoleHelper userRoleHelper = new UserRoleHelper(this.ConnectionString, this.LanguageCode);
            DataTable dt = userRoleHelper.Modify(id,userId,roleId,departmentId);
            CheckForError(userRoleHelper);
            return dt; 
        }
    }
}
