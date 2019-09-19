using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_Fiap.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {
        //Simular o banco de dados
        private static IList<Usuario> _banco = 
                                new List<Usuario>();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            //Enviar as informações para a tela
            ViewData["nome"] = usuario.Nome;
            ViewData["data"] = usuario.DataNascimento;
            ViewBag.endEletronico = usuario.Email;
            TempData["msg"] = "Usuário cadastrado!";
            //Cadastrar no "banco" de dados
            _banco.Add(usuario);
            //Enviar o objeto para tela
            return View(usuario);
        }

        public IActionResult Listar()
        {
            //Enviar a lista de usuários para a tela
            return View(_banco);
        }

    }
}