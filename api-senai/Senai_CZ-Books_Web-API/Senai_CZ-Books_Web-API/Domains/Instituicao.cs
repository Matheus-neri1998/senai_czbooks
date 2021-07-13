using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZ_Books_Web_API.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Livros = new HashSet<Livros>();
        }

        public int IdInstituicao { get; set; }
        public string Instituicoes { get; set; }

        public virtual ICollection<Livros> Livros { get; set; }
    }
}
