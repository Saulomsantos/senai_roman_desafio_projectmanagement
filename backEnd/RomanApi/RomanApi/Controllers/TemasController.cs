using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RomanApi.Domains;
using RomanApi.Interfaces;
using RomanApi.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Controllers
{
    [Authorize(Roles = "ADMINISTRADOR, PROFESSOR")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TemasController : ControllerBase
    {

        private ITemaRepository TemaRepository {get; set;}

        public TemasController()
        {
            TemaRepository = new TemaRepository();
        }

        // Cadastrar tema
        [HttpPost]
        public IActionResult CadastrarTema(Temas tema)
        {
            try
            {
                TemaRepository.CadastrarTema(tema);
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        // Ativar/Desativar tema
        [Route("ativardesativar")]
        [HttpPost]
        public IActionResult AtivarDesativarProjeto(Temas ativado)
        {
            try
            {
                TemaRepository.AtivarDesativarTema(ativado);
                return Ok();
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
                return Ok(TemaRepository.listarTemas());
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }        
    }
}
