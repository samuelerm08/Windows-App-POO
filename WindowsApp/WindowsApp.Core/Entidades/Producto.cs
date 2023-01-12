using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Core.Entidades
{   
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }             
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        
        public decimal PrecioBruto { get => PrecioCosto + Convert.ToDecimal(Margen); }
        public decimal PrecioVenta { get => PrecioBruto * Convert.ToDecimal(1 + this.IVA); }        
      
        public override string ToString()
        {            
            return $"Nombre: {Nombre}\n" +
                   $"Descripcion: {Descripcion}\n" +
                   $"Precio Costo: {PrecioCosto}\n" +
                   $"Margen: {Margen}\n" +
                   $"IVA: {IVA}\n" +
                   $"Proveedor: {Proveedor}\n" +
                   $"Categoria: {Categoria}\n" +
                   $"Subcategoria: {Subcategoria}\n" +
                   $"Precio Bruto: {PrecioBruto}\n" +
                   $"Precio Venta: {PrecioVenta} \n";
        }
    }
}
