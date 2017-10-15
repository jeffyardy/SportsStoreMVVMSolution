using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStoreDomainLibrary.Abstract;
using SportStoreDomainLibrary.Concrete;
using SportStoreDomainLibrary.Entities;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace SportsStoreValidationDIWpfApp.Products
{
  public class ProductListViewModel : BindableBase
  {
    private IProductRepository _productRepository;
    private ObservableCollection<Product> _products;
    private List<Product> _allProducts;

    public ObservableCollection<Product> Products
    {
      get { return _products; }
      set { SetProperty(ref _products, value); }
    }

  public ProductListViewModel(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }


    public void LoadProducts()
    {
      GetAllProducts();
      GetProducts();
    }


    private void GetProducts()
    {
      Products = new ObservableCollection<Product>(_allProducts);
    }


    private void GetAllProducts()
    {
      _allProducts = _productRepository.GetProductsAsync().Result;
    }


  }
}
