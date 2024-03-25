using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static CategoryDTO From(Category category)
        {
            if (category == null)
                return new CategoryDTO();

            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }
    }
}
