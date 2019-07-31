//esta pagina recibe un articulo, lo comprueba y lo registra
//en la base de datos

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using erik_tech.Models;
using System;
using System.Linq;

namespace erik_tech.Pages
{
    public class PublicarModel : PageModel
    {
        private readonly DbContextApp contexto;
        public PublicarModel(DbContextApp _dbcontext)
        {
            contexto = _dbcontext;
        }
        public IActionResult OnGet()
        {
            return Redirect("/no_entre.html");
        }

        //subir el articulo a la base de datos
        public void OnPost(
            string titulo_publicacion,
            string autor,
            string cuerpo,
            string encabezado,
            string linux = "0",
            string windows = "0",
            string macos = "0",
            string android = "0",
            string desarrollo = "0",
            string gaming = "0",
            string hardware = "0")
        {
            Articulo _articulo = new Articulo();
            _articulo.encabezado = encabezado;
            _articulo.cuerpo = cuerpo;
            _articulo.fecha_publicacion = DateTime.Today;
            _articulo.autor_id = buscarIdAutorPorNombre(autor);
            _articulo.titulo_publicacion = titulo_publicacion;


            contexto.articulo.Add(_articulo);
            contexto.SaveChanges();
            registrarEnCategorias(buscarIdArticuloPorTitulo(titulo_publicacion),linux,windows,macos,android,desarrollo,gaming,hardware);

        }
        public int buscarIdArticuloPorTitulo(string titulo)
        {
            Articulo articuloEncontrado = contexto.articulo.Where(a => a.titulo_publicacion.Equals(titulo)).Single();
            return articuloEncontrado.Id;
        }

        public int buscarIdAutorPorNombre(string nombre)
        {
            if(contexto.cuenta.Where(c => c.username.Equals(nombre)).Any())
            {
                var autor = contexto.cuenta.Where(c => c.username.Equals(nombre)).Single();
                return autor.Id;
            }
            else
            {
                return -1;
            }
        }
        public void registrarEnCategorias(
            int id_articulo,
            string linux = "0",
            string windows = "0",
            string macos = "0",
            string android = "0",
            string desarrollo = "0",
            string gaming = "0",
            string hardware = "0")
        {

            if(linux=="1")
            {
                linux articuloLinux = new linux();
                articuloLinux.id_articulo = id_articulo;
                contexto.linux.Add(articuloLinux);
                contexto.SaveChanges();
            }
            if(windows=="1")
            {
                windows articuloWindows = new windows();
                articuloWindows.id_articulo = id_articulo;
                contexto.windows.Add(articuloWindows);
                contexto.SaveChanges();
            }
            if(macos=="1")
            {
                macos articuloMacos = new macos();
                articuloMacos.id_articulo = id_articulo;
                contexto.macos.Add(articuloMacos);
                contexto.SaveChanges();

            }
            if(android=="1")
            {
                android articuloAndroid = new android();
                articuloAndroid.id_articulo = id_articulo;
                contexto.android.Add(articuloAndroid);
                contexto.SaveChanges();
            }
            if(desarrollo=="1")
            {
                desarrollo articuloDesarrollo = new desarrollo();
                articuloDesarrollo.id_articulo = id_articulo;
                contexto.desarrollo.Add(articuloDesarrollo);
                contexto.SaveChanges();
            }
            if(gaming=="1")
            {
                gaming articuloGaming = new gaming();
                articuloGaming.id_articulo = id_articulo;
                contexto.gaming.Add(articuloGaming);
                contexto.SaveChanges();
            }
            if(hardware=="1")
            {
                hardware articuloHardware = new hardware();
                articuloHardware.id_articulo = id_articulo;
                contexto.hardware.Add(articuloHardware);
                contexto.SaveChanges();
            }
            if(linux=="0" && windows=="0" && macos=="0" && android=="0" && desarrollo=="0" && gaming=="0" && hardware=="0")
            {
                sinCategoria articuloSinCategoria = new sinCategoria();
                articuloSinCategoria.id_articulo = id_articulo;
                contexto.sin_categoria.Add(articuloSinCategoria);
                contexto.SaveChanges();
            }
        }
    }
}