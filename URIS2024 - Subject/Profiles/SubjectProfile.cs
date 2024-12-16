using AutoMapper;
using URIS2024___Subject.Models;
using URIS2024___Subject.Models.DTO;

namespace URIS2024___Subject.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<SubjectEntity, SubjectDto>()
                .ReverseMap();
        }
    }
}
