using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    private IProductService _service;
    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];
    public ProductsViewModel(IProductService service)
    {
        PageTitle = "Våra Produkter";
        _service=service;
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
}

