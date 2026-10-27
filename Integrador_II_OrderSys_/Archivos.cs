using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_II_OrderSys_
{
    internal class Archivos
    {
        public static string CarpetaDatos
        {
            get
            {
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
                Directory.CreateDirectory(carpeta);
                return carpeta;
            }
        }

        public static string RutaPedidos => Path.Combine(CarpetaDatos, "pedidos.txt");

        public static string RutaUsuarios => Path.Combine(CarpetaDatos, "usuarios.txt");

        public static string RutaFacturas => Path.Combine(CarpetaDatos, "facturas.txt");

        public static string RutaInventario => Path.Combine(CarpetaDatos, "inventario.txt");
    }

    internal static class Estado
    {
        public static Dictionary<int, List<string>> Comandas = new Dictionary<int, List<string>>();
        public static Dictionary<int, decimal> Totales = new Dictionary<int, decimal>();
    }


}
