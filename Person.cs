using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullTeam_Bank_Management
{
    abstract public class Person
    {
        private string name;
        private string last_Name;
        private string email;
        private string phone_Number;
        private string address;
        private string photo_Path;

        public string Name { get { return name; } set { name = value; } }
        public string Last_Name { get { return last_Name; } set { last_Name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone_Number { get { return phone_Number; } set { phone_Number = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Photo_Path { get { return photo_Path; } set { photo_Path = value; } }
    }
}
