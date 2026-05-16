using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NullTeam_Bank_Management
{
    public partial class ShowCustomers : Form
    {
        List<Customers> listOfCustomer = new List<Customers>();
        int index = 0;
        public ShowCustomers()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowCustomers_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    string[] word = sr.ReadLine().Split(';');
                    Customers c = new Customers();
                    c.Name = word[0];
                    c.Last_Name = word[1];
                    c.Phone_Number = word[2];
                    c.Email = word[3];
                    c.Address = word[4];
                    c.Balance = Convert.ToInt32(word[5]);
                    c.Plan = word[6];
                    c.User_Id = word[7];
                    c.Account_Number = word[8];
                    c.Savings = Convert.ToInt32(word[9]);
                    c.Photo_Path = word[10];
                    listOfCustomer.Add(c);
                }
            }
            catch
            {
                MessageBox.Show("Error reading file!");
            }

            sr.Close();
            fs.Close();

            Customers cs = listOfCustomer[index];
            label13.Text = cs.Name;
            label14.Text = cs.Last_Name;
            label15.Text = cs.Email;
            label16.Text = cs.Phone_Number;
            label17.Text = cs.Address;
            label18.Text = cs.Account_Number;
            label19.Text = cs.User_Id;
            label20.Text = cs.Plan;
            label21.Text = cs.Balance.ToString();
            label22.Text = cs.Savings.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(cs.Photo_Path);
            }
            catch
            {
            }
            page1.Text = (index + 1) + " From " + listOfCustomer.Count;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;

                Customers cs = listOfCustomer[index];
                label13.Text = cs.Name;
                label14.Text = cs.Last_Name;
                label15.Text = cs.Email;
                label16.Text = cs.Phone_Number;
                label17.Text = cs.Address;
                label18.Text = cs.Account_Number;
                label19.Text = cs.User_Id;
                label20.Text = cs.Plan;
                label21.Text = cs.Balance.ToString();
                label22.Text = cs.Savings.ToString();
                try
                {
                    pictureBox1.Image = Image.FromFile(cs.Photo_Path);
                }
                catch
                {
                }
                page1.Text = (index + 1) + " From " + listOfCustomer.Count;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < listOfCustomer.Count - 1)
            {
                index++;

                Customers cs = listOfCustomer[index];
                label13.Text = cs.Name;
                label14.Text = cs.Last_Name;
                label15.Text = cs.Email;
                label16.Text = cs.Phone_Number;
                label17.Text = cs.Address;
                label18.Text = cs.Account_Number;
                label19.Text = cs.User_Id;
                label20.Text = cs.Plan;
                label21.Text = cs.Balance.ToString();
                label22.Text = cs.Savings.ToString();
                try
                {
                    pictureBox1.Image = Image.FromFile(cs.Photo_Path);
                }
                catch
                {
                }
                page1.Text = (index + 1) + " From " + listOfCustomer.Count;
            }
        }

        private void addcustomers_Click(object sender, EventArgs e)
        {
            Customers c = listOfCustomer[index];
            Customers.selectedName = c.Name;
            Customers.selectedLastName = c.Last_Name;
            Customers.selectedPhone = c.Phone_Number;
            Customers.selectedEmail = c.Email;
            Customers.selectedAddress = c.Address;
            Customers.selectedBalance = c.Balance;
            Customers.selectedSavings = c.Savings;
            Customers.selectedPlan = c.Plan;
            Customers.selectedUserId = c.User_Id;
            Customers.selectedAccount = c.Account_Number;
            Customers.selectedPhoto = c.Photo_Path;

            EditCustomer frm = new EditCustomer();
            frm.ShowDialog();
        }

        private void controlbalance_Click(object sender, EventArgs e)
        {
            Customers c = listOfCustomer[index];
            Customers.selectedName = c.Name;
            Customers.selectedLastName = c.Last_Name;
            Customers.selectedPhone = c.Phone_Number;
            Customers.selectedEmail = c.Email;
            Customers.selectedAddress = c.Address;
            Customers.selectedBalance = c.Balance;
            Customers.selectedSavings = c.Savings;
            Customers.selectedPlan = c.Plan;
            Customers.selectedUserId = c.User_Id;
            Customers.selectedAccount = c.Account_Number;
            Customers.selectedPhoto = c.Photo_Path;

            AccountControl frm = new AccountControl();
            frm.ShowDialog();
        }
    }
}
