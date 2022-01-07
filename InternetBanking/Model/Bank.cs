using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Model
{
    public class Bank
    { 
        private int id;
        private string name;
        private string branch;
        private string code;
        private string place;
        private string type;
        private string description;
        private int customerid;

        public Bank(int id, string name,string branch,string code,string place,string type,string description, int customerid)
        {
            this.id = id;
            this.name = name;
            this.branch = branch;
            this.code = code;
            this.place = place;
            this.type = type;
            this.description = description;
            this.customerid = customerid;
        }

        public Bank(string props)
        {
            string[] prop = props.Split(",");
            this.id = Int32.Parse(prop[0]);
            this.name = prop[1];
            this.branch = prop[2];
            this.code = prop[3];
            this.place = prop[4];
            this.type = prop[5];
            this.description = prop[6];
            this.customerid = Int32.Parse(prop[7]);
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public string Branch
        {
            get { return this.branch; }
            set { this.branch = value; }
        }

        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        public string Place
        {
            get { return this.place; }
            set { this.code = value; }
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
            }

        }

        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
            }
        }

        public int Customerid
        {
            get { return this.customerid; }
            set { this.customerid = value; }
        }

        public override string ToString()
        {

            return this.id + "," + this.name + "," + this.branch + "," + this.place + "," + this.type + "," + this.description +"," + this.customerid ;

        }


        public override bool Equals(object obj)
        {

            Bank bank = obj as Bank;


            return this.id == bank.id;
        }
    }
}
