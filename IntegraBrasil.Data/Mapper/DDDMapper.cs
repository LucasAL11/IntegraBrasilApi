using AutoMapper;
using IntegraBrasil.Shared.DTO;
using IntegraBrasil.Shared.Models;

namespace IntegraBrasil.Data.Mapper;

public class DDDMapper : Profile
{
    public DDDMapper()
    {
        CreateMap(typeof(GenericDTO<>), typeof(GenericDTO<>));
        CreateMap<DDDDTO, DDDModel>();
        CreateMap<DDDModel, DDDDTO>();
    }
}