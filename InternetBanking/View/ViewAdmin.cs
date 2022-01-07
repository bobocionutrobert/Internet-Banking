using InternetBanking.Controller;
using InternetBanking.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.View
{
    public class ViewAdmin
    {

        private Person person;
        private ControllerBank controllerbank;
        private ControllerPerson controllerpersons;
        private ControllerServices controllerservices;

        public ViewAdmin(Person person)
        {
            this.person = person;

            controllerbank = new ControllerBank();
            controllerpersons = new ControllerPerson();
            controllerservices = new ControllerServices();
        }

        public void menu()
        {
            Console.WriteLine("Press 1 to view all banks");
            Console.WriteLine("Press 2 to add new bank ");
            Console.WriteLine("Press 3 to delete bank ");
            Console.WriteLine("Press 4 to add new user  ");
            Console.WriteLine("Press 5 to delete user ");
            Console.WriteLine("Press 6 to new service ");
            Console.WriteLine("Press 7 to delete service");


        }

        public void play()
        {
            bool running = true;
            while (running == true)
            {
                menu();

                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        controllerbank.ToString();

                        break;
                    case 1:
                        addNewBank();
                        break;
                    case 2:
                        deleteBank();
                        break;
                    case 3:

                        addNewUser();
                        break;
                    case 4:
                        deleteUser();
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;
                    case 7:
                        
                        break;
                }
            }
        }
        //id,name,branch,code,place,type,description,customerid
        public void addNewBank()
        {
            Random random = new Random();
            int id = random.Next(10, 20);
            int customerid = random.Next(10, 20);

            Console.WriteLine("Insert Bank name : ");

            string bankname = Console.ReadLine();

            Console.WriteLine("Insert bank branch : ");

            string bankbranch = Console.ReadLine();

            Console.WriteLine("Insert bank code : ");
            string bankcode = Console.ReadLine();
            
            Console.WriteLine("Insert bank place : ");
            string bankplace = Console.ReadLine();

            string type = "Bank";

            Console.WriteLine("Insert bank description : ");
            string bankdescription = Console.ReadLine();



            Bank b = new Bank(id, bankname, bankbranch, bankcode, bankplace, type, bankdescription, customerid);

        }

        public void deleteBank()
        {
            Console.WriteLine("Insert the bank name you want to delete : ");
            string deletebank = Console.ReadLine();

            controllerbank.deleteBankByName(deletebank);
        }
        //id,role,name,email,address,iduser,username,password
        public void addNewUser()
        {

            Random random = new Random();
            int id = random.Next(10, 20);
            int iduser = random.Next(10, 20);
            string role = "User";

            Console.WriteLine("Insert person name : ");

            string name = Console.ReadLine();

            Console.WriteLine("Insert person email : ");

            string email = Console.ReadLine();

            Console.WriteLine("Insert person address : ");
            string address = Console.ReadLine();

            Console.WriteLine("Insert username : ");
            string username = Console.ReadLine();


            Console.WriteLine("Insert password : ");
            string password = Console.ReadLine();

            User u = new User(iduser, username, password, id, role, name, email, address);
        }

        public void deleteUser()
        {
            Console.WriteLine("Insert the user name you want to delete : ");
            string deleteuser = Console.ReadLine();

            controllerpersons.deletePersonByName(deleteuser);
        }
        //serviceid,bankid,type,name,description,creditid,total,amount
        public void addNewCredit()
        {
            Random random = new Random();
            int serviceid = random.Next(10, 20);
            int creditid = random.Next(10, 20);
            string type = "Credit";

            Console.WriteLine("Insert bank id : ");
            int bankid = Int32.Parse(Console.ReadLine());
            Console.WriteLine("insert bank name : ");
            string name = Console.ReadLine();
           
            Console.WriteLine("insert the service description : ");
            string description = Console.ReadLine();
            Console.WriteLine("Insert credit total : ");
            string total = Console.ReadLine();
            Console.WriteLine("insert credit amount : ");
            string amount = Console.ReadLine();

            Credit credit = new Credit(creditid, total, amount, serviceid, bankid, type, name, description);
        }
    }
}
