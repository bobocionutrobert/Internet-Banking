using InternetBanking.Controller;
using InternetBanking.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.View
{
    public class ViewUser
    {

        private Person person;
        private ControllerBank controllerbank;
        private ControllerPerson controllerpersons;
        private ControllerServices controllerservices;

        public ViewUser(Person person)
        {
            this.person = person;

            controllerbank = new ControllerBank();
            controllerpersons = new ControllerPerson();
            controllerservices = new ControllerServices();
        }

        public void menu()
        {
            Console.WriteLine("Press 1 to view all banks");
            Console.WriteLine("Press 2 to view all services available");
            Console.WriteLine("Press 3 to ");
            Console.WriteLine("Press 4 to  ");
            Console.WriteLine("Press 5 to ");
            Console.WriteLine("Press 6 to ");
            Console.WriteLine("Press 7 to ");


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


                        break;
                    case 1:
                        controllerbank.ToString();
                        break;
                    case 2:
                        controllerservices.ToString();
                        break;
                    case 3:


                        break;
                    case 4:

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
    }
}
