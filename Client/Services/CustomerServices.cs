using System;
using Client.Models;
using System.Collections.Generic;
namespace Client.Services;

public class CustomerServices
{
   
        public static List<Customer> ListAllCustomers()
    {
        return[
            new Customer{FirstName = "Ana",LastName="Peter", Phone="09876544323",EPost="abcd@gmail.com"},
            new Customer{FirstName = "Sara",LastName="Peter",Phone="07825536777",EPost="efg@gmail.com"}
        ];
    }
        
    

}
