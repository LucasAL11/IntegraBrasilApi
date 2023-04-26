using System.Net;
using IntegraBrasil.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasil.Controllers;

[ApiController]
[Route("api/v1/banco")]
public class BancoController : ControllerBase
{
    private readonly IBancoServices _services;
//. deploy teste....
    public BancoController(IBancoServices service)
    {
        _services = service;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarTodosBancos()
    {
        var response = await _services.BuscarTodosBancos();

        return response.CodigoHttp == HttpStatusCode.OK
            ? Ok(response.DadosRetorno)
            : StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }

    [HttpGet("{codigo:int}")]
    public async Task<IActionResult> BuscarBancoPorCodigo(int codigo)
    {
        var response = await _services.BuscarBancoPorCodigo(codigo);

        return response.CodigoHttp == HttpStatusCode.OK
            ? Ok(response.DadosRetorno)
            : StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}