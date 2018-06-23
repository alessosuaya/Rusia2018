using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RUSIA2018.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RUSIA2018
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Vivo()
        {
            return View();
        }
        public IActionResult Resultados()
        {
            return View();
        }
        public IActionResult Registrarse()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Registrarse(string nickname,string correo)
        {
            Registro r = new Registro();
            r.Nick = nickname;
            r.Correo = correo;
            r.MostrarNombre(nickname,correo);
            return View(r);
        }
        public IActionResult Noticias()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
