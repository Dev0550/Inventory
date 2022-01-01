using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Model.User user = new Model.User(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            //user.Login = txt_Usename.Text.Trim() ;
            //user.Password = txt_password.Text.Trim();
            //DataTable dt = user.Check();
            //if (dt.Rows.Count > 0)
            //{
            //    Agent mainForm = new Agent();

            //    //mainForm.UserRole(dt.Rows[0]["Fullname"].ToString(), Convert.ToInt32(dt.Rows[0]["RoleId"]), Convert.ToInt32(dt.Rows[0]["Id"]), dt.Rows[0]["Role"].ToString()) ;
            //        //mainForm.UserRole(dt.Rows[0]["Fullname"].ToString(), Convert.ToInt32(dt.Rows[0]["RoleId"]), Convert.ToInt32(dt.Rows[0]["Id"]), dt.Rows[0]["Role"].ToString())
               
            //    mainForm.ShowDialog();
            //    this.Hide();
            //}
        }
    }
}
