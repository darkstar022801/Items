using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class SubCategoryItemDTO
    {
        public Guid SubCategoryId { get; set; }
        public Guid ItemId { get; set; }

        public static SubCategoryItemDTO From(SubCategoryItem subCategoryItem)
        {
            if (subCategoryItem == null)
                return new SubCategoryItemDTO();

            return new SubCategoryItemDTO
            {
                SubCategoryId = subCategoryItem.SubCategoryId,
                ItemId = subCategoryItem.ItemId
            };
        }
    }
}
