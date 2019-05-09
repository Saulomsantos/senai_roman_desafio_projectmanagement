using Microsoft.EntityFrameworkCore;
using RomanApi.Domains;
using RomanApi.Interfaces;
using RomanApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanApi.Repositorys
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioViewModel BuscarPorEmailSenha(LoginViewModel login)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Usuarios usuarioBuscado = ctx.Usuarios
                    .Include(u => u.Tipousuario)
                    .FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);
                UsuarioViewModel usuario = new UsuarioViewModel()
                {
                    Id = usuarioBuscado.Id,
                    Email = usuarioBuscado.Email,
                    Nome = usuarioBuscado.Nome,
                    EquipeId = usuarioBuscado.EquipeId,
                    TipousuarioId = usuarioBuscado.TipousuarioId,
                    TipoUsuario = usuarioBuscado.Tipousuario.TipoUsuario
                };

                return usuario;
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

        public List<UsuarioViewModel> ListarProfessores()
        {
            using (RomanContext ctx = new RomanContext())
            {
                List<Usuarios> usuariosBuscados = ctx.Usuarios
                    .Include(usuario => usuario.Tipousuario)
                    .Include(usuario => usuario.Equipe)
                    .Where(u => u.TipousuarioId == 2)
                    .ToList();

                List<UsuarioViewModel> usuariosRetornados = new List<UsuarioViewModel>();

                foreach (var item in usuariosBuscados)
                {
                    UsuarioViewModel usuario = new UsuarioViewModel();

                    if (item.Equipe == null)
                    {
                        usuario.Equipe = null;
                    }
                    else
                    {
                        usuario.Equipe = item.Equipe.Equipe;
                    };
                    usuario.Id = item.Id;
                    usuario.Email = item.Email;
                    usuario.Nome = item.Nome;
                    usuario.EquipeId = item.EquipeId;
                    usuario.TipousuarioId = item.TipousuarioId;
                    usuario.TipoUsuario = item.Tipousuario.TipoUsuario;

                    usuariosRetornados.Add(usuario);

                }

                return usuariosRetornados;
                //return usuariosBuscados;

            }
        }

        public List<UsuarioViewModel> ListarTodosUsuarios()
        {
            using(RomanContext ctx = new RomanContext())
            {
                List<Usuarios> usuariosBuscados = ctx.Usuarios
                    .Include(usuario => usuario.Tipousuario)
                    .Include(usuario => usuario.Equipe)
                    .ToList();

                List<UsuarioViewModel> usuariosRetornados = new List<UsuarioViewModel>();

                foreach (var item in usuariosBuscados)
                {
                    UsuarioViewModel usuario = new UsuarioViewModel();

                    if (item.Equipe == null)
                    {
                        usuario.Equipe = null;
                    }
                    else
                    {
                        usuario.Equipe = item.Equipe.Equipe;
                    };
                    usuario.Id = item.Id;
                    usuario.Email = item.Email;
                    usuario.Nome = item.Nome;
                    usuario.EquipeId = item.EquipeId;
                    usuario.TipousuarioId = item.TipousuarioId;
                    usuario.TipoUsuario = item.Tipousuario.TipoUsuario;

                    usuariosRetornados.Add(usuario);

                }

                return usuariosRetornados;
                //return usuariosBuscados;

            }
        }
    }
}
