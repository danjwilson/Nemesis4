using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nemesis.Core
{
    public class Store
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string OpeningHours { get; set; }

        public IEnumerable<ProductType> ProductTypes { get; set; }

        public Store()
        { }

        public Store(string id, string name, string address, string postcode, string openingHours, IEnumerable<ProductType> productTypes)
        {
            Id = id;
            Name = name;
            Address = address;
            Postcode = postcode;
            OpeningHours = openingHours;
            ProductTypes = productTypes;
        }
    }

    public class StoreProduct
    {
        public Store Store { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}