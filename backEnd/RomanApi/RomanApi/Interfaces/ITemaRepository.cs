using RomanApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.Interfaces
{
    interface ITemaRepository
    {
        void CadastrarTema(Temas tema);
        void AtivarDesativarTema(Temas ativado);
        void EditarTema(Temas tema);
        List<Temas> listarTemas();
    }
}
