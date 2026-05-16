using System;

namespace NullTeam_Bank_Management
{
    public class Customers : Person
    {
        public static string selectedName;
        public static string selectedLastName;
        public static string selectedPhone;
        public static string selectedEmail;
        public static string selectedAddress;
        public static int selectedBalance;
        public static int selectedSavings;
        public static string selectedPlan;
        public static string selectedUserId;
        public static string selectedAccount;
        public static string selectedPhoto;

        private string plan;
        public string Plan { get { return plan; } set { plan = value; } }

        private int balance;
        public int Balance
        {
            set { balance = value >= 0 ? value : -value; }
            get { return balance; }
        }

        private int savings;
        public int Savings
        {
            set { savings = value >= 0 ? value : -value; }
            get { return savings; }
        }

        private string account_Number;
        public string Account_Number { get { return account_Number; } set { account_Number = value; } }

        private string user_Id;
        public string User_Id { get { return user_Id; } set { user_Id = value; } }

        public string generateUserId()
        {
            string[] letters = { "A", "B", "C", "D", "E" };
            Random r = new Random();
            string letter = letters[r.Next(0, 5)];
            int number = r.Next(1000, 9999);
            return letter + "-" + number;
        }

        public string generateAccountNumber()
        {
            Random r = new Random();
            int p1 = r.Next(1000, 9999);
            int p2 = r.Next(1000, 9999);
            int p3 = r.Next(1000, 9999);
            return "5585 " + p1 + " " + p2 + " " + p3;
        }

        public string CustomerString()
        {
            return Name + ";" + Last_Name + ";" + Phone_Number + ";" + Email + ";"
                + Address + ";" + Balance + ";" + Plan + ";" + User_Id + ";"
                + Account_Number + ";" + Savings + ";" + Photo_Path;
        }
    }
}