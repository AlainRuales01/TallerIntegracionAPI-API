using Microsoft.AspNetCore.Mvc;

namespace IntegracionWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumaController : ControllerBase
    {
        [HttpGet(Name = "GetSuma")]
        public string Get([FromQuery] SumaModel model)
        {
            return $"La suma de valor 1: {model.Valor1} y valor 2: {model.Valor2} es {model.Valor1+model.Valor2}";
        }
    }
}
