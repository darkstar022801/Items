using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class PropertyDTO
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public static PropertyDTO From(Property property)
        {
            if (property == null)
                return new PropertyDTO();

            return new PropertyDTO
            {
                Id = property.Id,
                ItemId = property.ItemId,
                Name = property.Name,
                Value = property.Value,
                Description = property.Description
            };
        }
    }
}
