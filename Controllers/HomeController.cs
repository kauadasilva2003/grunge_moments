using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using etapa3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace etapa3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

     
        public IActionResult Index()
        {
            return View();
        }
      
        /*CADASTRO DE USUÁRIOS*/
         public IActionResult Cadastro()
        {   
            return View();
        }

          [HttpPost]  
         public IActionResult Cadastro(Usuario user)
        {   
            usuarioRepository ur = new usuarioRepository();
            ur.Insert(user);
            ViewBag.Cadastro = "Usuário cadastrado com sucesso!";
            return View();
        }

           public IActionResult Galeria()
        {
            return View();
        }

           public IActionResult Noticias()
        {
            return View();
        }

           public IActionResult Produtos()
        {
            return View();
        }
    }
}