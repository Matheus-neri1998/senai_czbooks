using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZ_Books_Web_API.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Autores = new HashSet<Autor>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TiposUsuarios IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }
    }
}
