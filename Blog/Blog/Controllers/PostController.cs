using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostController : Controller
    {

		private IList<Post> listaDePosts;

		public PostController()
        {
            listaDePosts = new List<Post>()
			{				
				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},

				new Post(){Titulo = "Arquitetura Moderna e Bauhaus", Resumo =  "Brasília", Categoria  =  "Arquitetura"},
				
			};
		}

        public IActionResult Index()
        {

			//Como obter dados de post do banco?

			//1 - conection string			
			//2 - criar objeto de conexão
			//3 - abrir a conexão
			//4 - executar o comando = "select * from Post"
			//5 - jogar o DataTable em uma variável
			//6 - fechar a conexão
			//7 - retorna o objeto para o controller
			//8 - retorna para View

			//var stringConnection = "string de conexão";

			var conexao = new SqlConnection();
			conexao.Open();

			var select = "select * from Post";
			var comando = conexao.CreateCommand();

			comando.CommandText = select;
			var dataReader = comando.ExecuteReader();

			conexao.Close();

			//mapear as colunas para o objeto Post;

			return View(listaDePosts);

		}

		public IActionResult Novo()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Adiciona(Post post)
		{
			listaDePosts.Add(post);
			return View("Index", listaDePosts);
		}

	}
}
