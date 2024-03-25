using System;
using System.Collections.Generic;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<UserRoleDTO> Roles { get; set; }

        public static UserDTO From(User user)
        {
            if (user == null)
                return new UserDTO();

            List<UserRoleDTO> roles = new List<UserRoleDTO>();
            if (user.UserRoles != null && user.UserRoles.Count > 0)
            {
                user.UserRoles.ForEach(role => roles.Add(UserRoleDTO.From(role)));
            }

            return new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.Username,
                Roles = roles
            };
        }

    }
}
