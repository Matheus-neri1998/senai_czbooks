using Senai_CZ_Books_Web_API.Contexts;
using Senai_CZ_Books_Web_API.Domains;
using Senai_CZ_Books_Web_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        CzBooksContext context = new CzBooksContext();
        public void Atualizar(int id, Categoria NovoCategoria)
        {
            // Busca um usuário através do Id
            Categoria CategoriaEncontrada = context.Categoria.Find(id);

            // Verifica se o usuário foi informado
            if (NovoCategoria.Categorias != null)
            {
                // Atribui os novos valores aos campos existentes 
                CategoriaEncontrada.Categorias = NovoCategoria.Categorias;
            }

            // Atualiza o usuário que foi buscado
            context.Categoria.Update(NovoCategoria);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public Categoria BuscarPorId(int id)
        {
            return context.Categoria.FirstOrDefault(C => C.IdCategoria == id);
        }

        public void Cadastrar(Categoria NovaCategoria)
        {
            context.Categoria.Add(NovaCategoria);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public void Deletar(int id)
        {

            // Busca um usuário através do seu Id
            Categoria CategoriaEncontrada = context.Categoria.Find(id);

            // Remove o usuário que foi buscado
            context.Categoria.Remove(CategoriaEncontrada);

            // Salva as alterações 
            context.SaveChanges();
        }

        public List<Categoria> Listar()
        {
            return context.Categoria.ToList();
        }
    }
}
