using WebApplication13.Models;
using AutoMapper;
using WebApplication13.Dtos;

namespace WebApplication13.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<TbItemTypeDto, TbItemType>()
               .ForMember(dest => dest.Udate, opt => opt.MapFrom(src => DateTime.Now)) 
               .ForMember(dest => dest.Cdate, opt => opt.MapFrom(src => DateTime.Now)) 
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => true)); 

            CreateMap<TbItemCodeDto, TbItemCode>()
             .ForMember(dest => dest.ItemTypeid, opt => opt.MapFrom(src => src.Mid))
             .ForMember(dest => dest.ItemNo, opt => opt.MapFrom(src => src.Item_no))
             .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.Item_name))
             .ForMember(dest => dest.Udate, opt => opt.MapFrom(src => DateTime.Now)) 
             .ForMember(dest => dest.Cdate, opt => opt.MapFrom(src => DateTime.Now))
             .ForMember(dest => dest.ActiveFlag, opt => opt.MapFrom(src => true)); 
        }
    }
}
