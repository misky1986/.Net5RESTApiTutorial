using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog.Extensions
{
    public static class ItemMapper
    {
        public static ItemResponseDto AsDto(this Item item)
        {
            return new ItemResponseDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}
