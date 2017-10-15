using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using SportStoreDomainLibrary.Abstract;
using SportStoreDomainLibrary.Concrete;

namespace SportsStoreValidationDIWpfApp
{
  public class SportsStoreContainer
  {
    private static UnityContainer _unityContainer;

    static SportsStoreContainer()
    {
      _unityContainer = new UnityContainer();
      AddBindings();
    }

    public static UnityContainer Container { get { return _unityContainer; } }

    public static void AddBindings()
    {
      _unityContainer.RegisterType<IProductRepository, EfProductRepository>(new ContainerControlledLifetimeManager());
    }

  }
}
