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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            textBox2.Text = Customers.selectedName;
            textBox3.Text = Customers.selectedLastName;
            textBox4.Text = Customers.selectedEmail;
            textBox5.Text = Customers.selectedPhone;
            comboBox1.Text = Customers.selectedPlan;
            textBox6.Text = Customers.selectedAddress;
            textBox1.Text = Customers.selectedAccount;
            textBox7.Text = Customers.selectedUserId;
            textBox9.Text = Customers.selectedBalance.ToString();
            textBox8.Text = Customers.selectedSavings.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(Customers.selectedPhoto);
            }
            catch
            {
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addcustomers_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                Customers.selectedPhoto = "Photos\\" + Path.GetFileName(openFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Invalid image file!");
            }
        }

        private void FileOp(List<Customers> liste)
        {
            FileStream fs = new FileStream("customers.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < liste.Count; i++)
            {
                sw.WriteLine(liste[i].CustomerString());
            }
            sw.Close();
            fs.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string newName = textBox2.Text;
            string newLastName = textBox3.Text;
            string newEmail = textBox4.Text;
            string newPhone = textBox5.Text;
            string newPlan = comboBox1.Text;
            string newAddress = textBox6.Text;
            int newBalance;
            try
            {
                newBalance = Convert.ToInt32(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for Balance!");
                return;
            }

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
                    liste[i].Name = newName;
                    liste[i].Last_Name = newLastName;
                    liste[i].Email = newEmail;
                    liste[i].Phone_Number = newPhone;
                    liste[i].Plan = newPlan;
                    liste[i].Address = newAddress;
                    liste[i].Balance = newBalance;
                    liste[i].Photo_Path = Customers.selectedPhoto;
                }
            }

            FileOp(liste);

            MessageBox.Show("Customer updated!");
            this.Close();

        }
    }
}
