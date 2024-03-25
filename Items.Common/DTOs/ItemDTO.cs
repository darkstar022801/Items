using System;
using System.Collections.Generic;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class ItemDTO
    {
        public Guid Id { get; set; }
        public List<PropertyDTO> PropertyList { get; set; }
        public List<SubCategoryItemDTO> SubCategoryItemList { get; set; }
        public List<ItemSubItemDTO> ItemSubItemList { get; set; }

        public static ItemDTO From(Item item)
        {
            if (item == null)
                return new ItemDTO();

            List<PropertyDTO> propertyList = new List<PropertyDTO>();
            if (item.Properties != null && item.Properties.Count > 0)
            {
                item.Properties.ForEach(property => propertyList.Add(PropertyDTO.From(property)));
            }

            List<SubCategoryItemDTO> subcategoryItemList = new List<SubCategoryItemDTO>();
            if (item.SubCategoryItems != null && item.SubCategoryItems.Count > 0)
            {
                item.SubCategoryItems.ForEach(subCategoryItem => subcategoryItemList.Add(SubCategoryItemDTO.From(subCategoryItem)));
            }

            List<ItemSubItemDTO> itemSubItemList = new List<ItemSubItemDTO>();
            if (item.ItemSubItems != null && item.ItemSubItems.Count > 0)
            {
                item.ItemSubItems.ForEach(itemSubItem =>
                {
                    itemSubItemList.Add(ItemSubItemDTO.From(itemSubItem));
                });
            }

            return new ItemDTO
            {
                Id = item.Id,
                PropertyList = propertyList,
                SubCategoryItemList = subcategoryItemList,
                ItemSubItemList = itemSubItemList
            };
        }
    }
}
