using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudReact.Models
{
    public class Almacenes
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string ubicacion { get; set; }
        
    }
}
