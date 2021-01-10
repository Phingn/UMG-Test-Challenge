using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMG.Test.Challenge.Api.Models;
using UMG.Test.Challenge.Api.Models.dto;

namespace UMG.Test.Challenge.Api.Data.Configuration
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            AutoMapperRegister();
        }
        private void AutoMapperRegister()
        {
            CreateMap<Tuple<Artist, Album, Contract, DeliveryPartner>, DistributorAlbum>()
                .ForMember(dest => dest.Contracts.ArtistId, opt => opt.MapFrom(src => src.Item1.ArtistId))
                .ForMember(dest => dest.ArtistName, opt => opt.MapFrom(src => src.Item1.Name))

                .ForMember(dest => dest.Contracts.AlbumId, opt => opt.MapFrom(src => src.Item2.AlbumId))
                .ForMember(dest => dest.AlbumName, opt => opt.MapFrom(src => src.Item2.Title))

                .ForMember(dest => dest.Contracts.ContractId, opt => opt.MapFrom(src => src.Item3.ContractId))
                .ForMember(dest => dest.Contracts.StartDate, opt => opt.MapFrom(src => src.Item3.StartDate))
                .ForMember(dest => dest.Contracts.EndDate, opt => opt.MapFrom(src => src.Item3.EndDate))

                 .ForMember(dest => dest.Contracts.ContractType, opt => opt.MapFrom(src => src.Item3.ContractType))

                .ForMember(dest => dest.Contracts.PartnerId, opt => opt.MapFrom(src => src.Item4.PartnerId))
                .ForMember(dest => dest.PartnerName, opt => opt.MapFrom(src => src.Item4.Name))

                .ReverseMap();
        }
    }
}
