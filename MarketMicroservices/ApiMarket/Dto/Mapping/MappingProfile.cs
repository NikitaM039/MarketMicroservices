using ApiClientMarket.Db;
using AutoMapper;
using MarketMicroservices.ApiMarket.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiClientMarket.Dto.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClientProductDto, ClientProduct>().ReverseMap();
        }
    }
}