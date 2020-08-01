using Blog.Infra;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAO
{
    public class UsuarioDAO
    {
        private readonly BlogContext contexto;

        public UsuarioDAO(BlogContext contexto)
        {
            this.contexto = contexto;
        }

        public Usuario Busca(string login, string senha)
        {

            return contexto.Usuarios
                                .Where(Usuario =>
                                 Usuario.Nome.Equals(login) 
                                 && Usuario.Senha.Equals(senha))
                                .FirstOrDefault();

        }

    }
}
