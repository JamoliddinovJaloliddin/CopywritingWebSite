using AutoMapper;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Dtos.CopywritingDto;
using CopywritingWebSite.Service.Dtos.CustomerTheEmpolyeerDto;
using CopywritingWebSite.Service.Dtos.CustomerWorkerDto;
using CopywritingWebSite.Service.Dtos.OrderDto;
using CopywritingWebSite.Service.Dtos.PriceStatusDto;
using CopywritingWebSite.Service.Dtos.TestDto;

namespace CopywritingWebSite.MVS.Configurations
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<ArticleCreateDto, Article>().ReverseMap();
            CreateMap<CopywritingCreateDto, CopywritingStatus>().ReverseMap();
            CreateMap<CustomerTheEmpolyeerCreateDto, CustomerTheEmpolyeer>().ReverseMap();
            CreateMap<CustomerWorkerCreateDto, CustomerWorker>().ReverseMap();
            CreateMap<OrderCreateDto, Order>().ReverseMap();
            CreateMap<PriceStatusCreateDto, PriceStatus>().ReverseMap();
            CreateMap<TestCreateDto, Test>().ReverseMap();
        }
    }
}
