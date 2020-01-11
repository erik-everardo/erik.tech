using System.Collections.Generic;
using System.Linq;
using erik_tech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace erik_tech.Pages.admin
{
    public class Imagen : PageModel
    {
        private readonly DbContextApp _contextApp;

        public Imagen(DbContextApp contextApp)
        {
            _contextApp = contextApp;
        }

        public List<urlImagen> ListaImagenes;
        public IActionResult OnGet(int idUsuario)
        {
            ListaImagenes = _contextApp.Imagenes.Where(obj => obj.IdUser.Equals(idUsuario)).ToList();
            return Page();
        }
    }
}