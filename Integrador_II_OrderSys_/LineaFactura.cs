using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_II_OrderSys_
{
    public class LineaFactura
    {
        public string Codigo;
        public string Descripcion;
        public int Cantidad;
        public decimal Precio;
        public decimal Subtotal => Cantidad * Precio;
    }
}
