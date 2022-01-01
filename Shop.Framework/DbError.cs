using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Framework
{
    public class DbError
    {
        public int ErrorCode
        { get; protected set; }

        public string ErrorMessage
        { get; protected set; }

        public string SqlErrorMessage
        { get; protected set; }

        public string ErrorParams
        { get; protected set; }

        public DbError(int errorCode, string errorMessage, string sqlErrorMessage, string errorParams)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.SqlErrorMessage = sqlErrorMessage;
            this.ErrorParams = errorParams;
        }
 
    }
}
