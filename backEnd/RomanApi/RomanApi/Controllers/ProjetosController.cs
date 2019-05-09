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
    [Authorize(Roles = "PROFESSOR")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {

        private IProjetoRepository ProjetoRepository { get; set; }

        public ProjetosController()
        {
            ProjetoRepository = new ProjetoRepository();
        }

        // Cadastrar projeto
        [HttpPost]
        public IActionResult CadastrarProjeto(Projetos projeto)
        {
            try
            {
                ProjetoRepository.CadastrarProjeto(projeto);
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Cadastrar equipe
        [Route("equipe")]
        [HttpPost]
        public IActionResult CadastrarEquipe(Equipes equipe)
        {
            try
            {
                ProjetoRepository.CadastrarEquipe(equipe);
                return Ok();
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
                ProjetoRepository.EditarProjeto(projeto);
                return Ok();
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
                return Ok(ProjetoRepository.ListarProjetos());
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }


    }
}
