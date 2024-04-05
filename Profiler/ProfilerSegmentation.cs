using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MakeSense.Models;
using MakeSense.Models.DTO.InComing;
namespace MakeSense.Profiler
{
    public class ProfilerSegmentation : Profile
    {
        public ProfilerSegmentation()
        {
            CreateMap<annotation, Annotation>()
            .ForMember(dest => dest.Id,
            opt => opt.MapFrom(src => src.id)
            )
            .ForMember(dest => dest.Segmentations,

            opt => opt.MapFrom(src => src.segmentation.Select(i => new Coordinate() { Id = 0, Point = i }).ToList()));
        }
    }
}
/*
 *             
*/