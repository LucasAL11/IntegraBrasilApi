using IntegraBrasil.Shared.DTO;

namespace IntegraBrasil.Core.Interfaces;

public interface IBancoServices
{
    Task<GenericDTO<List<BancoDTO>>> BuscarTodosBancos();
    Task<GenericDTO<BancoDTO>> BuscarBancoPorCodigo(int codigo);
}