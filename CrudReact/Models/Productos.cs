using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudReact.Models
{
    public class Productos
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string descripcion { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Fecha_venc { get; set; }
        public int id_proveedor{ get; set; }
    }
}
