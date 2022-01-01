using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Admin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void ListComp()
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            Inventory.Model.Person person = new Inventory.Model.Person(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            if (lup_Department.ItemIndex != -1)
            {
                person.DepartmentId = Convert.ToInt32(lup_Department.EditValue);
            }
            DataTable dt =  person.ListPersonComps();
            gc_RegComp.DataSource = computer.ListUnReg();
            gc_CompsReged.DataSource = computer.ListRegComp();
            gc_PersonComps.DataSource= dt;
            gc_Alerts.DataSource = computer.ListALerts();
            gp_PersonCOmps.Text = "Рӯйхати компютерҳо (Миқдор:" + dt.Rows.Count.ToString() + ")";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Inventory.Model.Department department = new Inventory.Model.Department(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
           
            lup_Department.Properties.DataSource = department.List();
            lup_Department.Properties.ValueMember = "Id";
            lup_Department.Properties.DisplayMember = "FullName";

            ListComp();

        }

        private void добавлениеСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson addPersonForm = new AddPerson(null);
            addPersonForm.ShowDialog();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                txt_CpuId.Text = gridView2.GetFocusedRowCellValue("CpuId").ToString();
                txt_CpuName.Text = gridView2.GetFocusedRowCellValue("CpuName").ToString();
                txt_MotherBoardName.Text = gridView2.GetFocusedRowCellValue("MotherboardName").ToString();
                txt_MotherBoardId.Text = gridView2.GetFocusedRowCellValue("MotherboardId").ToString();
                txt_Ram.Text = gridView2.GetFocusedRowCellValue("RamSize").ToString();
                txt_VideoCard.Text = gridView2.GetFocusedRowCellValue("VideoCard").ToString();
                txt_VideoCardId.Text = gridView2.GetFocusedRowCellValue("VideoId").ToString();
                txt_VideoSize.Text = gridView2.GetFocusedRowCellValue("VideoSize").ToString();
                txt_Os.Text = gridView2.GetFocusedRowCellValue("OS").ToString();
                txt_OsType.Text = gridView2.GetFocusedRowCellValue("SystemType").ToString();
                txt_CompName.Text = gridView2.GetFocusedRowCellValue("CompName").ToString();
                txt_AccountName.Text = gridView2.GetFocusedRowCellValue("Name").ToString();
                txt_MacAddress.Text = gridView2.GetFocusedRowCellValue("MacAddress").ToString();
                txt_Ip.Text = gridView2.GetFocusedRowCellValue("Ip").ToString();
                txt_date.Text = gridView2.GetFocusedRowCellValue("Date").ToString();
                txt_Domain.Text = gridView2.GetFocusedRowCellValue("Domain").ToString();

                Inventory.Model.Hdd hdd = new Inventory.Model.Hdd(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                hdd.CompId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"));
                gc_HddInReg.DataSource = hdd.ListById();
            }
            catch { }


        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_InverNumber.Text))
            {
                Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                computer.Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"));
                computer.InverNumber = txt_InverNumber.Text;
                computer.ModifyRegComp();
                gc_RegComp.DataSource = computer.ListUnReg();
                gc_CompsReged.DataSource = computer.ListRegComp();
                MessageBox.Show("Бо муваффақият маълумот дохил карда шуд.");
                

            }


        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            if (!string.IsNullOrEmpty(txt_RegedCompSearch.Text))
            {
                computer.Search = txt_RegedCompSearch.Text;
            }
            gc_CompsReged.DataSource = computer.ListRegComp();
        }

        private void gc_CompsReged_DoubleClick(object sender, EventArgs e)
        {
            CompToUser compToUserForm = new CompToUser(Convert.ToInt32(gridView3.GetFocusedRowCellValue("Id")), this);
            compToUserForm.ShowDialog();
        }

        private void gc_PersonComps_Click(object sender, EventArgs e)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            computer.Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            DataTable dt = computer.CompDetail();
            if (dt.Rows.Count > 0)
            {

                txt1_CpuId.Text = dt.Rows[0]["CpuId"].ToString();
                txt1_CpuName.Text = dt.Rows[0]["CpuName"].ToString();
                txt1_MotherBoardName.Text = dt.Rows[0]["MotherboardName"].ToString();
                txt1_MotherBoardId.Text = dt.Rows[0]["MotherboardId"].ToString();
                txt1_Ram.Text = dt.Rows[0]["RamSize"].ToString();
                txt1_VideoCard.Text = dt.Rows[0]["VideoCard"].ToString();
                txt1_VideoCardId.Text = dt.Rows[0]["VideoId"].ToString();
                txt1_VideoSize.Text = dt.Rows[0]["VideoSize"].ToString();
                txt1_Os.Text = dt.Rows[0]["OS"].ToString();
                txt1_OsType.Text = dt.Rows[0]["SystemType"].ToString();
                txt1_CompName.Text = dt.Rows[0]["CompName"].ToString();
                txt1_AccountName.Text = dt.Rows[0]["Name"].ToString();
                txt1_MacAddress.Text = dt.Rows[0]["MacAddress"].ToString();
                txt1_Ip.Text = dt.Rows[0]["Ip"].ToString();
                txt1_InverNumber.Text = dt.Rows[0]["InverNumber"].ToString();
                txt1_Domain.Text = dt.Rows[0]["Domain"].ToString();
                txt_Fio.Text = gridView1.GetFocusedRowCellValue("PersonFullName").ToString();
                textEdit3.Text = dt.Rows[0]["Date"].ToString();
                Inventory.Model.Hdd hdd = new Inventory.Model.Hdd(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                hdd.CompId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));

                gc_hddInPersonComps.DataSource = hdd.ListById();
            }


        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Inventory.Model.Person person = new Inventory.Model.Person(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            if (!string.IsNullOrEmpty(textEdit1.Text))
            {
                person.Search = textEdit1.Text;
            }
                DataTable dt = person.ListPersonComps();
                gc_PersonComps.DataSource = dt;
                gp_PersonCOmps.Text = "Рӯйхати компютерҳо (Миқдор:" + dt.Rows.Count.ToString() + ")";
            
        }

        private void gc_Alerts_Click(object sender, EventArgs e)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            computer.Id = Convert.ToInt32(gridView4.GetFocusedRowCellValue("CompId"));
            Inventory.Model.Hdd hdd = new Inventory.Model.Hdd(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            hdd.CompId = Convert.ToInt32(gridView4.GetFocusedRowCellValue("CompId"));
            DataTable dt = computer.CompDetail();
            if (dt.Rows.Count > 0)
            {

                txt2_CpuId.Text = dt.Rows[0]["CpuId"].ToString();
                txt2_CpuName.Text = dt.Rows[0]["CpuName"].ToString();
                txt2_MotherBoardName.Text = dt.Rows[0]["MotherboardName"].ToString();
                txt2_MotherBoardId.Text = dt.Rows[0]["MotherboardId"].ToString();
                txt2_Ram.Text = dt.Rows[0]["RamSize"].ToString();
                txt2_VideoCard.Text = dt.Rows[0]["VideoCard"].ToString();
                txt2_VideoCardId.Text = dt.Rows[0]["VideoId"].ToString();
                txt2_VideoSize.Text = dt.Rows[0]["VideoSize"].ToString();
                txt2_Os.Text = dt.Rows[0]["OS"].ToString();
                txt2_OsType.Text = dt.Rows[0]["SystemType"].ToString();
                txt2_CompName.Text = dt.Rows[0]["CompName"].ToString();
                txt2_AccountName.Text = dt.Rows[0]["Name"].ToString();
                txt2_MacAddress.Text = dt.Rows[0]["MacAddress"].ToString();
                txt2_Ip.Text = dt.Rows[0]["Ip"].ToString();
                txt2_InverNumber.Text = dt.Rows[0]["InverNumber"].ToString();
                txt2_Domain.Text = dt.Rows[0]["Domain"].ToString();
                gc_HddNow.DataSource = hdd.ListById();
                //txt_Fio.Text = gridView1.GetFocusedRowCellValue("PersonFullName").ToString();
                txt3_CpuId.Text = gridView4.GetFocusedRowCellValue("CpuId").ToString();
                txt3_CpuName.Text = gridView4.GetFocusedRowCellValue("CpuName").ToString();
                txt3_MotherBoardName.Text = gridView4.GetFocusedRowCellValue("MotherboardName").ToString();
                txt3_MotherBoardId.Text = gridView4.GetFocusedRowCellValue("MotherboardId").ToString();
                txt3_Ram.Text = gridView4.GetFocusedRowCellValue("RamSize").ToString();
                txt3_VideoCard.Text = gridView4.GetFocusedRowCellValue("VideoCard").ToString();
                txt3_VideoCardId.Text = gridView4.GetFocusedRowCellValue("VideoId").ToString();
                txt3_VideoSize.Text = gridView4.GetFocusedRowCellValue("VideoSize").ToString();
                txt3_Os.Text = gridView4.GetFocusedRowCellValue("OS").ToString();
                txt3_OsType.Text = gridView4.GetFocusedRowCellValue("SystemType").ToString();
                txt3_CompName.Text = gridView4.GetFocusedRowCellValue("CompName").ToString();
                txt3_AccountName.Text = gridView4.GetFocusedRowCellValue("Name").ToString();
                txt3_MacAddress.Text = gridView4.GetFocusedRowCellValue("MacAddress").ToString();
                txt3_Ip.Text = gridView4.GetFocusedRowCellValue("Ip").ToString();
                txt3_Date.Text = gridView4.GetFocusedRowCellValue("Date").ToString();
                txt3_Domain.Text = gridView4.GetFocusedRowCellValue("Domain").ToString();
                gc_hddAlert.DataSource = hdd.ListALertById();
                if (txt2_CpuId.Text != txt3_CpuId.Text)
                {
                    txt3_CpuId.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_CpuId.ForeColor = System.Drawing.Color.Black;
                }

                if (txt2_CpuName.Text != txt3_CpuName.Text)
                {
                    txt3_CpuName.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_CpuName.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_MotherBoardId.Text != txt3_MotherBoardId.Text)
                {
                    txt3_MotherBoardId.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_MotherBoardId.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_MotherBoardName.Text != txt3_MotherBoardName.Text)
                {
                    txt3_MotherBoardName.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_MotherBoardName.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_Ram.Text != txt3_Ram.Text)
                {
                    txt3_Ram.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt2_Ram.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_VideoCard.Text != txt3_VideoCard.Text)
                {
                    txt3_VideoCard.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_VideoCard.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_VideoCardId.Text != txt3_VideoCardId.Text)
                {
                    txt3_VideoCardId.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_VideoCardId.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_VideoSize.Text != txt3_VideoSize.Text)
                {
                    txt3_VideoSize.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_VideoSize.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_Os.Text != txt3_Os.Text)
                {
                    txt3_Os.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_Os.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_OsType.Text != txt3_OsType.Text)
                {
                    txt3_OsType.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_OsType.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_CompName.Text != txt3_CompName.Text)
                {
                    txt3_CompName.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_CompName.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_AccountName.Text != txt3_AccountName.Text)
                {
                    txt3_AccountName.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_AccountName.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_MacAddress.Text != txt3_MacAddress.Text)
                {
                    txt3_MacAddress.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_MacAddress.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_Ip.Text != txt3_Ip.Text)
                {
                    txt3_Ip.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_Ip.ForeColor = System.Drawing.Color.Black;
                }
                if (txt2_Domain.Text != txt3_Domain.Text)
                {
                    txt3_Domain.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txt3_Domain.ForeColor = System.Drawing.Color.Black;
                }
                simpleButton7.Enabled = true;

             
            }

        }

        public void AlertUptade(string Note)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            Inventory.Model.Person person = new Inventory.Model.Person(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            computer.Id = Convert.ToInt32(gridView4.GetFocusedRowCellValue("CompId"));
            computer.HistoryId = Convert.ToInt32(gridView4.GetFocusedRowCellValue("Id"));
            computer.Note = Note;
            DataTable dt = computer.Upgrate();
            simpleButton7.Enabled = false;
            gc_Alerts.DataSource = computer.ListALerts();
            gc_PersonComps.DataSource = person.ListPersonComps();
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            UpdateComp updateCompForm = new UpdateComp(this);
            updateCompForm.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1_InverNumber.Text))
            {
                CompHistory compHistory = new CompHistory(Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id")), txt1_InverNumber.Text);
                compHistory.ShowDialog();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lup_Department.ItemIndex = -1;
            ListComp();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm( gc_PersonComps.DataSource as DataTable,1);
            printForm.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            computer.Id =  Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            PrintForm printForm = new PrintForm(computer.CompDetail(), 2);
            printForm.ShowDialog();
        }

        private void lup_Department_EditValueChanged(object sender, EventArgs e)
        {
            ListComp();
        }
        
        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1_InverNumber.Text))
            {
                AddDevice addDeviceForm = new AddDevice(Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id")), gridView1.GetFocusedRowCellValue("PersonFullName").ToString());
                addDeviceForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Компютерро интихоб намоед!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            computer.Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"));
            computer.Delete();
            ListComp();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
