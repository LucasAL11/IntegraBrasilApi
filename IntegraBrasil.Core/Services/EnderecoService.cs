using AutoMapper;
using IntegraBrasil.Core.Interfaces;
using IntegraBrasil.Shared.DTO;


namespace IntegraBrasil.Core.Services;

public class EnderecoService : IEnderecoService
{

    private readonly IMapper _mapper;
    private readonly IBrasilApiService _brasilApiService;

    public EnderecoService(IMapper mapper, IBrasilApiService brasilApiService)
    {
        _mapper = mapper;
        _brasilApiService = brasilApiService;
    }

    public async Task<GenericDTO<EnderecoDTO>> BuscarEndereco(string cep)
    {
        var endereco = await _brasilApiService.BuscarEnderecoPorCep(cep);
        return _mapper.Map<GenericDTO<EnderecoDTO>>(endereco);
    }
}