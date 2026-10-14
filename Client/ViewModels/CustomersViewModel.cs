using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
namespace Client.ViewModels;

public partial class CustomersViewModel:PageViewModel
{
    private ICustomerService _customerservice;

    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];
    public CustomersViewModel(ICustomerService customerService)
    {
        _customerservice=customerService;
        PageName = Helpers.ApplicationNameEnum.Customers;
        PageTitle = "Kund Lista";
        
        LoadCustomer();
        
    }
    private void LoadCustomer()
    {
       try
        {
           Customers= new ObservableCollection<Customer>(_customerservice.List());
        }    
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
