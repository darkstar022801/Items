using AutoMapper;
using Items.Common.DTOs;
using Items.Data.Entities;

namespace Items.Service.User.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Data.Entities.User, UserDTO>();
            CreateMap<UserDTO, Data.Entities.User>();

            CreateMap<Role, RoleDTO>();
            CreateMap<RoleDTO, Role>();

            CreateMap<UserRole, UserRoleDTO>();
            CreateMap<UserRoleDTO, UserRole>();

        }
    }
}
