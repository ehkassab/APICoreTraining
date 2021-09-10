using System;
using System.Collections.Generic;
using APiCoreTraning.Entities;

namespace APiCoreTraning.Repositories
{
     public interface IItemsRepo
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}