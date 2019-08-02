/*
Hay que traer los articulos más recientes y
traer la capacidad de mostrar artículos de cada categoria

Tambien hay que agregar la busqueda

Todo eso será en esta pagina
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using erik_tech.Models;

namespace erik_tech.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DbContextApp contexto;
        public string categoria;
        public List<Articulo> articulos;
        public bool solicitoCategoria;
        public IActionResult OnGet([FromQuery] string categoria)
        {
            if(categoria == null)
            {
                solicitoCategoria = false;
            }
            else
            {
                solicitoCategoria = true;
                //TODO: lista de articulos dependiendo de los ids de articulo dados
                //por la categoria. Utilizar metodo:
                //"MetodosGeneralesErikTech.ObtenerArticulosPorIdCategoria(int categoria,DbContextApp contexto)"



            }
            return Page();
        }
    }
}
