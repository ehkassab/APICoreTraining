using System;

namespace APiCoreTraning.Entities
{
    
    public record Item
    {
        //- Record Type : use for immutable , with expressions, value based compare.
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}