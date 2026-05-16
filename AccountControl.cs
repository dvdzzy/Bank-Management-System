using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullTeam_Bank_Management
{
    public partial class AccountControl : Form
    {
        public AccountControl()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountControl_Load(object sender, EventArgs e)
        {
            label13.Text = Customers.selectedAccount;
            label14.Text = Customers.selectedUserId;
            label15.Text = Customers.selectedBalance.ToString();
            label16.Text = Customers.selectedSavings.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateFile()
        {
            List<Customers> liste = new List<Customers>();
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
                    liste.Add(c);
                }
            }
            catch
            {
                MessageBox.Show("Error reading file!");
            }
            sr.Close();
            fs.Close();

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].User_Id == Customers.selectedUserId)
                {
                    liste[i].Balance = Customers.selectedBalance;
                    liste[i].Savings = Customers.selectedSavings;
                }
            }

            FileStream fs2 = new FileStream("customers.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            for (int i = 0; i < liste.Count; i++)
            {
                sw.WriteLine(liste[i].CustomerString());
            }
            sw.Close();
            fs2.Close();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            int amount;
            try
            {
                amount = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if (amount > Customers.selectedBalance)
            {
                MessageBox.Show("Insufficient balance!");
                return;
            }

            Customers.selectedBalance = Customers.selectedBalance - amount;
            label15.Text = Customers.selectedBalance.ToString();

            UpdateFile();

            MessageBox.Show("Withdraw successful!");
            textBox1.Clear();
        }

        private void moving_Click(object sender, EventArgs e)
        {
            int amount;
            try
            {
                amount = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if (amount > Customers.selectedBalance)
            {
                MessageBox.Show("Insufficient balance!");
                return;
            }

            Customers.selectedBalance = Customers.selectedBalance - amount;
            Customers.selectedSavings = Customers.selectedSavings + amount;
            label15.Text = Customers.selectedBalance.ToString();
            label16.Text = Customers.selectedSavings.ToString();

            UpdateFile();

            MessageBox.Show("Money moved to savings!");
            textBox2.Clear();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            int amount;
            try
            {
                amount = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            Customers.selectedBalance = Customers.selectedBalance + amount;
            label15.Text = Customers.selectedBalance.ToString();

            UpdateFile();

            MessageBox.Show("Deposit successful!");
            textBox3.Clear();
        }
    }
}
