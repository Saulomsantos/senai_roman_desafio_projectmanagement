using System;
using System.Collections.Generic;

namespace RomanApi.Domains
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? TipousuarioId { get; set; }
        public int? EquipeId { get; set; }

        public Equipes Equipe { get; set; }
        public Tiposusuario Tipousuario { get; set; }
    }
}
