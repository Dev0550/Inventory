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
    public partial class CompToUser : Form
    {
        int CompId;
        MainForm mainForm;
        public CompToUser(int CompIdi,MainForm frm)
        {
            InitializeComponent();
            CompId = CompIdi;
            mainForm = frm;
        }


        public void PersonList()
        {
            Inventory.Model.Person person = new Inventory.Model.Person(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            gridControl1.DataSource = person.List();
        }

        private void CompToUser_Load(object sender, EventArgs e)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
           
            computer.Id = CompId;

            DataTable dt = computer.CompDetail();
            if (dt.Rows.Count > 0)
            {
               
                txt_CpuId.Text =  dt.Rows[0]["CpuId"].ToString();
                txt_CpuName.Text = dt.Rows[0]["CpuName"].ToString();
                txt_MotherBoardName.Text =dt.Rows[0]["MotherboardName"].ToString();
                txt_MotherBoardId.Text = dt.Rows[0]["MotherboardId"].ToString();
                txt_Ram.Text = dt.Rows[0]["RamSize"].ToString();
                txt_VideoCard.Text = dt.Rows[0]["VideoCard"].ToString();
                txt_VideoCardId.Text = dt.Rows[0]["VideoId"].ToString();
                txt_VideoSize.Text =dt.Rows[0]["VideoSize"].ToString();
                txt_Os.Text = dt.Rows[0]["OS"].ToString();
                txt_OsType.Text = dt.Rows[0]["SystemType"].ToString();
                txt_CompName.Text = dt.Rows[0]["CompName"].ToString();
                txt_AccountName.Text = dt.Rows[0]["Name"].ToString();
                txt_MacAddress.Text = dt.Rows[0]["MacAddress"].ToString();
                txt_Ip.Text = dt.Rows[0]["Ip"].ToString();
                txt_InverNumber.Text = dt.Rows[0]["InverNumber"].ToString();
                txt_date.Text = dt.Rows[0]["Date"].ToString();
                txt_Domain.Text = dt.Rows[0]["Domain"].ToString();
                PersonList();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gridView1.GetFocusedRowCellValue("FullName").ToString()))
            {
                txt_Fio.Text = gridView1.GetFocusedRowCellValue("FullName").ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddPerson addPersonForm = new AddPerson(this);
            addPersonForm.ShowDialog();
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
            if(!string.IsNullOrEmpty(txt_Fio.Text))
            {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

            computer.Id = CompId;
            computer.PersonId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            computer.InsertCompToUser();
            simpleButton3.Enabled = false;
            
            mainForm.ListComp();
            }
            else
            {
                MessageBox.Show("Коргарро интихоб намоед!");
            }

        }
    }
}
