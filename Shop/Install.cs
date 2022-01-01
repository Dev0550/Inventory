using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
namespace Inventory
{
    public partial class Install : Form
    {
        public Install()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agent agent = new Agent(false);
            //agent.ShowDialog();
            //
            string exe = System.Windows.Forms.Application.ExecutablePath;
            exe = exe.Substring(0,exe.Length - 4);
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            reg.CreateSubKey("Inventory");
            reg.SetValue("Inventory", exe+"Agent.exe");
            Process.Start("InventoryAgent.exe");
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.ShowDialog();
        }
    }
}
