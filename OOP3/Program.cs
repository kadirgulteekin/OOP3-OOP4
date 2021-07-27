using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.CustomerId = "123465";
            individualCustomer.CustomerName = "Kadir";
            individualCustomer.CustomerLastName = "Gültekiin";
            individualCustomer.CustomerIdendityNo = "123456789101";


            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerIdendityNo = "4561230";
            corporateCustomer.CustomerCompanyName = "Gig Finances";
            corporateCustomer.CompanyTaxNo = "12345546546";


            Customer customer = new IndividualCustomer();
            Customer customer1 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer1);











        }
    }
}
