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
    public partial class ShowStaff : Form
    {
        List<Staff> listOfStaff = new List<Staff>();
        int index = 0;
        public ShowStaff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("staff.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    string[] word = sr.ReadLine().Split(';');
                    Staff s = new Staff();
                    s.Name = word[0];
                    s.Last_Name = word[1];
                    s.Phone_Number = word[2];
                    s.Email = word[3];
                    s.Address = word[4];
                    s.Role = word[5];
                    s.Staff_Balance = Convert.ToInt32(word[6]);
                    s.Normal_Working_Hours = Convert.ToInt32(word[7]);
                    s.Extra_Working_Hours = Convert.ToInt32(word[8]);
                    s.Salary_Per_Hour = Convert.ToInt32(word[9]);
                    s.Staff_Id = word[10];
                    s.Photo_Path = word[11];
                    listOfStaff.Add(s);
                }
            }
            catch
            {
                MessageBox.Show("Error reading file!");
            }

            sr.Close();
            fs.Close();

            Staff st = listOfStaff[index];
            label13.Text = st.Staff_Id;
            label14.Text = st.Name;
            label15.Text = st.Last_Name;
            label16.Text = st.Email;
            label17.Text = st.Phone_Number;
            label18.Text = st.Address;
            label19.Text = st.Role;
            label20.Text = st.Normal_Working_Hours.ToString();
            label21.Text = st.Extra_Working_Hours.ToString();
            label22.Text = st.Salary_Per_Hour.ToString();
            label23.Text = st.Staff_Balance.ToString();

            try
            {
                pictureBox1.Image = Image.FromFile(st.Photo_Path);
            }
            catch
            {
            }

            page1.Text = (index + 1) + " From " + listOfStaff.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;

                Staff st = listOfStaff[index];
                label13.Text = st.Staff_Id;
                label14.Text = st.Name;
                label15.Text = st.Last_Name;
                label16.Text = st.Email;
                label17.Text = st.Phone_Number;
                label18.Text = st.Address;
                label19.Text = st.Role;
                label20.Text = st.Normal_Working_Hours.ToString();
                label21.Text = st.Extra_Working_Hours.ToString();
                label22.Text = st.Salary_Per_Hour.ToString();
                label23.Text = st.Staff_Balance.ToString();

                try
                {
                    pictureBox1.Image = Image.FromFile(st.Photo_Path);
                }
                catch
                {
                }

                page1.Text = (index + 1) + " From " + listOfStaff.Count;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < listOfStaff.Count - 1)
            {
                index++;

                Staff st = listOfStaff[index];
                label13.Text = st.Staff_Id;
                label14.Text = st.Name;
                label15.Text = st.Last_Name;
                label16.Text = st.Email;
                label17.Text = st.Phone_Number;
                label18.Text = st.Address;
                label19.Text = st.Role;
                label20.Text = st.Normal_Working_Hours.ToString();
                label21.Text = st.Extra_Working_Hours.ToString();
                label22.Text = st.Salary_Per_Hour.ToString();
                label23.Text = st.Staff_Balance.ToString();

                try
                {
                    pictureBox1.Image = Image.FromFile(st.Photo_Path);
                }
                catch
                {
                }

                page1.Text = (index + 1) + " From " + listOfStaff.Count;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffmanaging_Click(object sender, EventArgs e)
        {
            Staff s = listOfStaff[index];
            Staff.selectedName = s.Name;
            Staff.selectedLastName = s.Last_Name;
            Staff.selectedPhone = s.Phone_Number;
            Staff.selectedEmail = s.Email;
            Staff.selectedAddress = s.Address;
            Staff.selectedRole = s.Role;
            Staff.selectedBalance = s.Staff_Balance;
            Staff.selectedNormalHours = s.Normal_Working_Hours;
            Staff.selectedExtraHours = s.Extra_Working_Hours;
            Staff.selectedSalaryPerHour = s.Salary_Per_Hour;
            Staff.selectedStaffId = s.Staff_Id;
            Staff.selectedPhoto = s.Photo_Path;

            StaffControl frm = new StaffControl();
            frm.ShowDialog();
        }
    }
}
