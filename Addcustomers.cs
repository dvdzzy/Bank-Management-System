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
    public partial class Addcustomers : Form
    {
        private string _photo_Path;

        public Addcustomers()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                _photo_Path = "Photos\\" + Path.GetFileName(openFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Invalid image file!");
            }
        }

        private void customerid_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.Name = textBox1.Text;
            c.Last_Name = textBox2.Text;
            c.Phone_Number = textBox3.Text;
            c.Email = textBox4.Text;
            c.Address = textBox5.Text;
            try
            {
                c.Balance = Convert.ToInt32(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for Balance!");
                return;
            }
            c.Plan = comboBox1.Text;
            c.User_Id = textBox7.Text;
            c.Account_Number = textBox8.Text;
            c.Savings = 0;
            c.Photo_Path = _photo_Path;

            FileStream fs = new FileStream("customers.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(c.CustomerString());
            sw.Close();
            fs.Close();

            MessageBox.Show("Customer added!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addcustomers_Load(object sender, EventArgs e)
        {
            Customers c = new Customers();
            textBox7.Text = c.generateUserId();
            textBox8.Text = c.generateAccountNumber();
        }
    }
}
