using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MakeSense.Models;


namespace MakeSense.Models.DTO.OutComing
{
    public class ImageDetailOutDto : Profile
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string State { get; set; }
        public string File_Name { get; set; }
        public string? Category { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Lens { get; set; }
        public long? Size { get; set; }
        public string? Format { get; set; }
        public DateTime? DonationOn { get; set; }
        public string? DonationBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        public int? PixelX { get; set; }
        public int? PixelY { get; set; }
    }
}


/*
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))x
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => Converti(src.State)))x
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))x
            .ForMember(dest => dest.File_Name, opt => opt.MapFrom(src => src.File_Name))x
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))x
            .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand))x
            .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))x
            .ForMember(dest => dest.Lens, opt => opt.MapFrom(src => src.Lens))x
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Size))x
            .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))x
            .ForMember(dest => dest.DonationOn, opt => opt.MapFrom(src => src.DonationOn))x
            .ForMember(dest => dest.DonationBy, opt => opt.MapFrom(src => src.DonationBy))x
            .ForMember(dest => dest.ApprovedOn, opt => opt.MapFrom(src => src.ApprovedOn));
            //.ForMember(dest => dest.App, opt => opt.MapFrom(src => src.ApprovedBy));
 */