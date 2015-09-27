using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nemesis.Core;

namespace Nemesis.Site.Models
{
    public class StoreListViewModel
    {
        public IEnumerable<Store> Stores { get; set; }

        public StoreListViewModel(IQueryable<Store> stores)
        {
            Stores = stores;
        }
    }
}
