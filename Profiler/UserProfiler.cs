using System;
using AutoMapper;
using MakeSense.Models;
using MakeSense.Models.DTO.OutComing;

namespace MakeSense.Profiler
{
    public class UserProfiler : Profile
    {
        public UserProfiler()
        {
            CreateMap<User, UserOutComingDto>()

                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString("D")));
               // .ForMember(dest => dest.Id, src => );
        }
    }
}
