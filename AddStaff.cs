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
    public partial class AddStaff : Form

    {
        private string _photo_Path;
        public AddStaff()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            Staff s = new Staff();
            staffidBox.Text = s.generateStaffId();
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

        private void add_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Name = textBox1.Text;
            s.Last_Name = textBox2.Text;
            s.Phone_Number = textBox3.Text;
            s.Email = textBox4.Text;
            s.Address = textBox5.Text;
            s.Role = comboBox1.Text;
            s.Staff_Id = staffidBox.Text;
            s.Photo_Path = _photo_Path;
            s.Staff_Balance = 0;
            s.Normal_Working_Hours = 0;
            s.Extra_Working_Hours = 0;
            s.Salary_Per_Hour = s.salaryPerHour();

            FileStream fs = new FileStream("staff.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(s.StaffString());
            sw.Close();
            fs.Close();

            MessageBox.Show("Staff added!");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
