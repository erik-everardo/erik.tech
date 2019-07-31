using erik_tech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace erik_tech.Pages
{
    public class BorrarModel : PageModel
    {
        private readonly DbContextApp contexto;
        public BorrarModel(DbContextApp _contexto)
        {
            contexto = _contexto;
        }
        public void OnPost(string id_articulo)
        {
            var articuloAEliminar = contexto.articulo.Where(articulo => articulo.Id.Equals(int.Parse(id_articulo))).Single();
            contexto.articulo.Remove(articuloAEliminar);
            EliminarArticuloDeCategorias(int.Parse(id_articulo));
            contexto.SaveChanges();
        }

        public void EliminarArticuloDeCategorias(int id_articulo)
        {
            if(contexto.linux.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.linux.Remove(contexto.linux.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
            if(contexto.windows.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.windows.Remove(contexto.windows.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
            if(contexto.macos.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.macos.Remove(contexto.macos.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
            if(contexto.android.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.android.Remove(contexto.android.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
            if(contexto.desarrollo.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.desarrollo.Remove(contexto.desarrollo.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
            if(contexto.gaming.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.gaming.Remove(contexto.gaming.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
            if(contexto.hardware.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.hardware.Remove(contexto.hardware.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
            if(contexto.sin_categoria.Where(cat => cat.id_articulo.Equals(id_articulo)).Any())
            {
                contexto.sin_categoria.Remove(contexto.sin_categoria.Where(cat => cat.id_articulo.Equals(id_articulo)).Single());
            }
        }
    }
}