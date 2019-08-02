using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using erik_tech.Models;
using System.Collections.Generic;
using System.Linq;


namespace erik_tech.Pages
{
    public class SolicitarArticuloModel : PageModel
    {
        private readonly DbContextApp contexto;
        public List<Articulo> articulos = new List<Articulo>();
        public SolicitarArticuloModel(DbContextApp _contexto)
        {
            contexto = _contexto;
        }
        public IActionResult OnGet()
        {
            return Redirect("/no_entre.html");
        }
        public IActionResult OnPost(string ID_usuario)
        {
            
            articulos = contexto.articulo.Where(a => a.autor_id.Equals(int.Parse(ID_usuario))).ToList();
            
            return Page();
        }
    }
}