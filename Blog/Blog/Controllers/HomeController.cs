using Blog.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private PostDAO dao;
        public HomeController(PostDAO dao)
        {
            this.dao = dao; 
        }

        //GET: Home
        public IActionResult Index()
        {

            IList<Post> publicados = dao.ListaPublicados();
            return View(publicados);
        }

        //Método Index anterior
        public IActionResult Busca(string termo)
        {
            IList<Post> posts = dao.BuscaPeloTermo(termo);
            return View("Index", posts);
        }

    }
}
