using Blog.Infra;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAO
{
    public class PostDAO
    {

        private BlogContext contexto;

        public PostDAO(BlogContext contexto)
        {
            this.contexto = contexto;
        }

        public List<Post> Lista()
        {			
			List<Post> posts = contexto.Posts.ToList();
			return posts;           
        }

		public void Adiciona(Post post)
        {          
            contexto.Add(post);
            contexto.SaveChanges();         
        }

        public IList<Post> ListaPublicados()
        {        
           return contexto.Posts.Where(p => p.Publicado)
                                   .OrderByDescending(p => p.DataPublicacao).ToList();     
        }

        public IList<Post> BuscaPeloTermo(string termo)
        {            
            return contexto.Posts
                    .Where(p => (p.Publicado) && (p.Titulo.Contains(termo) || p.Resumo.Contains(termo)))
                    .ToList();           
        }

        public void Remove(int id)
        {           
             Post post = contexto.Posts.Find(id);
             contexto.Posts.Remove(post);

             contexto.SaveChanges();            
        }

        public List<Post> FiltraPorCategoria(string categoria)
        {            
            List<Post> posts = contexto
                                     .Posts
                                     .Where(post => categoria.Contains(post.Categoria))
                                     .ToList();                       
            return posts;
        }

        public void Atualiza(Post post)
        {           
            contexto.Entry(post).State = EntityState.Modified;

            contexto.SaveChanges();          
        }

        public Post BuscaPorId(int id)
        {
            Post post = contexto.Posts.Find(id);

            return post;
        }

        public void Publica(int id)
        {            
            Post post = contexto.Posts.Find(id);

            post.Publicado = true;
            post.DataPublicacao = DateTime.Now;

            contexto.SaveChanges();           
        }


    }
}
