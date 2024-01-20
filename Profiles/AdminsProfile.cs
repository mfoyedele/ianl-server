using AutoMapper;
using WebApi.Dtos;
using WebApi.Models.Admin;

namespace WebApi.Profiles
{
    public class AdminsProfile : Profile
    {
        public AdminsProfile()
        {
            // Source -> Target
            CreateMap<AdminModel, AdminReadDto>();
            CreateMap<AdminCreateDto, AdminModel>();
            CreateMap<AdminUpdateDto, AdminModel>();
            CreateMap<AdminModel, AdminUpdateDto>();
        }     
    }
}