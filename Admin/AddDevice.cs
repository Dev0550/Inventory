using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class AddDevice : Form
    {
        int CompId;
        string Person;
        public AddDevice(int ComputerId,string PersonFullName)
        {
            InitializeComponent();
            CompId = ComputerId;
            Person = PersonFullName;
        }

        private void AddDevice_Load(object sender, EventArgs e)
        {
            Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            computer.Id = CompId;
            
            gridControl1.DataSource = computer.ListDevice();
            label1.Text = Person;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_FullName.Text) && !string.IsNullOrEmpty(txt_InvNumber.Text))
            {
                Inventory.Model.Computer computer = new Inventory.Model.Computer(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                computer.Id = CompId;
                computer.InverNumber = txt_InvNumber.Text;
                computer.Device = txt_FullName.Text;
                DataTable dt = computer.InsertDevice();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Мутаассифона таҷҳизот бо ин номери инвертарӣ дар базаи маълумот вуҷуд дорад!");
                }
                else
                {
                    
                                   

                    gridControl1.DataSource = computer.ListDevice();
                    MessageBox.Show("Ба қайд гирифта шуд!");
                }
            }
            else
            {
                MessageBox.Show("Маълумотро пурра ворид намоед!");
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
