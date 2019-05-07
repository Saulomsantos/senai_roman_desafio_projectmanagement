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
    public class TemasController : ControllerBase
    {

        // Cadastrar tema
        [HttpPost]
        public IActionResult CadastrarTema(Temas tema)
        {
            try
            {
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        // Ativar/Desativar tema
        [HttpPost]
        public IActionResult AtivarDesativarProjeto(Temas ativado)
        {
            try
            {
                return Ok(ativado);
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        // Editar tema
        [HttpPut]
        public IActionResult EditarTema(Temas tema)
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

        // Listar temas
        [HttpGet]
        public IActionResult ListarTemas()
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
