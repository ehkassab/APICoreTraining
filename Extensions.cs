using APiCoreTraning.DTOs;
using APiCoreTraning.Entities;

namespace APiCoreTraning
{
    public static class Extensions
    {
        public static ItemDTO AsDto(this Item item)
        {
            return new ItemDTO
            {
                Id= item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}