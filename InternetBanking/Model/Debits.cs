using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Model
{
    public class Debits : Services
    {
        private int debitsid;
        private string total;
        private string amount;

        public Debits(int debitsid, string total, string amount, int serviceid, int bankid, string type, string name, string description) : base(serviceid, bankid, "Credit", name, description)
        {
            this.debitsid = debitsid;
            this.total = total;
            this.amount = amount;
        }

        public Debits(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.debitsid = Int32.Parse(prop[5]);
            this.total = prop[6];
            this.amount = prop[7];
        }

        public int Debitsid
        {
            get { return this.debitsid; }
            set { this.debitsid = value; }
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
            return base.ToString() + "," + this.debitsid + "," + this.total + "," + this.amount;
        }
    }
}
