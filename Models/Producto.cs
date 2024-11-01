using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int Id { get; set; }

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        
        public decimal Precio { get; set; }
        
        public int Stock { get; set; }
        
        public int CategoriaId { get; set; }
        
        public Categoria Categoria { get; set; }
        
        public DateTime FechaCreacion { get; set; }
        
        public DateTime FechaActualizacion { get; set; }
    }
}