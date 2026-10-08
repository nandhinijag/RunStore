using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];
    public ProductsViewModel()
    {
        PageTitle = "Våra Produkter";
        LoadProducts();
    }
    private void LoadProducts()
    {
    //    var products = ProductServices.ListAllProducts();
    //    Products = new ObservableCollection<Product>(products);
       Products= new ObservableCollection<Product>(ProductServices.ListAllProducts());
    }
}
