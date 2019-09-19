using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persitences;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class ImovelController : Controller
    {
        private BancoContext _context;

        public ImovelController(BancoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Imovel imovel)
        {
            _context.Imoveis.Add(imovel);
            _context.SaveChanges();

            TempData["mensagem"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");

        }

    }
}