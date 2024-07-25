using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Models.DTO.OutComing;
using AutoMapper;

namespace MakeSense.Profiler
{


    public class ImageDetailProfiler : Profile
    {

        string Converti(_State stato)
        {
            switch (stato)
            {
                case _State.uploaded: return "uploaded";
                case _State.dowloaded: return "dowloaded";
                case _State.pending: return "pending";
                case _State.rejected: return "rejected";
                case _State.eligible: return "eligible";
                case _State.assigned: return "assigned";
                case _State.completed: return "completed";
                default: return null;
            }
        }


        public ImageDetailProfiler()
        {
            CreateMap<Image, ImageDetailOutDto>()

            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => Converti(src.State)))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.File_Name, opt => opt.MapFrom(src => src.File_Name))
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
            .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand))
            .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
            .ForMember(dest => dest.Lens, opt => opt.MapFrom(src => src.Lens))
            .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Size))
            .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
            .ForMember(dest => dest.DonationOn, opt => opt.MapFrom(src => src.DonationOn))
            .ForMember(dest => dest.DonationBy, opt => opt.MapFrom(src => src.DonationBy))
            .ForMember(dest => dest.ApprovedOn, opt => opt.MapFrom(src => src.ApprovedOn))

            .ForMember(dest => dest.PixelX, opt => opt.MapFrom(src => src.PixelX))
            .ForMember(dest => dest.PixelY, opt => opt.MapFrom(src => src.PixelY));

            //.ForMember(dest => dest.App, opt => opt.MapFrom(src => src.ApprovedBy));


        }





    }
}

/*
 * 
 
 
        public string  { get; set; }
        public string File_Name { get; set; }

        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }
        // Dati relativi al immagine
        //grandezza

        public long? Size { get; set; }
        // Formato
        public string? Format { get; set; }




        public DateTime? DonationOn { get; set; }
        public string? DonationBy { get; set; }

        public DateTime ApprovedOn { get; set; }
        public int? PixelY { get; set; }
 * 
 * 
 * 
 * 
 * 
 */