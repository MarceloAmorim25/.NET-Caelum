using Blog.DAO;
using Blog.Infra;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
			listaDePosts = new List<Post>();								
		}

        public IActionResult Index()
        {

			var listaDePosts = new PostDAO().Lista();

			return View(listaDePosts);

		}
		
		public IActionResult Novo()
		{
			var model = new Post();
			return View(model);
		}

		public IActionResult BuscarPorCategoria(string categoria)
        {
			List<Post> lista = new PostDAO().FiltraPorCategoria(categoria);
			return View("Index", lista);	

		}

		[HttpPost]
		public IActionResult Adiciona(Post post)
		{
            if (ModelState.IsValid)
            {
				PostDAO dao = new PostDAO();
				dao.Adiciona(post);

				return View("Index", listaDePosts);
            }
            else
            {
				return View("Novo");
            }
		}

		public IActionResult Remove(int id)
		{
			PostDAO dao = new PostDAO();
			dao.Remove(id);

			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Edita(Post post)
		{
			if(ModelState.IsValid)
            {
				PostDAO dao = new PostDAO();
				dao.Atualiza(post);
				return RedirectToAction("Index");

			}else
            {
				return View("Visualiza", post);
            }

		}

		public IActionResult Publica(int id)
		{
			PostDAO dao = new PostDAO();
			dao.Publica(id);
			return RedirectToAction("Index");
		}

	}
}
