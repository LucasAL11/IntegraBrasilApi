using System.Net;
using IntegraBrasil.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasil.Controllers;

[ApiController]
[Route("api/v1/banco")]
public class BancoController : ControllerBase
{
    private readonly IBancoServices _services;

    public BancoController(IBancoServices service)
    {
        _services = service;
    }

    [HttpGet]
    public async Task<IActionResult> BuscarEndereco()
    {
        var response = await _services.BuscarTodosBancos();

        return response.CodigoHttp == HttpStatusCode.OK
            ? Ok(response.DadosRetorno)
            : StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}