using Microsoft.AspNetCore.Mvc;
using APiCoreTraning.Repositories;
using APiCoreTraning.Entities;
using System.Collections.Generic;
using System;
using APiCoreTraning.DTOs;
using System.Linq;

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
        public ActionResult<IEnumerable<ItemDTO>> GetItems()
        {
            return Ok(_itemsRepo.GetItems().Select(y=>y.AsDto()));
        }

        [HttpGet("{id}")]
        public ActionResult<ItemDTO> GetItem(Guid id)
        {
            var item = _itemsRepo.GetItem(id)
                .AsDto();
            if (item == null)
                return NotFound();
            else return Ok(item);
        }
    }
}