using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_II_OrderSys_.Flujo_mesero
{
    public partial class Facturación : Form
    {
        private Mesa mesaPadre;
        private int numeroMesa;
        private string usuarioActivo;
        private string cliente;
        private List<LineaFactura> lineas;
        private decimal total;
        private string fecha;

        // Constructor principal que recibe los datos
        public Facturación(Mesa mesa, int numero, string usuario, string nombreCliente,
                           List<LineaFactura> lineasComanda, decimal totalComanda)
        {
            InitializeComponent();
            mesaPadre = mesa;
            numeroMesa = numero;
            usuarioActivo = usuario;
            cliente = nombreCliente;
            lineas = lineasComanda;
            total = totalComanda;

            this.Text = $"Facturación - Mesa {numeroMesa}";
            this.FormClosed += (s, e) => mesaPadre.Show();

            fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtCliente.Text = cliente;
            txtFecha.Text = fecha;
            txtCodigoFactura.Text = GenerarCodigo();
            txtEstadoFactura.Text = "Pendiente de pago";
            txtTotal.Text = $"Total: {total:C}";

            cmbFormatoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbFormatoPago.Items.Count == 0)
            {
                cmbFormatoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            }

            lvFactura.View = View.Details;
            lvFactura.FullRowSelect = true;
            foreach (LineaFactura l in lineas)
            {
                lvFactura.Items.Add(new ListViewItem(new[]
                {
                    l.Codigo, l.Descripcion, l.Cantidad.ToString(), l.Precio.ToString("C")
                }));
            }
        }

        // Constructor vacío por si el diseñador de WinForms lo llega a necesitar
        public Facturación()
        {
            InitializeComponent();
        }

        private string GenerarCodigo()
        {
            int consecutivo = 1;
            try
            {
                if (File.Exists(Archivos.RutaFacturas))
                {
                    consecutivo = File.ReadAllLines(Archivos.RutaFacturas).Length + 1;
                }
            }
            catch (IOException) { }

            return $"F-{consecutivo:0000}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbFormatoPago.SelectedItem == null)
            {
                MessageBox.Show("Elige un formato de pago.");
                return;
            }

            try
            {
                string detalle = string.Join(";", lineas.Select(l => $"{l.Cantidad}x{l.Descripcion}={l.Subtotal.ToString("F2", CultureInfo.InvariantCulture)}"));
                string registro = string.Join("|",
                    txtCodigoFactura.Text, fecha, numeroMesa, cliente, usuarioActivo,
                    cmbFormatoPago.SelectedItem, total.ToString("F2", CultureInfo.InvariantCulture),
                    "Pagada", detalle);

                File.AppendAllText(Archivos.RutaFacturas, registro + Environment.NewLine);

                var restantes = Pedidos.Leer()
                    .Where(p => !(p[0] == numeroMesa.ToString() && p[5] == "Listo"))
                    .ToList();
                Pedidos.Guardar(restantes);

                txtEstadoFactura.Text = "Pagada";
                MessageBox.Show("Factura generada y guardada correctamente.");

                mesaPadre.LimpiarComanda(); ;
                this.Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tengo permiso para guardar la factura.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}");
            }
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Evento de pintura del panel (vacío)
        }
    }
}