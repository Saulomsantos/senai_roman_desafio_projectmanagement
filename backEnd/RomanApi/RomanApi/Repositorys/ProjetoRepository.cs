using Microsoft.EntityFrameworkCore;
using RomanApi.Domains;
using RomanApi.Interfaces;
using RomanApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<ProjetoViewModel> ListarProjetos()
        {
            string stringConexao = "Data Source=romandb.database.windows.net; Initial Catalog=romanbd; user id=roman-admin; pwd=Batata123;";

            string query = "SELECT P.ID, NOME, DESCRICAO, TEMA FROM PROJETOS P LEFT JOIN TEMAS T ON P.TEMA_ID = T.ID";

            List<ProjetoViewModel> projetos = new List<ProjetoViewModel>();

            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();
                SqlDataReader sdr;

                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    sdr = cmd.ExecuteReader();

                    if(sdr.HasRows)
                    {
                        while(sdr.Read())
                        {
                            ProjetoViewModel projeto = new ProjetoViewModel()
                            {
                                Id = Convert.ToInt32(sdr["ID"]),
                                Nome = sdr["NOME"].ToString(),
                                Descricao = sdr["DESCRICAO"].ToString(),
                                Tema = sdr["TEMA"].ToString()
                            };

                            projetos.Add(projeto);
                        }

                        return projetos;
                    }
                }
            }

            return null;


        }
    }
}
