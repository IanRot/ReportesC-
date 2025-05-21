using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reportesC_
{
    public class Producto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }    
        public string Categoria { get; set; }      
        public int Cantidad { get; set; }          
        public decimal Precio_Unitario { get; set; } 
        public decimal Descuento { get; set; }

        
    }
    
}
