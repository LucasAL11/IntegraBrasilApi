using AutoMapper;
using IntegraBrasil.Core.Interfaces;
using IntegraBrasil.Shared.DTO;

namespace IntegraBrasil.Core.Services;

public class BancoServices : IBancoServices
{
    private readonly IMapper _mapper;
    private readonly IBrasilApiService _brasilApiService;

    public BancoServices(IMapper mapper, IBrasilApiService brasilApiService)
    {
        _mapper = mapper;
        _brasilApiService = brasilApiService;
    }

    public async Task<GenericDTO<List<BancoDTO>>> BuscarTodosBancos()
    {
        var bancos = await _brasilApiService.BuscarTodosBancos();
        return _mapper.Map<GenericDTO<List<BancoDTO>>>(bancos);
    }

    public Task<GenericDTO<BancoDTO>> BuscarBancoPorCodigo()
    {
        throw new NotImplementedException();
    }
}