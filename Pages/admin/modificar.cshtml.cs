//Esta pagina solo recibe POST
//Esta hecha para responder a JavaScript
using erik_tech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace erik_tech.Pages
{
    public class ModificarModel : PageModel
    {
        private readonly DbContextApp contexto;
        public ModificarModel(DbContextApp contexto)
        {
            this.contexto = contexto;
        }

        //TODO: recibir encabezado, titulo de publicacion, cuerpo, categorias y palabras clave nuevas
        public IActionResult OnPost(string id_articulo)
        {
            Articulo articulo = contexto.articulo.Where(a => a.Id.Equals(int.Parse(id_articulo))).Single();
            //TODO logica para modificar cosas del articulo de arriba
            return Page();
        }
    }
}