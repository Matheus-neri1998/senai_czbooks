using Senai_CZ_Books_Web_API.Contexts;
using Senai_CZ_Books_Web_API.Domains;
using Senai_CZ_Books_Web_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        CzBooksContext context = new CzBooksContext();
        public void Atualizar(int id, Instituicao NovaInstituicao)
        {

            // Busca um usuário através do Id
            Instituicao InstituicaoBuscada = context.Instituicoes.Find(id);

            // Verifica se o usuário foi informado
            if (NovaInstituicao.Instituicoes!= null)
            {
                // Atribui os novos valores aos campos existentes 
                InstituicaoBuscada.Instituicoes = NovaInstituicao.Instituicoes;
            }

            // Atualiza o usuário que foi buscado
            context.Instituicoes.Update(InstituicaoBuscada);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public Instituicao BuscarPorId(int id)
        {
            return context.Instituicoes.FirstOrDefault(I => I.IdInstituicao == id);
        }

        public void Cadastrar(Instituicao NovaInstituiucao)
        {
            context.Instituicoes.Add(NovaInstituiucao);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // Busca um usuário através do seu Id
            Instituicao InstituicaoBuscada = context.Instituicoes.Find(id);

            // Remove o usuário que foi buscado
            context.Instituicoes.Remove(InstituicaoBuscada);

            // Salva as alterações 
            context.SaveChanges();
        }

        public List<Instituicao> Listar()
        {
            return context.Instituicoes.ToList();
        }
    }
}
