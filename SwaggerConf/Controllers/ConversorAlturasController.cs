using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerConf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorAlturasController : ControllerBase
    {
        [Authorize("Bearer")]
        [HttpGet("PesMetros/{alturaPes}")]
        public object Get(double alturaPes)
        {
            return new
            {
                AlturaPes = alturaPes,
                AlturaMetros = Math.Round(alturaPes * 0.3048, 4)
            };
        }
    }
}
