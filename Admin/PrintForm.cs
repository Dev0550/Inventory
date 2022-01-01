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
    public partial class PrintForm : Form
    {
        int Type;
        DataTable dtReport = new DataTable();
        public PrintForm(DataTable dt, int T)
        {
            InitializeComponent();
            dtReport = dt;
            Type = T;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
           

            if (Type == 1)
            {
                 PersonComps repPersonComps = new PersonComps();
                printControl1.PrintingSystem = repPersonComps.PrintingSystem;
                repPersonComps.DataSource = dtReport;
                repPersonComps.CreateDocument();
            }
            if (Type == 2)
            {
                Inventory.Model.Hdd hdd = new Inventory.Model.Hdd(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                CompDetail compDetail = new CompDetail();
                hdd.CompId =Convert.ToInt32(dtReport.Rows[0]["Id"]);
                compDetail.txt_CpuId.Text ="ИД - процессора: "+ dtReport.Rows[0]["CpuId"].ToString();
                compDetail.txt_CpuName.Text ="Процессор: "+  dtReport.Rows[0]["CpuName"].ToString();
                compDetail.txt_MotherBoardName.Text ="Платаи модари: "+  dtReport.Rows[0]["MotherboardName"].ToString();
                compDetail.txt_MotherBoardId.Text = "ИД - платаи модари: "+ dtReport.Rows[0]["MotherboardId"].ToString();
                compDetail.txt_Ram.Text = "ОЗУ: "+ dtReport.Rows[0]["RamSize"].ToString();
                compDetail.txt_VideoCard.Text = "Видео карта: "+ dtReport.Rows[0]["VideoCard"].ToString();
                compDetail.txt_VideoCardId.Text = "ИД - видео карта: "+ dtReport.Rows[0]["VideoId"].ToString();
                compDetail.txt_VideoSize.Text ="Ҳаҷми видео карта: "+  dtReport.Rows[0]["VideoSize"].ToString();
                compDetail.txt_Os.Text ="Системаи оператсионӣ: "+  dtReport.Rows[0]["OS"].ToString();
                compDetail.txt_OsType.Text = "Намуди ОС: "+ dtReport.Rows[0]["SystemType"].ToString();
                compDetail.txt_CompName.Text ="Номи компютер: "+  dtReport.Rows[0]["CompName"].ToString();
                compDetail.txt_AccountName.Text ="Учётная запись: "+  dtReport.Rows[0]["Name"].ToString();
                compDetail.txt_MacAddress.Text ="МАС - адрес: "+  dtReport.Rows[0]["MacAddress"].ToString();
                compDetail.txt_Ip.Text ="IP - Адрес: "+  dtReport.Rows[0]["Ip"].ToString();
                compDetail.txt_InverNumber.Text ="Номери инвертарӣ: "+  dtReport.Rows[0]["InverNumber"].ToString();
                compDetail.txt_Domain.Text ="Домен: "+  dtReport.Rows[0]["Domain"].ToString();
                compDetail.txt_date.Text = "Таърихи рӯз: " + dtReport.Rows[0]["Date"].ToString();
                compDetail.txt_datePrint.Text = DateTime.Now.ToString("dd.MM.yyyy");
                 printControl1.PrintingSystem = compDetail.PrintingSystem;
                compDetail.DataSource = hdd.ListById();
                compDetail.CreateDocument();
            }
            }
        }
    }


