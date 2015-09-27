using System.Linq;

namespace Nemesis.Core
{
    public interface IRepository
    {
        IQueryable<Store> Stores { get; set; }
        IQueryable<ProductType> ProductTypes { get; set; }
        IQueryable<Product> Products { get; set; }
        IQueryable<StoreProduct> StoreProducts { get; set; }
    }
}