using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventory.DB
{
    public class DBHelper
    {
        public string ConnectionString
        { get; protected set; }

        public string LanguageCode
        { get; protected set; }

        public int ErrorCode
        { get; protected set; }

        public string ErrorMessage
        { get; protected set; }

        public string SqlErrorMessage
        { get; protected set; }

        public string ErrorParams
        { get; protected set; }

        public bool HasErrors
        {
            get { return ErrorCode < 0; }
        }

        public DBHelper(string connectionString,string languageCode)
        {
            this.ConnectionString = connectionString;
            this.ErrorCode = 0;
            this.LanguageCode = languageCode;
        }

        protected void SetError(int errorCode, string errorMessage, string sqlErrorMessage, string errorParams)
        {
            if (errorCode >= 0)
                throw new ArgumentOutOfRangeException();
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.SqlErrorMessage = sqlErrorMessage;
            this.ErrorParams = errorParams;
        }

        public DataTable GetTable(DataTable dt, SqlCommand sqlcomm)
        {
            try
            {
                dt.Load(sqlcomm.ExecuteReader(), LoadOption.Upsert);
                if (dt.Columns.Contains("SqlMsg"))
                    SetError(Convert.ToInt32(dt.Rows[0]["ID"]), dt.Rows[0]["Msg"].ToString(), dt.Rows[0]["SqlMsg"].ToString(), dt.Rows[0]["SqlMsg"].ToString());

                //test-1
            }
            catch(Exception exc)
            {
                SetError(-9999, "Unhandled exception occurred", exc.Message, "");
            }
            return dt;
        }
    }
}
