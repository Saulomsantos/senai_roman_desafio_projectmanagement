using System;
using System.Collections.Generic;

namespace RomanApi.Domains
{
    public partial class Tiposusuario
    {
        public Tiposusuario()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; set; }
        public string TipoUsuario { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
