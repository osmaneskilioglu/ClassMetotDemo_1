using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 3301;
            customer1.NameSurname = "Yamac Kocovali";
            customer1.PhoneNumber =  05001234567;
            customer1.Address = "Cukur";

            Customer customer2 = new Customer();
            customer2.Id = 3302;
            customer2.NameSurname = "Idris Kocovali";
            customer2.PhoneNumber = 05007654321;
            customer2.Address = "Cukur";


            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var customer in customers )
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.NameSurname);
                Console.WriteLine(customer.PhoneNumber);
                Console.WriteLine(customer.Address);
                Console.WriteLine("***********************************");
            }

            CustomerManager CM = new CustomerManager();
            CM.Add(customer1);
            CM.Add(customer2);
            CM.Delete(customer2);
           



        }
    }
}