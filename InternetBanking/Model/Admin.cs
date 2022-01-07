using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Model
{
    public class Admin : Person
    {

        private int adminid;
        private int salary;
        private string username;
        private string password;

        public Admin(int adminid, int salary, string username, string password, int id, string role, string name, string email, string address) : base(id, "User", name, email, address)
        {
            this.adminid = adminid;
            this.salary = salary;
            this.username = username;
            this.password = password;
        }

        public Admin(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.adminid = Int32.Parse(prop[5]);
            this.salary = Int32.Parse(prop[6]);
            this.username = prop[7];
            this.password = prop[8];
        }

        public int Adminid
        {
            get { return this.adminid; }
            set { this.adminid = value; }
        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.adminid + "," + this.salary + "," + this.username + "," + this.password;
        }
    }
}
