using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using erik_tech.Clases;
using erik_tech.Models;
using erik_tech.Clases;
using System.Text.Encodings.Web;

namespace erik_tech.Pages
{
    public class EditarModel : PageModel
    {
        private readonly DbContextApp contexto;
        public bool error;

        public EditarModel(DbContextApp contexto)
        {
            this.contexto = contexto;
        }
        public IActionResult OnPost(
            string id,
            string nombre,
            string encabezado,
            string cuerpo,
            string linux = "off",
            string windows = "off",
            string macos = "off",
            string android = "off",
            string desarrollo = "off",
            string gaming = "off",
            string hardware = "off"
            )
        {

            try
            {
                Articulo articuloAModificar = contexto.articulo.Find(int.Parse(id));
            
                //Asignar todas las propiedades

                articuloAModificar.titulo_publicacion = nombre;
                articuloAModificar.encabezado = encabezado;
                articuloAModificar.cuerpo = cuerpo;
                articuloAModificar.Linux = linux.Equals("on");
                articuloAModificar.Windows = windows.Equals("on");
                articuloAModificar.Macos = macos.Equals("on");
                articuloAModificar.Android = android.Equals("on");
                articuloAModificar.Desarrollo = desarrollo.Equals("on");
                articuloAModificar.Gaming = gaming.Equals("on");
                articuloAModificar.Hardware = hardware.Equals("on");

                contexto.articulo.Update(articuloAModificar);
                contexto.SaveChanges();
                error = false;
            }
            catch (Exception e)
            {
                error = true;
            }
            

            return Page();
        }
    }
}