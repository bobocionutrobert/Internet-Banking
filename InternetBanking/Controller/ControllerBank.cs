using InternetBanking.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InternetBanking.Controller
{
    public class ControllerBank
    {

        private List<Bank> banks;

        public ControllerBank()
        {
            banks = new List<Bank>();

            load();
        }

        public int positionbyId(int id)
        {
            for (int i = 0; i < banks.Count; i++)
            {
                if (banks[i].Id == id)
                {
                    return i;

                }

            }
            return -1;
        }

        public int positionbyName(string name)
        {
            for (int i = 0; i < banks.Count; i++)
            {
                if (banks[i].Name.Equals(name))
                {
                    return i;

                }

            }
            return -1;
        }

        public Bank bankById(int id)
        {
            foreach (Bank bank in banks)
            {
                if (bank.Id == id)
                {
                    return banks[id];
                }
            }
            return null;

        }

        public bool addBank(Bank bank)
        {
            int poz = positionbyId(bank.Id);

            if (poz != -1)
            {
                return false;
            }
            else
            {
                banks.Add(bank);
                return true;
            }
        }

        public bool deleteBank(int id)
        {
            int poz = positionbyId(id);
            if (poz == 1)
            {
                return false;
            }
            else
            {

                banks.RemoveAt(poz);
                return true;
            }
        }

        public bool deleteBankByName(string name)
        {
            int poz = positionbyName(name);
            if (poz == 1)
            {
                return false;
            }
            else
            {

                banks.RemoveAt(poz);
                return true;
            }
        }

        public void updatePlace(int id, string place)
        {
            foreach (Bank bank in banks)
            {
                if (bank.Id == id)
                {
                    bank.Place = place;
                }
            }
        }

        public void updateCode(int id, string code)
        {
            foreach (Bank bank in banks)
            {
                if (bank.Id == id)
                {
                    bank.Code = code;
                }
            }
        }

        public void updateDescription(int id, string description)
        {
            foreach (Bank bank in banks)
            {
                if (bank.Id == id)
                {
                    bank.Description = description;
                }
            }
        }

        public void updateCode(int id, int customerid)
        {
            foreach (Bank bank in banks)
            {
                if (bank.Id == id)
                {
                    bank.Customerid = customerid;
                }
            }
        }

        public void load()
        {

            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\InternetBanking\InternetBanking\Resources\banks.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                this.banks.Add(new Bank(line));
            }

            read.Close();


        }
        public override string ToString()
        {
            string text = "";

            this.banks.ForEach((bank) =>
            {
                text += bank.ToString() + "\n";

            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\InternetBanking\InternetBanking\Resources\banks.txt");

            write.WriteLine(ToString());
            write.Close();

        }
    }
}
