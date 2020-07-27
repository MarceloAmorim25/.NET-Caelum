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
		public List<Post> Lista()
        {
			using(BlogContext contexto = new BlogContext())
            {
				List<Post> posts = contexto.Posts.ToList();
				return posts;
            };
        }

		public void Adiciona(Post post)
        {
            using (BlogContext contexto = new BlogContext())
            {
                contexto.Add(post);
                contexto.SaveChanges();
            };
        }

        public void Remove(int id)
        {
            using (BlogContext contexto = new BlogContext())
            {
                Post post = contexto.Posts.Find(id);
                contexto.Posts.Remove(post);
                contexto.SaveChanges();
            };
        }

        public List<Post> FiltraPorCategoria(string categoria)
        {

            using var contexto = new BlogContext();
            
            List<Post> posts = contexto
                                     .Posts
                                     .Where(post => categoria.Contains(post.Categoria))
                                     .ToList();
                        
            return posts;
        }

        public void Atualiza(Post post)
        {
            using var contexto = new BlogContext();     
            
            contexto.Entry(post).State = EntityState.Modified;

            contexto.SaveChanges();            
        }

        public void Publica(int id)
        {
            using var contexto = new BlogContext();
            
            Post post = contexto.Posts.Find(id);

            post.Publicado = true;
            post.DataPublicacao = DateTime.Now;

            contexto.SaveChanges();
            
        }
    }
}
