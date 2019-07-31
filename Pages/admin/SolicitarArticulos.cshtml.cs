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
        public string BuscarCategoriasDeArticulo(int id_articulo)
        {
            string stringCategoriasDOM = "";

            if(contexto.linux.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM += "Linux ";
            }
            if(contexto.windows.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM += "Windows ";
            }
            if(contexto.macos.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM += "MacOS ";
            }
            if(contexto.android.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM += "Android ";
            }
            if(contexto.desarrollo.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM += "Desarrollo ";
            }
            if(contexto.gaming.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM += "Gaming ";
            }
            if(contexto.hardware.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM += "Hardware ";
            }
            if(contexto.sin_categoria.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                stringCategoriasDOM = "Este artículo fue publicado sin categoría.";
            }


            return stringCategoriasDOM;
        }
    }
}