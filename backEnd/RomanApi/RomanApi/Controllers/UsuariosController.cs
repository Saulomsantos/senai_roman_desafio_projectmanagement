using Microsoft.AspNetCore.Mvc;
using RomanApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            using(RomanContext ctx = new RomanContext())
            {
                return Ok(ctx.Usuarios.ToList());
            }
        }

    }
}
