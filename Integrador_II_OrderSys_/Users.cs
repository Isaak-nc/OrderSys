using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_II_OrderSys_
{
    internal class Users
    {
        public static void CrearArchivoSiNoExiste()
        {
            if (!File.Exists(Archivos.RutaUsuarios))
            {
                string[] iniciales =
                {
                    "admin|admin123|admin",
                    "mesero1|1234|mesero",
                    "cocina1|1234|cocina"
                };

                File.WriteAllLines(Archivos.RutaUsuarios, iniciales);
            }
        }

        public static string ValidarLogin(string usuario, string contraseña)
        {
            CrearArchivoSiNoExiste();

            string[] lineas = File.ReadAllLines(Archivos.RutaUsuarios);

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('|');

                if (partes.Length != 3)
                {
                    continue;
                }

                bool usuarioOk = string.Equals(partes[0].Trim(), usuario.Trim(),
                                               StringComparison.OrdinalIgnoreCase);
                bool passOk = partes[1] == contraseña;

                if (usuarioOk && passOk)
                {
                    return partes[2].Trim().ToLower();
                }
            }

            return null;
        }
    }
}
