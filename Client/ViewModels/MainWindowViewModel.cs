using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel:ViewModelBase
{  
     private readonly HomeViewModel _homeView ;
     private readonly ProductsViewModel _productView;
     private readonly CustomersViewModel _customersView;
     private readonly OrdersViewModel _ordersView;
     [ObservableProperty]
    public partial ViewModelBase CurrentView{get;set;}

    //public MainWindowViewModel(){}

    public MainWindowViewModel(ProductsViewModel productViewModel,HomeViewModel homeViewModel, CustomersViewModel customersViewModel,OrdersViewModel ordersViewModel)
    {
        
        _productView = productViewModel;
        _homeView = homeViewModel;
        _customersView = customersViewModel;
        _ordersView= ordersViewModel;
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
