using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RomanApi.Interfaces;
using RomanApi.Repositorys;
using RomanApi.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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
                var usuarioBuscado = UsuarioRepository.BuscarPorEmailSenha(login);

                //Define os dados que serão fornecidos no token - PayLoad
                var claims = new[]
            {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.Id.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.TipoUsuario.ToString()),
                };

                // Chave de acesso do token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("roman-chave-autenticacao"));

                //Credenciais do Token - Header
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //Gera o token
                var token = new JwtSecurityToken(
                    issuer: "roman",
                    audience: "roman",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                );

                //Retorna Ok com o Token
                return Ok(new
                {
                    usuarioBuscado,
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (System.Exception ex)
            {
                throw(ex);
            }
        }
    }
}
