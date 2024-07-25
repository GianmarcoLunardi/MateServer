using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MakeSense.Models;
using MakeSense.Models.DTO.OutComing;

// video automapper
// https://www.youtube.com/watch?v=Wm7hN0S-AdU

namespace MakeSense.Profiler
{
    public class ImageProfiler : Profile
    {
       //gli manca iilnome
        public ImageProfiler( )
        {
            CreateMap<ImageDetailOutDto, Image>()
                .ForMember(dest => dest.Id, src => Guid.NewGuid())
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.Lens, opt => opt.MapFrom(src => src.Lens))
                //.ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Size))
               // .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))

                .ForMember(dest => dest.DonationOn, opt => opt.MapFrom(src => src.DonationOn))
                .ForMember(dest => dest.DonationBy, opt => opt.MapFrom(src => src.DonationBy))
                .ForMember(dest => dest.ApprovedOn, opt => opt.MapFrom(src => src.ApprovedOn))
                //.ForMember(dest => dest.ApprovedBy, opt => opt.MapFrom(src => src.ApprovedBy))


                //entrambi sono valori di inizializzazione da ricalcolare eevetulmente
                // nel service di upload
                .ForMember(dest => dest.PixelX, opt => opt.MapFrom(src => 10))
                .ForMember(dest => dest.PixelY, opt => opt.MapFrom(src => 10));




            //  .ForMember(dest => dest.ApprovedOn, opt => opt.MapFrom(src => src.ApprovedOn);
        }


    }
}

/*
 * 
        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }
        // Dati relativi al immagine
        //grandezza
        [MinLength(50)]
        public long? Size { get; set; }
        // Formato


        public string?  { get; set; }
        //Larghezza file

        //campo chiave esterna
        //public List<Annotation> Annotations { get; set; }

        //public User UpdatedBy { get; set; }

        public DateTime  { get; set; }


        public string DonationBy { get; set; }

        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
 * 
 * 
 * 
*/