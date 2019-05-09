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
    [Authorize(Roles = "ADMINISTRADOR")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuariosController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        // Listar usuarios
        [Route("todos")]
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            try
            {
                return Ok(UsuarioRepository.ListarTodosUsuarios());
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Listar professores
        [Route("professores")]
        [HttpGet]
        public IActionResult GetProfessores()
        {
            try
            {
                return Ok(UsuarioRepository.ListarProfessores());
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Listar equipe
        [Route("equipe")]
        [HttpGet]
        public IActionResult ListarEquipe()
        {
            try
            {
                return Ok(UsuarioRepository.ListarEquipe());
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        // Editar usuario
        [HttpPut]
        public IActionResult EditarUsuario(Usuarios usuario)
        {
            try
            {
                UsuarioRepository.Editarusuario(usuario);
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Editar Equipe
        [Route("equipe")]
        [HttpPut]
        public IActionResult EditarEquipe(Equipes equipe)
        {
            try
            {
                UsuarioRepository.EditarEquipe(equipe);
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Cadastrar usuario
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuarios usuario)
        {
            try
            {
                UsuarioRepository.CadastrarUsuario(usuario);
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Cadastrar tipo usuario
        [Route("tipo")]
        [HttpPost]
        public IActionResult CadastrarTipoUsuario(Tiposusuario tipo)
        {
            try
            {
                UsuarioRepository.CadastrarTipoUsuario(tipo);
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }

        // Editar TipoUsuario
        [Route("tipo")]
        [HttpPut]
        public IActionResult EditarTipoUsuario(Tiposusuario tipo)
        {
            try
            {
                UsuarioRepository.EditarTipoUsuario(tipo);
                return Ok();
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        // Listar tipo usuario
        [Route("tipo")]
        [HttpGet]
        public IActionResult ListarTipoUsuario()
        {
            try
            {
                return Ok(UsuarioRepository.ListarTiposUsuario());
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }
    }
}
