using System;
using System.Collections.Generic;

namespace RomanApi.Domains
{
    public partial class Equipes
    {
        public Equipes()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; set; }
        public string Equipe { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
