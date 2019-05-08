using Microsoft.AspNetCore.Mvc;
using RomanApi.Interfaces;
using RomanApi.Repositorys;
using RomanApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public LoginController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                return Ok(UsuarioRepository.BuscarPorEmailSenha(login));
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }
    }
}
