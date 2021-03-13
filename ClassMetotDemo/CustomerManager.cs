using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi : " + customer.FirstName + customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi : " + customer.FirstName + customer.LastName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri güncellendi : " + customer.FirstName + customer.LastName);
        }
        public void GetAll(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + customer.LastName);
            }
        }
    }
}
