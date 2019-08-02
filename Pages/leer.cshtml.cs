using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using erik_tech.Models;
using Microsoft.AspNetCore.Html;

namespace erik_tech.Pages
{
    public class LeerModel : PageModel
    {
        private readonly DbContextApp contexto;
        public Articulo articulo;
        public LeerModel(DbContextApp _contexto)
        {
            contexto = _contexto;
        }
        public IActionResult OnGet(string id)
        {
            articulo = contexto.articulo.Where(a => a.Id.Equals(int.Parse(id))).Single();
            
            return Page();
        }
        public string BuscarNombreAutorPorIdArticulo(int id)
        {
            var autor = contexto.cuenta.Where(c => c.Id.Equals(id)).Single();
            return autor.username;
        }
        
    }
}