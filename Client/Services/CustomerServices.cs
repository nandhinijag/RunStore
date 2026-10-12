using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class CustomerServices : ICustomerService
{
     
    public List<Customer> List()
    {
        Storage<Customer> customer = new();
        string path = string.Concat(Environment.CurrentDirectory,"/Data/customers.json");
        var customers = customer.Read(path);
        return customers;

    }

}

