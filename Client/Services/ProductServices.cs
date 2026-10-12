using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class ProductServices:IProductService
{
   
    public  List<Product> List()
    {
       
        Storage<Product> storage = new();
        string path = string.Concat(Environment.CurrentDirectory,"/Data/products.json");
        var products = storage.Read(path);
        return products;

    }

    
}

