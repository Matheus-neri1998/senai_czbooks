using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZ_Books_Web_API.Domains
{
    public partial class Livros
    {
        public Livros()
        {
            Autors = new HashSet<Autor>();
        }

        public int IdLivro { get; set; }
        public int? IdInstituicao { get; set; }
        public int? IdCategoria { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Preco { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Instituicao IdInstituicaoNavigation { get; set; }
        public virtual ICollection<Autor> Autors { get; set; }
    }
}
