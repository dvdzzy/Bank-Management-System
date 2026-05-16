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
    public partial class StaffControl : Form
    {
        public StaffControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffControl_Load(object sender, EventArgs e)
        {
            label13.Text = Staff.selectedStaffId;
            label8.Text = Staff.selectedNormalHours.ToString();
            label10.Text = Staff.selectedExtraHours.ToString();
            int unpayedBalance = Staff.selectedNormalHours * Staff.selectedSalaryPerHour
                               + (int)(Staff.selectedExtraHours * Staff.selectedSalaryPerHour * 1.4);
            label11.Text = unpayedBalance.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateFile()
        {
            List<Staff> liste = new List<Staff>();
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
                    liste.Add(s);
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
                if (liste[i].Staff_Id == Staff.selectedStaffId)
                {
                    liste[i].Normal_Working_Hours = Staff.selectedNormalHours;
                    liste[i].Extra_Working_Hours = Staff.selectedExtraHours;
                    liste[i].Staff_Balance = Staff.selectedBalance;
                }
            }

            FileStream fs2 = new FileStream("staff.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            for (int i = 0; i < liste.Count; i++)
            {
                sw.WriteLine(liste[i].StaffString());
            }
            sw.Close();
            fs2.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int normalHour;
            int extraHour;

            try
            {
                normalHour = Convert.ToInt32(textBox1.Text);
                extraHour = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!");
                return;
            }

            Staff.selectedNormalHours = Staff.selectedNormalHours + normalHour;
            Staff.selectedExtraHours = Staff.selectedExtraHours + extraHour;

            label8.Text = Staff.selectedNormalHours.ToString();
            label10.Text = Staff.selectedExtraHours.ToString();

            int unpayedBalance = Staff.selectedNormalHours * Staff.selectedSalaryPerHour
                               + (int)(Staff.selectedExtraHours * Staff.selectedSalaryPerHour * 1.4);
            label11.Text = unpayedBalance.ToString();

            UpdateFile();

            MessageBox.Show("Hours added!");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            int unpayedBalance = Staff.selectedNormalHours * Staff.selectedSalaryPerHour
                               + (int)(Staff.selectedExtraHours * Staff.selectedSalaryPerHour * 1.4);

            if (unpayedBalance == 0)
            {
                MessageBox.Show("Nothing to pay!");
                return;
            }
            Staff.selectedBalance = Staff.selectedBalance + unpayedBalance;
            Staff.selectedNormalHours = 0;
            Staff.selectedExtraHours = 0;
            label8.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            UpdateFile();
            MessageBox.Show("Staff paid! Amount: " + unpayedBalance);
        }
    }
}
