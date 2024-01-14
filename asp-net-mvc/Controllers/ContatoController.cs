using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_mvc.Context;
using asp_net_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace asp_net_mvc.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);    
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if(ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }
    }
}