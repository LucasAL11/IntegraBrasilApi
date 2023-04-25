using IntegraBrasil.Shared.DTO;
using IntegraBrasil.Shared.Models;
using AutoMapper;
namespace IntegraBrasil.Data.Mapper;

public class BancoMapper : Profile
{
    public BancoMapper()
    {
        CreateMap(typeof(GenericDTO<>), typeof(GenericDTO<>));
        CreateMap<BancoDTO, BancoModel>();
        CreateMap<BancoModel, BancoDTO>();
    }
}