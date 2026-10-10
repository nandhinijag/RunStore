using System;
using System.Collections.Generic;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class ProductServices
{
    static string path = string.Concat(Environment.CurrentDirectory,"/Data/products.json");
    static Storage<Product> storage = new();
    public static List<Product> ListAllProducts()
    {
       
        var products = storage.Read(path);
        return products;

    }

    public static void StoreProducts( Product item)
        
      {  
        var products = storage.Read(path);
        products.Add((Product)item);
        storage.Write(path,products);
    }

}

