using WebApplication13.Models;
using AutoMapper;
using WebApplication13.Dtos;

namespace WebApplication13.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<TbItemCodeDto, TbItemType>()
               .ForMember(dest => dest.Udate, opt => opt.MapFrom(src => DateTime.Now)) // 設置更新時間為現在
               .ForMember(dest => dest.Cdate, opt => opt.MapFrom(src => DateTime.Now)) // 設置創建時間為現在
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => true)); // 設置狀態為 true
        }
    }
}
