using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZ_Books_Web_API.Domains
{
    public partial class TiposUsuarios
    {
        public TiposUsuarios()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipoUsuario { get; set; }
        public string TipoUsuario { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
