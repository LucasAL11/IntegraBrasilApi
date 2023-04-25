using System.Dynamic;
using System.Net;

namespace IntegraBrasil.Shared.DTO;

public class GenericDTO<T> where T : class
{
    
    public HttpStatusCode CodigoHttp { get; set; }
    public T? DadosRetorno { get; set; }
    public ExpandoObject? ErroRetorno { get; set; }
}