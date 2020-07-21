using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
			var listaDePosts = new List<Post>()
			{

				new Post()
				{   
					Titulo = "Harry	Potter1",
					Resumo =  "Pedra	Filosofal",
					Categoria  =  "Filme,  Livro" 
				},

				new Post()
				{
					Titulo = "Harry	Potter2",
					Resumo =  "Pedra	Filosofal",
					Categoria  =  "Filme,  Livro"
				},

				new Post()
				{
					Titulo = "Harry	Potter3",
					Resumo =  "Pedra	Filosofal",
					Categoria  =  "Filme,  Livro"
				}

			};

			return View(listaDePosts);

		}

	}
}
