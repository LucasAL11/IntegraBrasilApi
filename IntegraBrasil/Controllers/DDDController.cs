using System.Net;
using IntegraBrasil.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasil.Controllers;

[ApiController]
[Route("api/v1/ddd")]
public class DDDController : ControllerBase
{
    private readonly IDDDService _service;


    public DDDController(IDDDService service)
    {
        _service = service;
    }

    [HttpGet("{ddd:int}")]
    public async Task<IActionResult> BuscarEstadoCidadeDDD(int ddd)
    {
        var response = await _service.BuscarEstadoCidadeDDD(ddd);
        
        return response.CodigoHttp == HttpStatusCode.OK ? Ok(response.DadosRetorno) 
            : StatusCode((int)response.CodigoHttp, response.ErroRetorno);
    }
}