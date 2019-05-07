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
    public class ProjetosController : ControllerBase
    {


        // Cadastrar projeto
        [HttpPost]
        public IActionResult CadastrarProjeto(Projetos projeto)
        {
            try
            {
                return Ok(projeto);
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Editar projeto
        [HttpPut]
        public IActionResult EditarProjeto(Projetos projeto)
        {
            try
            {
                return Ok(projeto);
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Listar projetos
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }


    }
}
