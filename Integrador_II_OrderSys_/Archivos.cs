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
    }
}
