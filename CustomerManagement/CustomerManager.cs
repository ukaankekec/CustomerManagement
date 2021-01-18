using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement
{
    public class CustomerManager
    {
        //bool newCustomer = true;
        //bool errorSolving = true;
        public void Add(Customer customer)
        {
            Console.WriteLine("Id:");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("Surname:");
            customer.CustomerSurname = Console.ReadLine();
            Console.WriteLine("Age:");
            customer.CustomerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gender:");
            customer.CustomerGender = Console.ReadLine();
            //while (newCustomer)
            //{
            //    Console.WriteLine("Customer Added!!-If you want to add new customer please key 'y' if you do not please key 'n' ");
            //    string newCustomerControl;
            //    newCustomerControl = Console.ReadLine();
            //    if (newCustomerControl== "y")
            //    {
            //        newCustomer = true;
            //    }
            //    else if(newCustomerControl=="n")
            //    {
            //        newCustomer = false;
            //    }
            //    else
            //    {
            //        while (errorSolving)
            //        {
            //            string errorSolvingControl;
            //            Console.WriteLine("please key 'y' or 'n' ");
            //            errorSolvingControl = Console.ReadLine();
            //            if (errorSolvingControl=="y")
            //            {
            //                errorSolving = false;
            //            }
            //            else if (errorSolvingControl=="n")
            //            {
            //                errorSolving = false;
            //                newCustomer = false;
            //            }
            //            else
            //            {
            //                errorSolving = true;
            //            }

            //        }
            //    }

            //}

        }

        public void Delete(Customer customer)
        {
            customer.CustomerId = 0;
            customer.CustomerName = "";
            customer.CustomerSurname = "";
            customer.CustomerAge = 0;
            customer.CustomerGender = "";
        }
    }
}
