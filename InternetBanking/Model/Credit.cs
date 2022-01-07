using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Model
{
    public class Credit : Services
    {
        private int creditid;
        private string total;
        private string amount;

        public Credit(int creditid,string total, string amount, int serviceid,int bankid,string type, string name,string description) : base(serviceid, bankid, "Credit", name, description)
        {
            this.creditid = creditid;
            this.total = total;
            this.amount = amount;
        }

        public Credit(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.creditid = Int32.Parse(prop[5]);
            this.total = prop[6];
            this.amount = prop[7];
        }

        public int Creditid
        {
            get { return this.creditid; }
            set { this.creditid = value; }
        }

        public string Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public string Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.creditid + "," + this.total + "," + this.amount;
        }
    }
}
