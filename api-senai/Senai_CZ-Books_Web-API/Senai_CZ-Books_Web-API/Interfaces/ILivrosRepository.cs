using Senai_CZ_Books_Web_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Interfaces
{
    interface ILivrosRepository
    {
        List<Livros> Listar();

        Livros BuscarPorId(int id);

        void Cadastrar(Livros NovoLivro);

        void Atualizar(int id, Livros NovoLivro);

        void Deletar(int id);
    }
}
