using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Integrador_II_OrderSys_
{
    internal class Pedidos
    {
         public static List<string[]> Leer()
    {
        var lista = new List<string[]>();
        if (!File.Exists(Archivos.RutaPedidos)) return lista;

        foreach (string linea in File.ReadAllLines(Archivos.RutaPedidos))
        {
            string[] p = linea.Split('|');
            if (p.Length == 6) lista.Add(p);
        }
        return lista;
    }

    public static void Guardar(List<string[]> pedidos)
    {
        File.WriteAllLines(Archivos.RutaPedidos,
            pedidos.Select(p => string.Join("|", p)));
    }
    }
}
