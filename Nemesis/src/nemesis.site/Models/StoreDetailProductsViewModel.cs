using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nemesis.Core;

namespace Nemesis.Site.Models
{
    public class StoreDetailProductListViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string OpeningHours { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public StoreDetailProductListViewModel()
        {
        }

        public StoreDetailProductListViewModel(Store store, IQueryable<Product> products)
        {
            Id = store.Id;
            Name = store.Name;
            Address = store.Address;
            Postcode = store.Postcode;
            OpeningHours = store.OpeningHours;
            Products = products;
        }
    }
}