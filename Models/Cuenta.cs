using System;
using System.ComponentModel.DataAnnotations;

namespace erik_tech.Models
{
    public class Cuenta
    {
        public int Id {get;set;}
        public string username {get;set;}
        public string password {get;set;}
        public string email {get;set;}
    }
}