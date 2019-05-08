using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanApi.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int? TipousuarioId { get; set; }
        public string TipoUsuario { get; set; }
        public int? EquipeId { get; set; }
        public string Equipe { get; set; }
    }
}
