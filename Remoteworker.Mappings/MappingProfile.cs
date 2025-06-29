using AutoMapper;
using RemoteWorker.DTOs;
using RemoteWorker.Models;

namespace RemoteWorker.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProjectModel, ProjectDto>().ReverseMap();
            CreateMap<UserModel, UserDto>().ReverseMap();
        }
    }
}
