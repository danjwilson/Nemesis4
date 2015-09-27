using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Nemesis.Core
{
    public class Repository : IRepository
    {
        public IQueryable<Store> Stores { get; set; }
        public IQueryable<ProductType> ProductTypes { get; set; }
        public IQueryable<Product> Products { get; set; }
        public IQueryable<StoreProduct> StoreProducts { get; set; }

        public Repository()
        {
            ProductTypes = SeedProductTypes();
            Products = SeedProducts();
            Stores = SeedStores();
            StoreProducts = SeedStoreProducts();
        }

        private IQueryable<ProductType> SeedProductTypes()
        {
            return new List<ProductType>
            {
                new ProductType { Id=201, Name="Fish" },
                new ProductType { Id=202, Name="Rabbit food" },
                new ProductType { Id=204, Name="Cat food" },
                new ProductType { Id=205, Name="Light bulbs" },
                new ProductType { Id=206, Name="Mobile Technology" },
                new ProductType { Id=207, Name="Rabbit Accessories" },
                new ProductType { Id=999, Name="Other" }
            }.AsQueryable();
        }

        private IQueryable<Product> SeedProducts()
        {
            return new List<Product>
            {
                new Product { Id=1001, Name="Cod Fillet", Description="Young's Skinless & Boneless Atlantic Cod Chunky Fillets", Type = ProductTypes.First(t => t.Id==201) },
                new Product { Id=1002, Name="Smoked Salmon", Description="Alaskan smoked salmon", Type = ProductTypes.First(t => t.Id==201) },
                new Product { Id=1003, Name="Haddock in Bread Crumb", Description="Birds Eye Simply Haddock In bread crumb", Type = ProductTypes.First(t => t.Id==201) },
                new Product { Id=1004, Name="Halogen Light Bulb", Description="Halogen Candle B22 Bayonet Cap Bulb 28w", Type = ProductTypes.First(t => t.Id==205) },
                new Product { Id=1005, Name="Apple iPad Air", Description="Apple iPad Air 2 with retina display", Type = ProductTypes.First(t => t.Id==206) },
                new Product { Id=1006, Name="Carrot Crunch Rabbit Food", Description="Walter Harrison's Furry Friends Rabbit Carrot Crunch Food - Dry - 15kg Bag", Type = ProductTypes.First(t => t.Id==202) },
                new Product { Id=1007, Name="Rabbit Cage", Description="Little Friends Double Indoor Rabbit Cage 100Cm - Blue Base And Black Bars", Type = ProductTypes.First(t => t.Id==207) },
                new Product { Id=1008, Name="Adult Cat Food", Description="Whiskas Adult Cat Food Chicken & Vegetables 10kg", Type = ProductTypes.First(t => t.Id==204) }
            }.AsQueryable();
        }

        private IQueryable<Store> SeedStores()
        {
            return new List<Store>
            {
                new Store("davesfish", "Dave's Fish Shop", "Some address", "SE1 0BH", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==201) }),
                new Store("acdc", "ACDC Electical Supplies", "Some address", "SE1 6HD", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==205), ProductTypes.First(t => t.Id==206) }),
                new Store("patspet", "Pat's Pet Food", "Some address", "SE1 3NH", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==202), ProductTypes.First(t => t.Id==204), ProductTypes.First(t => t.Id==207) }),
                new Store("swarkconv", "Southwark Convenience Store", "Some address", "SE1 2BB", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==205), ProductTypes.First(t => t.Id==999) }),
                new Store("diystore", "The DIY Store", "Some address", "W14 4UK", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==999) }),
                new Store("yeoldepie", "Ye Olde Pie Shop", "Some address", "W14 1DS", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==999) }),
                new Store("harveyflorist", "Harvey Florist", "Some address", "W14 3XX", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==999) }),
                new Store("bethnalcoffee", "Bethnal Coffee Supplies", "Some address", "E2 2EE", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==999) }),
                new Store("aafood", "A&A Food Mart", "Some address", "E2 6HD", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==999) }),
                new Store("fashionwarehouse", "Fashion Warehouse", "Some address", "SE3 3NH", "TBC", new List<ProductType> { ProductTypes.First(t => t.Id==999) })
            }.AsQueryable();
        }

        private IQueryable<StoreProduct> SeedStoreProducts()
        {
            return new List<StoreProduct>
            {
                new StoreProduct { Product = Products.First(d => d.Id==1001), Store = Stores.First(s => s.Id=="davesfish"), Quantity=10 },
                new StoreProduct { Product = Products.First(d => d.Id==1002), Store = Stores.First(s => s.Id=="davesfish"), Quantity=4 },
                new StoreProduct { Product = Products.First(d => d.Id==1003), Store = Stores.First(s => s.Id=="davesfish"), Quantity=0 },
                new StoreProduct { Product = Products.First(d => d.Id==1004), Store = Stores.First(s => s.Id=="acdc"), Quantity=34 },
                new StoreProduct { Product = Products.First(d => d.Id==1005), Store = Stores.First(s => s.Id=="acdc"), Quantity=2 },
                new StoreProduct { Product = Products.First(d => d.Id==1006), Store = Stores.First(s => s.Id=="patspet"), Quantity=26 },
                new StoreProduct { Product = Products.First(d => d.Id==1007), Store = Stores.First(s => s.Id=="patspet"), Quantity=1 },
                new StoreProduct { Product = Products.First(d => d.Id==1008), Store = Stores.First(s => s.Id=="patspet"), Quantity=32 }
            }.AsQueryable();
        }
    }
}
