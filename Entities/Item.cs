using System;

namespace Catalog.Entities
{
    // Imutable type that can not be changed after initialization
    public record Item
    {
        // Init means that the property can only be set during the initialization of the object.
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}