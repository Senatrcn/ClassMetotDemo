using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.NationalId = "12345678";
            customer1.FirstName = "Ali";
            customer1.LastName = "Veli";
            customer1.Birthday = new DateTime(1991, 1, 1);

            Customer customer2 = new Customer();
            customer1.Id = 2;
            customer1.NationalId = "87654321";
            customer1.FirstName = "Ayşe";
            customer1.LastName = "Fatma";
            customer1.Birthday = new DateTime(1987, 12, 22);

            CustomerManager _customerManager = new CustomerManager();

            _customerManager.Add(customer1);
            _customerManager.Update(customer2);
            _customerManager.Delete(customer2);
            _customerManager.GetAll(new Customer[] { customer1, customer2});
        }
    }
}
