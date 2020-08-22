using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumeroaLetra.Helpers;

namespace NumeroaLetra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        [Route ("Lit")]
        public string LiteralGet(int numero)
        {
            return Conversores.NumeroALetras(numero);
        }

        public string Lit(int a)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public string LiteralPost([FromHeader] int numero)
        {
            return Conversores.NumeroALetras(numero);
        }
    }
}
