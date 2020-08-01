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

namespace Blog.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class PostController : Controller
    {

		private IList<Post> listaDePosts;
		private PostDAO dao;

		public PostController(PostDAO dao)
        {
			listaDePosts = new List<Post>();
			this.dao = dao;
		}

        public IActionResult Index()
        {
			var listaDePosts = dao.Lista();
			return View(listaDePosts);
		}
		
		public IActionResult Novo()
		{
			var model = new Post();
			return View(model);
		}

		public IActionResult BuscarPorCategoria(string categoria)
        {
			List<Post> lista = dao.FiltraPorCategoria(categoria);
			return View("Index", lista);	
		}

		[HttpPost]
		public IActionResult Adiciona(Post post)
		{
            if (ModelState.IsValid)
            {
				dao.Adiciona(post);
				return View("Index", listaDePosts);

            }
            else
            {
				return View("Novo");
            }
		}

		[HttpPost]
		public IActionResult Edita(Post post)
		{
			if (ModelState.IsValid)
			{
				dao.Atualiza(post);
				return RedirectToAction("Index");
			}
			else
			{
				return View("Visualiza", post);
			}
		}

		public IActionResult Remove(int id)
		{
			dao.Remove(id);

			return RedirectToAction("Index");
		}

		public IActionResult Publica(int id)
		{
	
			dao.Publica(id);
			return RedirectToAction("Index");
		}

		public IActionResult Visualiza(int id)
		{
		
			var post = dao.BuscaPorId(id);

			return View(post);
		}

	}
}
