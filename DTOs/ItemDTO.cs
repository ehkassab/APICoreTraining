using System;
using System.ComponentModel.DataAnnotations;

namespace APiCoreTraning.DTOs
{
    public class ItemDTO
    {
        public Guid Id { get; init; }
        [Required]
        public string Name { get; init; }
        [Required]
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}