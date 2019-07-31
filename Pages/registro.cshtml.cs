using Microsoft.AspNetCore.Mvc.RazorPages;
using erik_tech.Models;
using Microsoft.AspNetCore.Mvc;

namespace erik_tech.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly DbContextApp _dbContext;
        public RegistroModel(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult OnPost(string username, string password, string email)
        {
           Cuenta cuenta = new Cuenta();
           cuenta.username = username;
           cuenta.password = password;
           cuenta.email = email;
           _dbContext.cuenta.Add(cuenta);

           _dbContext.SaveChanges();
           return Page();
        }
    }
}