using AutoMapper;
using ProductsMicroservice.Db;
using ProductsMicroservice.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductsMicroservice.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClientDto, Client>().ReverseMap();

            CreateMap<ClientDto, GetClientsDto>().ReverseMap();
        }
    }
}