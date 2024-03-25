using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class RoleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static RoleDTO From(Role role)
        {
            if (role == null)
                return new RoleDTO();

            return new RoleDTO
            {
                Id = role.Id,
                Name = role.Name
            };
        }
    }
}
