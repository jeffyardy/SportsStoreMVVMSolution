using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SportStoreDomainLibrary.Abstract;
using SportStoreDomainLibrary.Concrete;
using SportStoreDomainLibrary.DataContexts;
using SportStoreDomainLibrary.Entities;
using System.Windows.Input;

namespace BasicSportsStoreWpfApp.Products
{
  public class ProductEditSimpleMVVMViewModel : INotifyPropertyChanged
  {
    IProductRepository _productRepository;
    Product _product;
    public RelayCommand SaveCommand { get; private set; }

    public event PropertyChangedEventHandler PropertyChanged = delegate { };
    public Product Product
    {
      get
      {
        return _product;
      }

      set
      {
        _product = value;

        PropertyChanged(this, new PropertyChangedEventArgs("Product"));
      }
    }

    public int ProductId { get; set; }

    public ProductEditSimpleMVVMViewModel()
    {
      _productRepository = new EfProductRepository();
      SaveCommand = new RelayCommand(OnSave);
    }

    public async void LoadProduct()
    {
      Product = await _productRepository.GetProductAsync(ProductId);
    }

    private async void OnSave()
    {
       Product = await _productRepository.UpdateProductAsync(Product);
    }
  }
}
