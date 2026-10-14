using System;
using Avalonia.Controls;
using Client.Factories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel:ViewModelBase
{    
    private readonly PageViewFactory _factory;

     [ObservableProperty]
    public partial ViewModelBase CurrentView{get;set;}

    public MainWindowViewModel(){}

    public MainWindowViewModel(PageViewFactory factory)
    {
        _factory = factory;
        GoToHome();
        
    }
    [RelayCommand] // GoToHomeCommand
    private void GoToHome()=>CurrentView = _factory.LoadPageViewModel(Helpers.ApplicationNameEnum.Home);
    [RelayCommand] // GoToHomeCommand
    private void GoToProducts()=> CurrentView = _factory.LoadPageViewModel(Helpers.ApplicationNameEnum.Products);
    [RelayCommand] 
    private void GoToCustomers()=> CurrentView = _factory.LoadPageViewModel(Helpers.ApplicationNameEnum.Customers);
    [RelayCommand] 
    private void GoToOrders()=> CurrentView = _factory.LoadPageViewModel(Helpers.ApplicationNameEnum.Orders);

}
