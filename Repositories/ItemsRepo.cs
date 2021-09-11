using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiCoreTraning.Entities;

namespace APiCoreTraning.Repositories
{
    public class ItemsRepo : IItemsRepo
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "A", Price = 10, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "B", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "C", Price = 8, CreatedDate = DateTimeOffset.UtcNow }
        };

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.FromResult(items);
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            return  await Task.FromResult(items.Where(u => u.Id == id).FirstOrDefault());
        }

        public async Task<Item> CreateItemAsync(Item item)
        {
            items.Add(item);
            return await GetItemAsync(item.Id);
        }
    }
}