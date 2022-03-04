using System;
using System.Collections.Generic;

namespace Personalregister_Övning
{

   class Employee
   {

        public string name;
        public int pay;

        public Employee(string _name, int _pay)
        {
            name = _name;
            pay = _pay;
        }
   }

     class Program
     {
        static public List<Employee> employeeList = new List<Employee>();



        static void Main(string[] args)
        {
           


            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu();
            }
            
        }


        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("(1) Läs Register");
            Console.WriteLine("(2) Lägg till ny personal");
            Console.WriteLine("(3) Exit");


            switch (Console.ReadLine())
{
                case "1":
                    ReadRegister();
                    return true;
                case "2":
                    AddEmployee();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        static void AddEmployee()
        {
            Console.Clear();

            Console.WriteLine("Skriv in Namn: ");
            string stringTemp = Console.ReadLine();

            Console.WriteLine("Skriv in lön: ");
            int intTemp = Convert.ToInt32(Console.ReadLine());

            employeeList.Add(new Employee(stringTemp, intTemp));
            Console.WriteLine("Tryck på Valfri knapp för att återvända till menyn.");
            Console.ReadKey();
        }

        static void ReadRegister()
        {
            Console.Clear();

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine("Namn: " + employee.name + "  " + "Lön: " + employee.pay);
            }
            Console.ReadKey();
        }
     }
}
