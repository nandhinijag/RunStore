using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : PageViewModel
{
    private IProductService _service;
    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];
    public ProductsViewModel(IProductService service)
    {
        _service=service;
        PageTitle = "Våra Produkter";
        PageName = Helpers.ApplicationNameEnum.Products;
        LoadProducts();
    }
   
    private void LoadProducts()
    {
        try
        {    
            Products= new ObservableCollection<Product>(_service.List());
        }    
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }
    [RelayCommand]
    public void Edit(string id)
    {
        Console.WriteLine("Ändra uppgifter," +id); // can choose any unique ID
    }
    [RelayCommand]
    public void Delete(string id)
    {
        Console.WriteLine("Ta bort produkt,"+id); // can choose any unique ID
    }
 
}

