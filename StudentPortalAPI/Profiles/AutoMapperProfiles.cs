using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Profiles.AfterMaps;
using StudentPortalAPI.DomainModels;
using StudentPortalAPI.Profiles.AfterMaps;

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

            CreateMap<UpdateStudentRequest, Models.Student>()
               .AfterMap<UpdateStudentRequestAfterMap>();

            CreateMap<AddStudentRequest, Models.Student>()
               .AfterMap<AddStudentRequestAfterMap>();
        }
    }
}
