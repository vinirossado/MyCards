using AutoMapper;
using MagicAPI.Models;
using MtgApiManager.Lib.Model;
using System.Collections.Generic;

namespace VDI.API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ICard, CardModel>().ReverseMap();
            CreateMap<IList<ICard>, CardModel>().ReverseMap();
        }
    }
}
