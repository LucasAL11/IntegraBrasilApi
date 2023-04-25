using IntegraBrasil.Shared.DTO;

namespace IntegraBrasil.Core.Interfaces;

public interface IEnderecoService
{
    Task<GenericDTO<EnderecoDTO>> BuscarEndereco(string cep);
}