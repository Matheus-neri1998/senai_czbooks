using Senai_CZ_Books_Web_API.Contexts;
using Senai_CZ_Books_Web_API.Domains;
using Senai_CZ_Books_Web_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        CzBooksContext context = new CzBooksContext();
        public void Atualizar(int id, Autor NovoAutor)
        {
            // Busca um usuário através do Id
            Autor AutorEncontrado = context.Autores.Find(id);

            // Verifica se o usuário foi informado
            if (AutorEncontrado.NomeAutor != null)
            {
                // Atribui os novos valores aos campos existentes 
                AutorEncontrado.NomeAutor = NovoAutor.NomeAutor;
            }

            // Atualiza o usuário que foi buscado
            context.Autores.Update(NovoAutor);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public Autor BuscarPorId(int id)
        {
            return context.Autores.FirstOrDefault(a => a.IdAutor == id);
        }

        public void Cadastrar(Autor NovoAutor)
        {
            context.Autores.Add(NovoAutor);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public void Deletar(int id)
        {

            // Busca um usuário através do seu Id
            Autor AutorEncontrado = context.Autores.Find(id);

            // Remove o usuário que foi buscado
            context.Autores.Remove(AutorEncontrado);

            // Salva as alterações 
            context.SaveChanges();
        }

        public List<Autor> Listar()
        {
            return context.Autores.ToList();
        }
    }
}
