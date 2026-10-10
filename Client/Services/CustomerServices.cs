using System;
using System.Collections.Generic;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class CustomerServices
{
     static string path = string.Concat(Environment.CurrentDirectory,"/Data/customers.json");
    static Storage<Customer> customer = new();
    public static List<Customer> ListAllCustomers()
    {
       
        var customers = customer.Read(path);
        return customers;

    }

    public static void StoreCustomers( Customer name)
        
      {  
        var products = customer.Read(path);
        products.Add((Customer)name);
        customer.Write(path,products);
    }
}