//Esta clase contiene varios metodos estaticos que pueden ser llamados desde cualquier pagina
using erik_tech.Pages;
using erik_tech.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace erik_tech.Clases
{
    public class MetodosEstaticoGeneralesErikTech
    {
        public static List<Articulo> ObtenerArticulosAutor(int id_autor, DbContextApp contexto)
        {
            List<Articulo> articulos = contexto.articulo.Where(a => a.autor_id.Equals(id_autor)).ToList();
            return articulos;
        }
        public static Dictionary<int,bool> ObtenerCategoriasDeArticulo(int id_articulo, DbContextApp contexto)
        {

            /*Las categorias tienen un numero:
            1 -> linux
            2 -> windows
            3 -> macos
            4 -> android
            5 -> desarrollo
            6 -> gaming
            7 -> hardware
            8 -> sin categoria
             */
            Dictionary<int,bool> categorias = new Dictionary<int,bool>();

            //el diccionario es llenado de esta manera, 
            //por defecto ninguna categoria es verdad
            categorias.Add(1,false);
            categorias.Add(2,false);
            categorias.Add(3,false);
            categorias.Add(4,false);
            categorias.Add(5,false);
            categorias.Add(6,false);
            categorias.Add(7,false);
            categorias.Add(8,false);

            /*se comprueba en cada tabla de categoria en la base de datos
            y se cambia cada registro del diccionario a verdadero en caso de que se
            encuentre*/

            if(contexto.linux.Where(l => l.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[1] = true;
            }
            if(contexto.windows.Where(w => w.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[2] = true;
            }
            if(contexto.macos.Where(m => m.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[3] = true;
            }
            if(contexto.android.Where(a => a.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[4] = true;
            }
            if(contexto.desarrollo.Where(a => a.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[5] = true;
            }
            if(contexto.gaming.Where(g => g.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[6] = true;
            }
            if(contexto.hardware.Where(h => h.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[7] = true;
            }
            if(contexto.sin_categoria.Where(sc => sc.id_articulo.Equals(id_articulo)).Any())
            {
                categorias[8] = true;
            }

            return categorias;

        }
    }
}