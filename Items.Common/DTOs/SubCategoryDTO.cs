using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class SubCategoryDTO
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static SubCategoryDTO From(SubCategory subCategory)
        {
            if (subCategory == null)
                return new SubCategoryDTO();

            return new SubCategoryDTO
            {
                Id = subCategory.Id,
                CategoryId = subCategory.CategoryId,
                Name = subCategory.Name,
                Description = subCategory.Description
            };
        }
    }
}
