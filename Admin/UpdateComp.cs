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
    public partial class UpdateComp : Form
    {
        MainForm mainForm;
        public UpdateComp(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                mainForm.AlertUptade(richTextBox1.Text);
            }
            this.Close();
        }
    }
}
