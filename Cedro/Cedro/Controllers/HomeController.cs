using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cedro.Models;
using Cedro.Model;

namespace Cedro.Controllers
{
    public class HomeController : Controller
    {
        //http://localhost:51701/Home/Computadores?nome=UltraPC&preco=4000&especificacao=gtx1080

        //quando for enviado pelo endereço URL acima
        [HttpGet]
        public IActionResult Computadores()
        {
            return View();
        }

        //quando for enviado pelo botão enviar no cadastro
        [HttpPost]
        public IActionResult Computadores(Computadores computadores)
        {
            if (ModelState.IsValid)
            {
                var Repositorio = new Repositorio();
                Repositorio.cadastre(computadores);
                //ele redireciona pra outro lugar diferente do else, no caso para a lista
                return RedirectToAction(nameof(Lista));
                //nameof permite que mesmo eu alterando a palavra lista do public a baixo esse lista do return si altere junto
            }
            else
            {
                return View(computadores);
            }
            
        }

        public IActionResult Lista()
        {
            var Repositorio = new Repositorio();
            var listadeComputadores = Repositorio.Liste();
            return View(listadeComputadores);
        }


        public IActionResult Index()
        {
            return View();
        }

    }
}
