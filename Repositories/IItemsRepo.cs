using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APiCoreTraning.Entities;

namespace APiCoreTraning.Repositories
{
     public interface IItemsRepo
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task<Item> CreateItemAsync(Item item);
    }
}