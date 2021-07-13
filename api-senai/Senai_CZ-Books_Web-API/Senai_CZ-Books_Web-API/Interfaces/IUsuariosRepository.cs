using Senai_CZ_Books_Web_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Interfaces
{
    interface IUsuariosRepository
    {
        List<Usuarios> Listar();

        Usuarios BuscarPorId(int id);

        void Cadastrar(Usuarios NovoUsuario);

        void Atualizar(int id, Usuarios NovoUsuario);

        void Deletar(int id);

        Usuarios Login(string Email, string Senha);
    }
}
