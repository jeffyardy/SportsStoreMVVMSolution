using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStoreValidationDIWpfApp.Products;
using Microsoft.Practices.Unity;
namespace SportsStoreValidationDIWpfApp
{
  public class MainWindowViewModel : BindableBase
  {
    private BindableBase _currentViewModel;
    private ProductListViewModel _productListViewModel;

    public BindableBase CurrentViewodel
    {
      get
      {
        return _currentViewModel;
      }

      set
      {
        SetProperty(ref _currentViewModel, value);
      }
    }

    public RelayCommand<string> NavigateCommand { get; private set; }

    

    public MainWindowViewModel()
    {
      _productListViewModel = SportsStoreContainer.Container.Resolve<ProductListViewModel>();
      NavigateCommand = new RelayCommand<string>(OnNavigate);
    }

    private void OnNavigate(string destination)
    {
      switch(destination)
      {
        default:
          CurrentViewodel = _productListViewModel;
          break;
      }
    }
  }
}
