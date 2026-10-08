using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel:ViewModelBase
{  
     private readonly HomeViewModel _homeView = new();
     private readonly ProductsViewModel _productView = new();
     private readonly CustomersViewModel _customersView = new();
     private readonly OrdersViewModel _ordersView = new();
     [ObservableProperty]
    public partial ViewModelBase CurrentView{get;set;}

    public MainWindowViewModel()
    {
        CurrentView = _homeView;
    }
    [RelayCommand] // GoToHomeCommand
    private void GoToHome()=>CurrentView = _homeView;
    [RelayCommand] // GoToHomeCommand
    private void GoToProducts()=> CurrentView = _productView;
    [RelayCommand] 
    private void GoToCustomers()=> CurrentView = _customersView;
    [RelayCommand] 
    private void GoToOrders()=> CurrentView = _ordersView;

}
