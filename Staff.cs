using System;

namespace NullTeam_Bank_Management
{
    public class Staff : Person
    {
        public static string selectedName;
        public static string selectedLastName;
        public static string selectedPhone;
        public static string selectedEmail;
        public static string selectedAddress;
        public static string selectedRole;
        public static int selectedBalance;
        public static int selectedNormalHours;
        public static int selectedExtraHours;
        public static int selectedSalaryPerHour;
        public static string selectedStaffId;
        public static string selectedPhoto;

        private string role;
        public string Role { get { return role; } set { role = value; } }

        private int staff_Balance;
        public int Staff_Balance
        {
            set { staff_Balance = value >= 0 ? value : -value; }
            get { return staff_Balance; }
        }

        private int normal_Working_Hours;
        public int Normal_Working_Hours
        {
            set { normal_Working_Hours = value >= 0 ? value : -value; }
            get { return normal_Working_Hours; }
        }

        private int extra_Working_Hours;
        public int Extra_Working_Hours
        {
            set { extra_Working_Hours = value >= 0 ? value : -value; }
            get { return extra_Working_Hours; }
        }

        private int salary_Per_Hour;
        public int Salary_Per_Hour
        {
            set { salary_Per_Hour = value >= 0 ? value : -value; }
            get { return salary_Per_Hour; }
        }

        private string staff_Id;
        public string Staff_Id { get { return staff_Id; } set { staff_Id = value; } }

        public string generateStaffId()
        {
            string[] letters = { "T", "L", "X", "Y", "Z" };
            Random r = new Random();
            string letter = letters[r.Next(0, 5)];
            int number = r.Next(1000, 9999);
            return letter + "-" + number;
        }

        public int salaryPerHour()
        {
            if (Role == "General Manager") return 100;
            else if (Role == "Manager") return 70;
            else if (Role == "Cashier") return 50;
            else return 40;
        }

        public string StaffString()
        {
            return Name + ";" + Last_Name + ";" + Phone_Number + ";" + Email + ";"
                + Address + ";" + Role + ";" + Staff_Balance + ";" + Normal_Working_Hours + ";"
                + Extra_Working_Hours + ";" + Salary_Per_Hour + ";" + Staff_Id + ";" + Photo_Path;
        }
    }
}