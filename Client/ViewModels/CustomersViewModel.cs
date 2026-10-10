using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
namespace Client.ViewModels;

public partial class CustomersViewModel:ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];
    public CustomersViewModel()
    {
        PageTitle = "Kund Lista";
        LoadCustomer();
    }
    private void LoadCustomer()
    {
       try
        {
           Customers= new ObservableCollection<Customer>(CustomerServices.ListAllCustomers());
        }    
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
