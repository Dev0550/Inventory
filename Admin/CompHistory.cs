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
    public partial class CompHistory : Form
    {
        int CompId;
        string InverNum;
        public CompHistory(int Compidi, string InvertNumber)
        {
            InitializeComponent();
            CompId = Compidi;
            InverNum = InvertNumber;
        }

        private void CompHistory_Load(object sender, EventArgs e)
        {
            groupBox4.Text = "Таърихи компютер №" + InverNum;
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            computer.Id = CompId;
            gc_CompsReged.DataSource = computer.CompHistory();
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
