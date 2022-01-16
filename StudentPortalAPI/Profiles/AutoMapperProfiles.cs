using AutoMapper;
using StudentPortalAPI.DomainModels;
using Models = StudentPortalAPI.Models;

namespace StudentPortalAPI.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Models.Student, Student>()
                .ReverseMap();

            CreateMap<Models.Gender, Gender>()
                .ReverseMap();

            CreateMap<Models.Address, Address>()
                .ReverseMap();
        }
    }
}
