using AutoMapper;
using IntegraBrasil.Core.Interfaces;
using IntegraBrasil.Shared.DTO;

namespace IntegraBrasil.Core.Services;

public class DDDService : IDDDService
{
    private readonly IMapper _mapper;
    private readonly IBrasilApiService _brasilApiService;

    public DDDService(IMapper mapper, IBrasilApiService brasilApiService)
    {
        _mapper = mapper;
        _brasilApiService = brasilApiService;
    }

    public async Task<GenericDTO<DDDDTO>> BuscarEstadoCidadeDDD(int ddd)
    {
        var EstadoCidadesDDD = await _brasilApiService.BuscarEstadoCidadePorDDD(ddd);
        return _mapper.Map<GenericDTO<DDDDTO>>(EstadoCidadesDDD);
    }
}