using System;
using System.ComponentModel.DataAnnotations;
namespace erik_tech.Models
{
    public class Articulo
    {
        public int Id {get;set;}
        public string titulo_publicacion {get;set;}
        public string encabezado {get;set;}
        public string cuerpo {get;set;}
        public int autor_id {get;set;}        
        [DataType(DataType.Date)]
        public DateTime fecha_publicacion {get;set;}
    }
}