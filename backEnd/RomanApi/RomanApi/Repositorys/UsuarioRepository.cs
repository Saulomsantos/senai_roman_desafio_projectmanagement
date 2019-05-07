using RomanApi.Domains;
using RomanApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Repositorys
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuarios BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Tiposusuario tiposusuario)
        {
            throw new NotImplementedException();
        }

        public void CadastrarEquipe(Equipes equipe)
        {
            throw new NotImplementedException();
        }

        public void CadastrarUsuario(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public void Editarusuario(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> ListarProfessores()
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> ListarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
