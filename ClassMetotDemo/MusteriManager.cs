﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
           
            Console.WriteLine("Customer Added:" + customer.Id + " " + customer.NameSurname);

        }

        public void Delete(Customer customer)
        {
            
            Console.WriteLine(customer.Id + " " + customer.NameSurname + " "+ "Customer Deleted.");

        }

      
    }
}
