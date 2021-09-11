using Microsoft.AspNetCore.Mvc;
using APiCoreTraning.Repositories;
using APiCoreTraning.Entities;
using System.Collections.Generic;
using System;
using APiCoreTraning.DTOs;
using System.Linq;
using System.Threading.Tasks;

namespace APiCoreTraning.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepo _itemsRepo;

        public ItemsController(IItemsRepo repository)
        {
            _itemsRepo = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDTO>>> GetItemsAsync()
        {
            return  Ok(await _itemsRepo.GetItemsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDTO>> GetItemAsync(Guid id)
        {
            var item =  await _itemsRepo.GetItemAsync(id);
            if (item == null)
                return NotFound();
            else return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<ItemDTO>> CreateItem(ItemDTO itemDto)
        {
            Item item = new Item{
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };
            return Ok(await _itemsRepo.CreateItemAsync(item));
        }

    }
}