using IntegraBrasil.Shared.DTO;

namespace IntegraBrasil.Core.Interfaces;

public interface IDDDService
{
    Task<GenericDTO<DDDDTO>> BuscarEstadoCidadeDDD(int ddd);
}