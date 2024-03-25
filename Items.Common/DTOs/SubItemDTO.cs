using System;
using System.Collections.Generic;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class SubItemDTO
    {
        public Guid Id { get; set; }
        public List<SubItemPropertyDTO> SubItemPropertyList { get; set; }

        public static SubItemDTO From(SubItem subItem)
        {
            if (subItem == null)
                return new SubItemDTO();

            List<SubItemPropertyDTO> subItemPropertyList = new List<SubItemPropertyDTO>();
            if (subItem.SubItemProperties != null && subItem.SubItemProperties.Count > 0)
            {
                subItem.SubItemProperties.ForEach(subItemProperty => subItemPropertyList.Add(SubItemPropertyDTO.From(subItemProperty)));
            }

            return new SubItemDTO
            {
                Id = subItem.Id,
                SubItemPropertyList = subItemPropertyList,
            };
        }
    }
}
