using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class ItemSubItemDTO
    {
        public Guid ItemId { get; set; }
        public Guid SubItemId { get; set; }

        public static ItemSubItemDTO From(ItemSubItem itemSubItem)
        {
            if (itemSubItem == null)
                return new ItemSubItemDTO();

            return new ItemSubItemDTO
            {
                ItemId = itemSubItem.ItemId,
                SubItemId = itemSubItem.SubItemId
            };
        }
    }
}
