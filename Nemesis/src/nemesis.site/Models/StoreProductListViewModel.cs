using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nemesis.Core;


namespace Nemesis.Site.Models
{
    public class StoreProductListViewModel
    {
        public IEnumerable<StoreProduct> StoreProducts { get; set; }
     
        public StoreProductListViewModel(IQueryable<StoreProduct> storeProducts)
        {
            StoreProducts = storeProducts;
        }
    }
}