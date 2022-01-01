using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory;
namespace Admin
{
    public partial class AddPerson : Form
    {
        CompToUser CompToUserForm;
        public AddPerson(CompToUser frm)
        {
            InitializeComponent();
            CompToUserForm = frm;
        }


        public void SprLoad()
        {

            Inventory.Model.Department department = new Inventory.Model.Department(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            Inventory.Model.Person person = new Inventory.Model.Person(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            lup_Department.Properties.DataSource = department.List();
            lup_Department.Properties.ValueMember = "Id";
            lup_Department.Properties.DisplayMember = "FullName";
            lup_Post.Properties.DataSource = department.ListPost();
            lup_Post.Properties.ValueMember = "Id";
            lup_Post.Properties.DisplayMember = "FullName";
            gridControl1.DataSource = person.List();
        }
        private void AddPerson_Load(object sender, EventArgs e)
        {
            SprLoad();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_FullName.Text) && lup_Department.ItemIndex != -1 && lup_Post.ItemIndex != -1)
            {
                Inventory.Model.Person person = new Inventory.Model.Person(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                person.FullName = txt_FullName.Text;
                person.PostId = Convert.ToInt32(lup_Post.EditValue);
                person.DepartmentId = Convert.ToInt32(lup_Department.EditValue);
                DataTable dt = person.Insert();
                gridControl1.DataSource = person.List();
                if (CompToUserForm != null)
                {
                    CompToUserForm.PersonList();
                    this.Close();
                }
             
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Inventory.Model.Person person = new Inventory.Model.Person(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            if (!string.IsNullOrEmpty(textEdit1.Text))
            {
                person.Search = textEdit1.Text;
            }
            gridControl1.DataSource = person.List();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (CompToUserForm != null)
            {
                CompToUserForm.PersonList();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AddSpr addSpr = new AddSpr(this);
            addSpr.ShowDialog();
        }
    }
}
