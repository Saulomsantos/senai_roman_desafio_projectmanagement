using RomanApi.Domains;
using RomanApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Interfaces
{
    interface IProjetoRepository
    {
        void CadastrarProjeto(Projetos projeto);
        void CadastrarEquipe(Equipes equipe);
        void EditarProjeto(Projetos projeto);
        List<ProjetoViewModel> ListarProjetos();
    }
}
