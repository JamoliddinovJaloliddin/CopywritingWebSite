using AutoMapper;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Dtos.TestDto;

namespace CopywritingWebSite.MVS.Configurations
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<TestCreateDto, Test>().ReverseMap();
            CreateMap<ArticleTextDto, Article>().ReverseMap();
        }
    }
}
