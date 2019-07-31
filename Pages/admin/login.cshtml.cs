using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using erik_tech.Models;
using System.Linq;
namespace erik_tech.Pages
{
    public class loginModel : PageModel
    {
        private readonly DbContextApp contexto;

        public loginModel(DbContextApp DBContext)
        {
            contexto = DBContext;
        }
        public IActionResult OnGet()
        {
            return Redirect("/si.html");
        }

        public IActionResult OnPost(string username, string password)
        {
            if(
                !string.IsNullOrWhiteSpace(username) && 
                !string.IsNullOrEmpty(username) && 
                !string.IsNullOrWhiteSpace(password) && 
                !string.IsNullOrEmpty(password))
            {
                if(contexto.cuenta.Where(c => c.username.Equals(username) && c.password.Equals(password)).Any())
                {
                    return Redirect("/si.html");
                }
                else{
                    return Redirect("/no.html");
                }
            }
            else
            {
                return Redirect("/no.html");
            }
            

        }
    }
}