using SportStoreDomainLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStoreDomainLibrary.Abstract
{
  public interface IProductRepository
  {
    Task<List<Product>> GetProductsAsync();
    Task<List<Product>> GetProductsByCategoryAsync(string categoryName);

    Task<Product> GetProductAsync(int ProductId);
    Task<Product> AddProductAsync(Product product);
    Task<Product> UpdateProductAsync(Product product);

    Task DeleteProductAsync(int productId);

  }
}
