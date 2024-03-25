using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class UserRoleDTO
    {
        public Guid Id { get; set; }

        public UserDTO User { get; set; }

        public RoleDTO Role { get; set; }

        public static UserRoleDTO From(UserRole userRole)
        {
            if (userRole == null)
                return new UserRoleDTO();

            return new UserRoleDTO
            {
                Id = userRole.Id,
                User = UserDTO.From(userRole.User),
                Role = RoleDTO.From(userRole.Role)
            };
        }
    }
}
