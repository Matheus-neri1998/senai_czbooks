using Senai_CZ_Books_Web_API.Contexts;
using Senai_CZ_Books_Web_API.Domains;
using Senai_CZ_Books_Web_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZ_Books_Web_API.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        CzBooksContext context = new CzBooksContext();
        public void Atualizar(int id, Usuarios NovoUsuario)
        {
            // Busca um usuário através do Id
            Usuarios UsuarioBuscado = context.Usuarios.Find(id);

            // Verifica se o usuário foi informado
            if (NovoUsuario.Autores != null)
            {
                // Atribui os novos valores aos campos existentes 
                UsuarioBuscado.Autores = NovoUsuario.Autores;
            }

            // Atualiza o usuário que foi buscado
            context.Usuarios.Update(UsuarioBuscado);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public Usuarios BuscarPorId(int id)
        {
            return context.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuarios NovoUsuario)
        {
            context.Usuarios.Add(NovoUsuario);

            // Salva as informações para serem gravadas no banco
            context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // Busca um usuário através do seu Id
            Usuarios UsuarioBuscado = context.Usuarios.Find(id);

            // Remove o usuário que foi buscado
            context.Usuarios.Remove(UsuarioBuscado);

            // Salva as alterações 
            context.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            // Retorna uma lista com todas as informações dos tipos de usuários
            return context.Usuarios.ToList();
        }

        public Usuarios Login(string Email, string Senha)
        {
            // Retorna o usuário encontrado através do email e da senha
            return context.Usuarios.FirstOrDefault(u => u.Email == Email && u.Senha == Senha);
        }
    }

        
    }
}
