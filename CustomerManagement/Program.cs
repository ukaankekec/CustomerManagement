using System;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer();
            Customer customer5 = new Customer();
            Customer customer6 = new Customer();
            Customer customer7 = new Customer();
            Customer customer8 = new Customer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            customerManager.Add(customer5);
            customerManager.Add(customer6);
            customerManager.Add(customer7);
            customerManager.Add(customer8);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);
            customerManager.Delete(customer7);

            Customer[] customers = new Customer[] { customer1, customer2, customer3,customer4,customer5,customer6,customer7,customer8 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id and Name of the new added customers:" + " " + customer.CustomerId + "-" + customer.CustomerName);
            }
        }
    }
}
