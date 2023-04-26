using IntegraBrasil.Shared.DTO;
using IntegraBrasil.Shared.Models;

namespace IntegraBrasil.Core.Interfaces;

public interface IBrasilApiService
{
    Task<GenericDTO<EnderecoModel>> BuscarEnderecoPorCep(string cep);
    Task<GenericDTO<List<BancoModel>>> BuscarTodosBancos();
    Task<GenericDTO<BancoModel>> BuscarBancoPorCodigo(int codigo);
    Task<GenericDTO<DDDModel>> BuscarEstadoCidadePorDDD(int ddd);
}