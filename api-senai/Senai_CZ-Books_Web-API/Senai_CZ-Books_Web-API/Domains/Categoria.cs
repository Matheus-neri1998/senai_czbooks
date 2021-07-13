using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZ_Books_Web_API.Domains
{
    public partial class Categoria
    {
        public Categoria()
        {
            Livros = new HashSet<Livros>();
        }

        public int IdCategoria { get; set; }
        public string Categorias { get; set; }

        public virtual ICollection<Livros> Livros { get; set; }
    }
}
