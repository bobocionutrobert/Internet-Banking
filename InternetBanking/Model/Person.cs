using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Model
{
    public class Person
    {
        private int id;
        private string role;
        private string name;
        private string email;
        private string address;
        
        public Person(int id, string role,string name,string email,string address)
        {
            this.id = id;
            this.role = role;
            this.name = name;
            this.email = email;
            this.address = address;
        }

        public Person(string props)
        {
            string[] prop = props.Split(",");
            this.id = Int32.Parse(prop[0]);
            this.role = prop[1];
            this.name = prop[2];
            this.email = prop[3];
            this.address = prop[4];
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                this.address = value;
            }
        }

        public override string ToString()
        {

            return this.id + "," + this.role + "," + this.name + "," + this.email + "," + this.address;

        }


        public override bool Equals(object obj)
        {

            Person person = obj as Person;


            return this.id == person.id;
        }
    }
}
