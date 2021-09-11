using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(u => u.Id == id).FirstOrDefault();
        }

        public Item CreateItem(Item item)
        {
            items.Add(item);
            return GetItem(item.Id);
        }
    }
}