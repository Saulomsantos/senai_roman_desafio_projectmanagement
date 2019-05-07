using System;
using System.Collections.Generic;

namespace RomanApi.Domains
{
    public partial class Projetos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? TemaId { get; set; }

        public Temas Tema { get; set; }
    }
}
