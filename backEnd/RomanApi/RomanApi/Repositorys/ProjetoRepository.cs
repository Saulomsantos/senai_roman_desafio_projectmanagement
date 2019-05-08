using RomanApi.Domains;
using RomanApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Repositorys
{
    public class ProjetoRepository : IProjetoRepository
    {
        public void CadastrarEquipe(Equipes equipe)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Equipes.Add(equipe);
                ctx.SaveChanges();
            }
        }

        public void CadastrarProjeto(Projetos projeto)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Projetos.Add(projeto);
                ctx.SaveChanges();
            }
        }

        public void EditarProjeto(Projetos projeto)
        {
            using(RomanContext ctx = new RomanContext())
            {
                Projetos projetoUpdate = ctx.Projetos.Find(projeto.Id);
                projetoUpdate.Nome = projeto.Nome;
                projetoUpdate.Descricao = projeto.Descricao;
                projetoUpdate.TemaId = projeto.TemaId;
                ctx.SaveChanges();
            }
        }

        public List<Projetos> ListarProjetos()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projetos.ToList();
            }
        }
    }
}
