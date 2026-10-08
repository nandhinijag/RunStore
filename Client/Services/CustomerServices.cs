using System;
using System.Collections.Generic;
using Client.Models;

namespace Client.Services;

public class CustomerServices
{
    public static List<Customer> ListAllCustomers()
    {
        return [
            new Customer{FirstName="Anna", LastName="Gustavsson",Email="Anna@mail.com"},
            new Customer{FirstName="Sara", LastName="Olsson",Email="sara@mail.com"}
        ];
    }
}