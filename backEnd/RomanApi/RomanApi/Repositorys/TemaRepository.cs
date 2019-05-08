using RomanApi.Domains;
using RomanApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Repositorys
{
    public class TemaRepository : ITemaRepository
    {
        public void AtivarDesativarTema(Temas ativado)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Temas temaUpdate = ctx.Temas.Find(ativado.Id);
                if (temaUpdate.Ativo == true)
                {
                    temaUpdate.Ativo = false;
                }
                else
                {
                    temaUpdate.Ativo = true;
                }
                ctx.SaveChanges();
            }
        }

        public void CadastrarTema(Temas tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Temas.Add(tema);
                ctx.SaveChanges();
            }
        }

        public void EditarTema(Temas tema)
        {
            using (RomanContext ctx = new RomanContext())
            {

            }
        }

        public List<Temas> listarTemas()
        {
            using(RomanContext ctx = new RomanContext())
            {
                return ctx.Temas.ToList();
            }
        }
    }
}
