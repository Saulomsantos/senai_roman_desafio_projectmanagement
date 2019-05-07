using RomanApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Interfaces
{
    interface IProjetoRepository
    {
        void CadastrarProjeto(Projetos projeto);
        void EditarProjeto(Projetos projeto);
        List<Projetos> ListarProjetos();
    }
}
