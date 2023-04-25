using AutoMapper;
using IntegraBrasil.Shared.DTO;
using IntegraBrasil.Shared.Models;

namespace IntegraBrasil.Data.Mapper;

public class EnderecoMapper : Profile
{
    public EnderecoMapper()
    {
        CreateMap(typeof(GenericDTO<>), typeof(GenericDTO<>));
        CreateMap<EnderecoDTO, EnderecoModel>();
        CreateMap<EnderecoModel, EnderecoDTO>();
    }
}