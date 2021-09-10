using Microsoft.AspNetCore.Mvc;
using APiCoreTraning.Repositories;
using APiCoreTraning.Entities;
using System.Collections.Generic;
using System;

namespace APiCoreTraning.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsRepo _itemsRepo;

        public ItemsController()
        {
            _itemsRepo = new ItemsRepo();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return _itemsRepo.GetItems();
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = _itemsRepo.GetItem(id);
            if (item == null)
                return NotFound();
            else return Ok(item);
        }
    }
}