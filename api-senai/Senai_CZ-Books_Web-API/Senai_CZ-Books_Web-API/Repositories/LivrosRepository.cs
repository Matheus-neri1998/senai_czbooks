using Senai_CZ_Books_Web_API.Contexts;
using Senai_CZ_Books_Web_API.Domains;
using Senai_CZ_Books_Web_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Repositories
{
    public class LivrosRepository : ILivrosRepository
    {
        CzBooksContext context = new CzBooksContext();
        public void Atualizar(int id, Livros NovoLivro)
        {
            // Busca um usuário através do Id
            Livros LivroBuscado = context.Livros.Find(id);

            // Verifica se o usuário foi informado
            if (NovoLivro.Titulo != null)
            {
                // Atribui os novos valores aos campos existentes 
                LivroBuscado.Titulo = NovoLivro.Titulo;
            }

            // Atualiza o usuário que foi buscado
            context.Livros.Update(LivroBuscado);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public Livros BuscarPorId(int id)
        {
            return context.Livros.FirstOrDefault(l => l.IdLivro == id);
        }

        public void Cadastrar(Livros NovoLivro)
        {
            context.Livros.Add(NovoLivro);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // Busca um usuário através do seu Id
            Livros LivroBuscado = context.Livros.Find(id);

            // Remove o usuário que foi buscado
            context.Livros.Remove(LivroBuscado);

            // Salva as alterações 
            context.SaveChanges();
        }

        public List<Livros> Listar()
        {
            return context.Livros.ToList();
        }
    }
}
