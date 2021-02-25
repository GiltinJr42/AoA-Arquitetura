using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AoA_Arquitetura.Models;
using AoA_Arquitetura.Controllers;

namespace AoA_Arquitetura.Controllers
{
    public class ProjetoController : Controller
    {
        // GET: Projeto
        public ActionResult Index()
        {
            return View(projetos);
        }
        private static readonly IList<Projeto> projetos = new List<Projeto>()
        {
            new Projeto() { ProjetoId = 1, Nome = "Casa de Praia"},
            new Projeto() { ProjetoId = 2, Nome = "Apartamento"},
            new Projeto() { ProjetoId = 3, Nome = "Orquestra"},
            new Projeto() { ProjetoId = 4, Nome = "Casa"},
            new Projeto() { ProjetoId = 5, Nome = "Prédio"}
        };

    }
}