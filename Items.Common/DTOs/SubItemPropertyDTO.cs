using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class SubItemPropertyDTO
    {
        public Guid Id { get; set; }
        public Guid SubItemId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public static SubItemPropertyDTO From(SubItemProperty subItemProperty)
        {
            if (subItemProperty == null)
                return new SubItemPropertyDTO();

            return new SubItemPropertyDTO
            {
                Id = subItemProperty.Id,
                SubItemId = subItemProperty.SubItemId,
                Name = subItemProperty.Name,
                Value = subItemProperty.Value,
                Description = subItemProperty.Description
            };
        }
    }
}

