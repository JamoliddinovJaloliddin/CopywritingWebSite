using AutoMapper;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Dtos.CopywritingDto;
using CopywritingWebSite.Service.Dtos.CustomerTheEmpolyeerDto;
using CopywritingWebSite.Service.Dtos.TestDto;

namespace CopywritingWebSite.MVS.Configurations
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<TestCreateDto, Test>().ReverseMap();
            CreateMap<ArticleCreateDto, Article>().ReverseMap();
            CreateMap<CopywritingCreateDto, CopywritingStatus>().ReverseMap();
            CreateMap<CustomerTheEmpolyeerCreateDto, CustomerTheEmpolyeer>();
        }
    }
}
