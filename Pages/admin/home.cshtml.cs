using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using erik_tech.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace erik_tech.Pages
{
    public class homeModel : PageModel
    {

        private readonly DbContextApp contexto;
        public homeModel(DbContextApp dbContext)
        {
            contexto = dbContext;
        }
        public IActionResult OnGet(){
            return Redirect("/no_entre.html");
        }
        public IActionResult OnPost(string username,string password)
        {
            RecuperarDatos(username,password);
            

            return Page();
        }
        //recuperar todos los datos del usuario ademas del nombre y la contraseña
        public void RecuperarDatos(string name, string password)
        {
            //Definitivamente el usuario existe y la contraseña es correcta.
            //Es la segunda validación, la primera fue hecha directamente por el cliente
            if(contexto.cuenta.Where(u => u.username.Equals(name) && u.password.Equals(password)).Any())
            {
                var usuario = contexto.cuenta.Where(u => u.username.Equals(name) && u.password.Equals(password)).Single();
                
                ViewData["nombre_de_usuario"] = name;
                ViewData["password_usuario"] = password;
                ViewData["correo"] = usuario.email;
                ViewData["id_usuario"] = usuario.Id;
            }
            //por alguna razon no es correcta la credencial. CUIDADO
            else
            {
                RedirectToPage("Index");
            }
        }

    }
}