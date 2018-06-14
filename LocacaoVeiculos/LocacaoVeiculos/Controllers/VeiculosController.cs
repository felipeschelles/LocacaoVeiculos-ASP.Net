using LocacaoVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocacaoVeiculos.Controllers
{
    public class VeiculosController : Controller
    {
        // GET: Veiculos
        public ActionResult Index()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos.Add(

                new Veiculo()
                {
                    Nome = "Carro"
                }

                );

            veiculos.Add(new Veiculo() { Nome = "Fusca" });
            veiculos.Add(new Veiculo() { Nome = "Gol" });
            veiculos.Add(new Veiculo() { Nome = "Focus" });


            ViewBag.MinhasCategorias = veiculos;

            return View();
        }


        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(string nome, string cor, int ano)
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                // salvar no banco
            }
            return View(veiculo);
        }

    }
}
