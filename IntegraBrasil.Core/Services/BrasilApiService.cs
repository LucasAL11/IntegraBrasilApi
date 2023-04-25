using System.Dynamic;
using System.Text.Json;
using IntegraBrasil.Core.Interfaces;
using IntegraBrasil.Shared.DTO;
using IntegraBrasil.Shared.Models;

namespace IntegraBrasil.Core.Services;

public class BrasilApiService : IBrasilApiService
{
    public async Task<GenericDTO<EnderecoModel>> BuscarEnderecoPorCep(string cep)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
        var response = new GenericDTO<EnderecoModel>();
        using var client = new HttpClient();
        var httpResponseMessage = await client.SendAsync(request);
        var responseObject = await httpResponseMessage.Content.ReadAsStringAsync();
        var deserializeJson = JsonSerializer.Deserialize<EnderecoModel>(responseObject);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.DadosRetorno = deserializeJson;
        }

        response.CodigoHttp = httpResponseMessage.StatusCode;
        response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(responseObject);

        return response;
    }

    public Task<GenericDTO<BancoModel>> BuscarTodosBancos()
    {
        throw new NotImplementedException();
    }

    public Task<GenericDTO<BancoModel>> BuscarBancoPorCodigo()
    {
        throw new NotImplementedException();
    }
}