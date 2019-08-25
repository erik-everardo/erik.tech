using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using erik_tech.Models;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

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
            try
            {
                Cuenta usuario = contexto.cuenta.Single(u => u.username.Equals(username));
                if (usuario.password == password)
                {
                    RecuperarDatos(username,password);
                    return Page();
                }
                else
                {
                    return RedirectToPage("/admin/Index", new{err = "contra-mala", usuario = username});
                }
            }
            catch (Exception e)
            {
                return RedirectToPage("/admin/Index",new {err = "nousuario"});
            }
            
            
            

            
        }
        //recuperar todos los datos del usuario ademas del nombre y la contraseña
        public void RecuperarDatos(string name, string password)
        {
            //Definitivamente el usuario existe y la contraseña es correcta.
            //Es la segunda validación, la primera fue hecha directamente por el cliente
            if(contexto.cuenta.Any(u => u.username.Equals(name) && u.password.Equals(password)))
            {
                var usuario = contexto.cuenta.Single(u => u.username.Equals(name) && u.password.Equals(password));
                
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