using InternetBanking.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InternetBanking.Controller
{
    public class ControllerServices
    {
        private List<Services> services;

        public ControllerServices()
        {
            services = new List<Services>();

            load();
        }

        public int positionById(int id)
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].Serviceid == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public int positionByName(string name)
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].Name.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }

        public Services service(int serviceid)
        {
            foreach (Services service in services)
            {
                if (service.Serviceid == serviceid)
                {
                    return service;
                }
            }
            return null;
        }

        public bool addService(Services service)
        {
            int poz = positionById(service.Serviceid);

            if (poz != -1)
            {
                return false;
            }
            else
            {
                services.Add(service);
                return true;
            }
        }

        public bool deleteService(int serviceid)
        {
            int poz = positionById(serviceid);

            if (poz == 1)
            {
                return false;
            }
            else
            {

                services.RemoveAt(poz);
                return true;
            }
        }

        public bool deleteServiceByName(string name)
        {
            int poz = positionByName(name);

            if (poz == 1)
            {
                return false;
            }
            else
            {

                services.RemoveAt(poz);
                return true;
            }
        }

        public void updateName(int id, string name)
        {
            foreach (Services service in services)
            {
                if (service.Serviceid == id)
                {
                    service.Name = name;
                }
            }
        }

        public void updateDescription(int id, string description)
        {
            foreach (Services service in services)
            {
                if (service.Serviceid == id)
                {
                    service.Description = description;
                }
            }
        }

        public void updateDebitsTotal(int id, string total)
        {
            foreach (Services service in services)
            {
                if (service.Serviceid == id)
                {
                    Debits debit = service as Debits;
                    debit.Total = total;
                }
            }
        }

        public void updateDebitsAmount(int id, string amount)
        {
            foreach (Services service in services)
            {
                if (service.Serviceid == id)
                {
                    Debits debit = service as Debits;
                    debit.Amount = amount;
                }
            }
        }

        public void updateCreditTotal(int id, string total)
        {
            foreach (Services service in services)
            {
                if (service.Serviceid == id)
                {
                    Credit credit = service as Credit;
                    credit.Total = total;
                }
            }
        }
        public void updateCreditAmount(int id, string amount)
        {
            foreach (Services service in services)
            {
                if (service.Serviceid == id)
                {
                    Credit credit = service as Credit;
                    credit.Amount = amount;
                }
            }
        }


        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\InternetBanking\InternetBanking\Resources\services.txt");


            string line = "";


            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                if (prop[2].Equals("Credit"))
                {
                    this.services.Add(new Credit(line));

                }
                else
                {
                    this.services.Add(new Debits(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            this.services.ForEach((service) =>
            {

                text += service.ToString() + "\n";


            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\InternetBanking\InternetBanking\Resources\services.txt");
            write.WriteLine(ToString());
            write.Close();
        }
    }
}
