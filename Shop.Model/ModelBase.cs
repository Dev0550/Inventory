using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Inventory.DB;
using Inventory.Framework;

namespace Inventory.Model
{
    public class ModelBase
    {
        public int Id
        { get; set; }

        public string ConnectionString
        { get; protected set; }

        public string LanguageCode
        { get; protected set; }

        public DbError DBError
        { get; protected set; }

        protected void CheckForError(DBHelper dh)
        {
            if (dh.HasErrors)
            {
               DBError = new DbError(dh.ErrorCode, dh.ErrorMessage, dh.SqlErrorMessage, dh.ErrorParams);
            }
        }

        public ModelBase(string connectionString, string languageCode)
        {
            this.ConnectionString = connectionString;
            this.LanguageCode = languageCode;
        }
    }
}
