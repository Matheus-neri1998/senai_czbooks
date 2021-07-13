using Senai_CZ_Books_Web_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Interfaces
{
    interface ITiposUsuariosRepository
    {
        List<TiposUsuarios> Listar();

        TiposUsuarios BuscarPorId(int id);

        void Cadastrar(TiposUsuarios NovoTipoUsuario);

        void Atualizar(int id, TiposUsuarios NovoTipoUsuario);

        void Deletar(int id);
    }
}
