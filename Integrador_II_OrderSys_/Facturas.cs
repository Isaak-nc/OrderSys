using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Integrador_II_OrderSys_
{
    internal class Factura
    {
        public string Codigo, Mesa, Cliente, Atiende, Pago, Estado, Detalle;
        public DateTime Fecha;
        public decimal Total;
    }

    internal static class Facturas
    {
        private const string FormatoFecha = "dd/MM/yyyy HH:mm";

        public static List<Factura> Leer()
        {
            var lista = new List<Factura>();
            if (!File.Exists(Archivos.RutaFacturas)) return lista;

            foreach (string linea in File.ReadAllLines(Archivos.RutaFacturas))
            {
                string[] p = linea.Split('|');
                DateTime fecha; decimal total;
                if (p.Length != 9) continue;
                if (!DateTime.TryParseExact(p[1], FormatoFecha, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha)) continue;
                if (!decimal.TryParse(p[6], NumberStyles.Number, CultureInfo.InvariantCulture, out total)) continue;

                lista.Add(new Factura
                {
                    Codigo = p[0],
                    Fecha = fecha,
                    Mesa = p[2],
                    Cliente = p[3],
                    Atiende = p[4],
                    Pago = p[5],
                    Total = total,
                    Estado = p[7],
                    Detalle = p[8]
                });
            }
            return lista;
        }

        public static void Guardar(List<Factura> facturas)
        {
            File.WriteAllLines(Archivos.RutaFacturas, facturas.Select(f => string.Join("|",
                f.Codigo, f.Fecha.ToString(FormatoFecha, CultureInfo.InvariantCulture), f.Mesa, f.Cliente,
                f.Atiende, f.Pago, f.Total.ToString("F2", CultureInfo.InvariantCulture), f.Estado, f.Detalle)));
        }
    }
}