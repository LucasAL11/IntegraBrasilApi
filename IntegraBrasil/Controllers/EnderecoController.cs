using System.Net;
using IntegraBrasil.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasil.Controllers;

[ApiController]
[Route("api/v1/endereco")]
public class EnderecoController : ControllerBase
{
    public readonly IEnderecoService _Service;

    public EnderecoController(IEnderecoService service)
    {
        _Service = service;
    }

    [HttpGet("{cep}")]
    public async Task<IActionResult> BuscarEndereco([FromRoute] string cep)
    {
        var response = await _Service.BuscarEndereco(cep);

        return response.CodigoHttp == HttpStatusCode.OK ? Ok(response.DadosRetorno) 
            : StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}