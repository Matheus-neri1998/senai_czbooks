using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZ_Books_Web_API.Domains
{
    public partial class Autor
    {
        public int IdAutor { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdLivro { get; set; }
        public string NomeAutor { get; set; }

        public virtual Livros IdLivroNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
