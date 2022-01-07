using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Model
{
    public class User : Person
    {
        private int personid;
        private string username;
        private string password;

        public User(int personid, string username, string password, int id, string role,string name,string email,string address) : base(id, "User", name, email, address)
        {
            this.personid = personid;
            this.username = username;
            this.password = password;
        }

        public User(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.personid = Int32.Parse(prop[5]);
            this.username = prop[6];
            this.password = prop[7];
        }

        public int Personid
        {
            get { return this.personid; }
            set { this.personid = value; }
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
            return base.ToString() + "," + this.personid+ "," + this.username + "," + this.password;
        }
    }
}
