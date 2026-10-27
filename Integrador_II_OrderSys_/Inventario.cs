using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Integrador_II_OrderSys_
{
    internal class ItemInventario
    {
        public string Codigo;
        public string Descripcion;
        public decimal Precio;
        public int Stock;
    }

    internal static class Inventario
    {
        private static void CrearSiNoExiste()
        {
            if (File.Exists(Archivos.RutaInventario)) return;
            File.WriteAllLines(Archivos.RutaInventario, new[]
            {
                "P01|Pizza de queso|450.00|20",
                "P02|Pizza hawaiana|500.00|20",
                "P03|Pizza de pepperoni|400.00|20",
                "P04|Chilaquiles|350.00|20",
                "P05|Tacos mexicanos|250.00|20"
            });
        }

        public static List<ItemInventario> Leer()
        {
            CrearSiNoExiste();
            var lista = new List<ItemInventario>();
            foreach (string linea in File.ReadAllLines(Archivos.RutaInventario))
            {
                string[] p = linea.Split('|');
                decimal precio; int stock;
                if (p.Length != 4) continue;
                if (!decimal.TryParse(p[2], NumberStyles.Number, CultureInfo.InvariantCulture, out precio)) continue;
                if (!int.TryParse(p[3], out stock)) continue;
                lista.Add(new ItemInventario { Codigo = p[0], Descripcion = p[1], Precio = precio, Stock = stock });
            }
            return lista;
        }

        public static void Guardar(List<ItemInventario> items)
        {
            File.WriteAllLines(Archivos.RutaInventario, items.Select(i =>
                $"{i.Codigo}|{i.Descripcion}|{i.Precio.ToString("F2", CultureInfo.InvariantCulture)}|{i.Stock}"));
        }

        public static void Descontar(List<LineaFactura> lineas)
        {
            var items = Leer();
            foreach (LineaFactura l in lineas)
            {
                var it = items.FirstOrDefault(i => i.Codigo == l.Codigo);
                if (it != null) it.Stock = Math.Max(0, it.Stock - l.Cantidad);
            }
            Guardar(items);
        }
    }
}