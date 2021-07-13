using Senai_CZ_Books_Web_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Interfaces
{
    interface IAutorRepository
    {
        List<Autor> Listar();

        Autor BuscarPorId(int id);

        void Cadastrar(Autor NovoAutor);

        void Atualizar(int id, Autor NovoAutor);

        void Deletar(int id);
    }
}
