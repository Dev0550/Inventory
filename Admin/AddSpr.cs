using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class AddSpr : Form
    {
        AddPerson PersonForm;
        public AddSpr(AddPerson Form)
        {
            InitializeComponent();
            PersonForm = Form;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_department.Text))
            {
                Inventory.Model.Department department = new Inventory.Model.Department(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                department.FullName = txt_department.Text;
                DataTable dt = department.InsertDepartment();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Мутаассифона инхел шӯъба дар базаи маълумот вуҷуд дорад.");
                }
                else
                {
                    MessageBox.Show("Бо муваффақият маълумот дохил карда шуд.");
                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_post.Text))
            {
                Inventory.Model.Department department = new Inventory.Model.Department(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                department.FullName = txt_post.Text;
                DataTable dt = department.InsertPost();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Мутаассифона инхел вазифа дар базаи маълумот вуҷуд дорад.");
                }
                else
                {
                    PersonForm.SprLoad();
                    MessageBox.Show("Бо муваффақият маълумот дохил карда шуд.");

                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
