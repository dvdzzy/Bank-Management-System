using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullTeam_Bank_Management
{
    public partial class nullbank : Form
    {
        public nullbank()
        {
            InitializeComponent();
        }

        private void addcustomers_Click(object sender, EventArgs e)
        {
            Addcustomers frm = new Addcustomers();
            frm.ShowDialog();
        }

        private void showcustomers_Click(object sender, EventArgs e)
        {
            ShowCustomers frm = new ShowCustomers();
            frm.ShowDialog();
        }

        private void addstaff_Click(object sender, EventArgs e)
        {
            AddStaff frm = new AddStaff();
            frm.ShowDialog();
        }

        private void showstaff_Click(object sender, EventArgs e)
        {
            ShowStaff frm = new ShowStaff();
            frm.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Message",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
