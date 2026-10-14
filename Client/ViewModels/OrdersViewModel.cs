using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace Client.ViewModels;

public partial class OrdersViewModel:PageViewModel
{
public OrdersViewModel()
{
   PageName = Helpers.ApplicationNameEnum.Orders;
}
}
