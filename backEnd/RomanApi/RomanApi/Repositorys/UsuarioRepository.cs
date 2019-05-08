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
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            }
        }

        public void CadastrarTipoUsuario(Tiposusuario tipo)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Tiposusuario.Add(tipo);
                ctx.SaveChanges();
            }
        }

        public void CadastrarEquipe(Equipes equipe)
        {
            throw new NotImplementedException();
        }

        public void CadastrarUsuario(Usuarios usuario)
        {
            using(RomanContext ctx = new RomanContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }

        public void Editarusuario(Usuarios usuario)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Usuarios usuarioUpdate = ctx.Usuarios.Find(usuario.Id);
                usuarioUpdate.Nome = usuario.Nome;
                usuarioUpdate.Email = usuario.Email;
                usuarioUpdate.Senha = usuario.Senha;
                usuarioUpdate.TipousuarioId = usuario.TipousuarioId;
                usuarioUpdate.EquipeId = usuario.EquipeId;
                ctx.SaveChanges();
            }
        }

        public List<Usuarios> ListarProfessores()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Usuarios.Where(u => u.TipousuarioId == 2).ToList();
            }
        }

        public List<Usuarios> ListarTodosUsuarios()
        {
            using(RomanContext ctx = new RomanContext())
            {
                return ctx.Usuarios.ToList();
            }
        }
    }
}
