using RomanApi.Domains;
using RomanApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Interfaces
{
    interface IUsuarioRepository
    {
        void CadastrarTipoUsuario(Tiposusuario tiposusuario);
        List<Equipes> ListarEquipe();
        void EditarTipoUsuario(Tiposusuario tipo);
        void EditarEquipe(Equipes equipe);
        void CadastrarUsuario(Usuarios usuario);
        void Editarusuario(Usuarios usuario);
        UsuarioViewModel BuscarPorEmailSenha(LoginViewModel login);
        List<UsuarioViewModel> ListarProfessores();
        List<UsuarioViewModel> ListarTodosUsuarios();
        List<Tiposusuario> ListarTiposUsuario();
    }
}
