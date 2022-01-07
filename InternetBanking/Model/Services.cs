using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Model
{
    public class Services
    {
        //serviceid,bankid,type,name,description,creditid,total,amount
        private int serviceid;
        private int bankid;
        private string type;
        private string name;
        private string description;


        public Services(int serviceid,int bankid,string type,string name,string description)
        {
            this.serviceid = serviceid;
            this.bankid = bankid;
            this.type = type;
            this.name = name;
            this.description = description;
        }

        public Services(string props)
        {
            string[] prop = props.Split(",");
            this.serviceid = Int32.Parse(prop[0]);
            this.bankid = Int32.Parse(prop[1]);
            this.type = prop[2];
            this.name = prop[3];
            this.description = prop[4];
        }

        public int Serviceid
        {
            get { return this.serviceid; }
            set { this.serviceid = value; }
        }

        public int Bankid
        {
            get { return this.bankid; }
            set { this.bankid = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public override string ToString()
        {

            return this.serviceid + "," + this.bankid + "," + this.type + "," + this.name + "," + this.description;

        }


        public override bool Equals(object obj)
        {

            Services services = obj as Services;


            return this.serviceid == services.serviceid;
        }
    }
}
