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
        else
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(responseObject);
        }

        return response;
    }

    public async Task<GenericDTO<List<BancoModel>>> BuscarTodosBancos()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
        var response = new GenericDTO<List<BancoModel>>();
        using var client = new HttpClient();
        var httpResponseMessage = await client.SendAsync(request);
        var responseObject = await httpResponseMessage.Content.ReadAsStringAsync();
        var deserializeJson = JsonSerializer.Deserialize<List<BancoModel>>(responseObject);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.DadosRetorno = deserializeJson;
        }
        else
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(responseObject);
        }

        return response;
    }

    public async Task<GenericDTO<BancoModel>> BuscarBancoPorCodigo(int codigo)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigo}");
        var response = new GenericDTO<BancoModel>();
        using var client = new HttpClient();
        var httpResponseMessage = await client.SendAsync(request);
        var responseObject = await httpResponseMessage.Content.ReadAsStringAsync();
        var deserializeJson = JsonSerializer.Deserialize<BancoModel>(responseObject);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.DadosRetorno = deserializeJson;
        }
        else
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(responseObject);
        }

        return response;
    }

    public async Task<GenericDTO<DDDModel>> BuscarEstadoCidadePorDDD(int ddd)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/ddd/v1/{ddd}");
        var response = new GenericDTO<DDDModel>();
        using var client = new HttpClient();
        var httpResponseMessage = await client.SendAsync(request);
        var responseObject = await httpResponseMessage.Content.ReadAsStringAsync();
        var deserializeJson = JsonSerializer.Deserialize<DDDModel>(responseObject);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.DadosRetorno = deserializeJson;
        }
        else
        {
            response.CodigoHttp = httpResponseMessage.StatusCode;
            response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(responseObject);
        }

        return response;
    }
}