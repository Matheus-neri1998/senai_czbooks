using Senai_CZ_Books_Web_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Interfaces
{
    interface ICategoriaRepository
    {
        List<Categoria> Listar();

        Categoria BuscarPorId(int id);

        void Cadastrar(Categoria NovaCategoria);

        void Atualizar(int id, Categoria NovoCategoria);

        void Deletar(int id);
    }
}
