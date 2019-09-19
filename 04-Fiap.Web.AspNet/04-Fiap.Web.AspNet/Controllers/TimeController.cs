using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.AspNet.Controllers
{
    public class TimeController : Controller
    {
        private static IList<Time> _lista = new List<Time>();

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Time time)
        {
            _lista.Add(time);
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Listar");
        }
    }
}