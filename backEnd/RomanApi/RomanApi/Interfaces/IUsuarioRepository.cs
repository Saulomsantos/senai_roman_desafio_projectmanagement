using RomanApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(Tiposusuario tiposusuario);
        void CadastrarEquipe(Equipes equipe);
        void CadastrarUsuario(Usuarios usuario);
        void Editarusuario(Usuarios usuario);
        Usuarios BuscarPorEmailSenha(string email, string senha);
        List<Usuarios> ListarProfessores();
        List<Usuarios> ListarTodosUsuarios();
    }
}
