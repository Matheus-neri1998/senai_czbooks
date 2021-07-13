using Senai_CZ_Books_Web_API.Contexts;
using Senai_CZ_Books_Web_API.Domains;
using Senai_CZ_Books_Web_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Repositories
{
    public class TiposUsuariosRepository : ITiposUsuariosRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        CzBooksContext context = new CzBooksContext();

        public void Atualizar(int id, TiposUsuarios NovoTipoUsuario)
        {
            // Busca um tipo de usuário através do Id
            TiposUsuarios TipoUsuarioBuscado = context.TiposUsuarios.Find(id);

            // Verifica se o título do tipo de usuário foi informado
            if (NovoTipoUsuario.TipoUsuario != null)
            {
                // Atribui os novos valores aos campos existentes 
                TipoUsuarioBuscado.TipoUsuario = NovoTipoUsuario.TipoUsuario;
            }

            // Atualiza o tipo de usuário que foi buscado
            context.TiposUsuarios.Update(TipoUsuarioBuscado);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();

        } // Fim do método Atualizar

        public TiposUsuarios BuscarPorId(int id)
        {
            // Retorna o primeiro tipo de usuário encontrado para o ID informado
            return context.TiposUsuarios.FirstOrDefault(tu => tu.IdTipoUsuario == id);
        }

        public void Cadastrar(TiposUsuarios NovoTipoUsuario)
        {
            // Adiciona "TipoUsuario"
            context.TiposUsuarios.Add(NovoTipoUsuario);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // Busca um tipo de usuário através do seu Id
            TiposUsuarios TipoUsuarioBuscado = context.TiposUsuarios.Find(id);

            // Remove o tipo de usuário que foi buscado
            context.TiposUsuarios.Remove(TipoUsuarioBuscado);

            // Salva as alterações 
            context.SaveChanges();
        }

        public List<TiposUsuarios> Listar()
        {
            // Retorna uma lista com todas as informações dos tipos de usuários
            return context.TiposUsuarios.ToList();
        }
    }
}
