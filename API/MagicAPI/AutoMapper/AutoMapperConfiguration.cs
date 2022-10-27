using AutoMapper;
using MagicAPI.Models;
using MagicAPI.Request;
using MtgApiManager.Lib.Model;
using System.Collections.Generic;

namespace VDI.API.AutoMapper
{
    public class AutoMapperConfigurationProfile : Profile
    {
        public AutoMapperConfigurationProfile()
        {
            CreateMap<ICard, CardModel>().ReverseMap();
            CreateMap<IList<ICard>, CardModel>().ReverseMap();
            CreateMap<CardModel, RegisterCardRequest>().ReverseMap()
               .ForMember(x => x.Name, opt => opt.MapFrom(x => x.CardName));
        }
    }
}
