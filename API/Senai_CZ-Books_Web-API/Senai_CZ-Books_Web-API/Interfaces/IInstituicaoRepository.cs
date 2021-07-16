using Senai_CZ_Books_Web_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Interfaces
{
    interface IInstituicaoRepository
    {
        List<Instituicao> Listar();

        Instituicao BuscarPorId(int id);

        void Cadastrar(Instituicao NovaInstituiucao);

        void Atualizar(int id, Instituicao NovaInstituicao);

        void Deletar(int id);
    }
}
