using Integrador_II_OrderSys_.Flujo_mesero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Integrador_II_OrderSys_
{
    public partial class Mesa : Form
    {
        private int numeroMesa;
        private string usuarioActivo;
        private MenuMesas menuPadre;
        private decimal total = 0;
        private List<string> pendientesCocina = new List<string>();
        private List<LineaFactura> lineas = new List<LineaFactura>();
        private string nombreCliente = "Consumidor final"; // luego lo cambiará el form del cliente

        private Dictionary<string, decimal> precios = new Dictionary<string, decimal>
        {

            { "Pizza de queso", 450.0m },
            { "Pizza hawaiana", 500.0m },
            { "Pizza de pepperoni", 400.0m },
            { "Chilaquiles", 350.0m },
            { "Tacos mexicanos", 250.0m },
        };

        public Mesa(int numero, string usuario, MenuMesas menu)
        {
            InitializeComponent();
            numeroMesa = numero;
            usuarioActivo = usuario;
            menuPadre = menu;

            this.Text = $"Mesa {numeroMesa}";
            txtTituloMesa.Text = $"Mesa {numeroMesa}";

            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string producto in precios.Keys)
            {
                cmbProductos.Items.Add(producto);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Elige un producto primero.");
                return;
            }

            string producto = (string)cmbProductos.SelectedItem;
            int cantidad = (int)nuDownCantidad.Value;
            decimal subtotal = precios[producto] * cantidad;

            lstComanda.Items.Add($"{cantidad} x {producto} = {subtotal:C}");

            total += subtotal;
            txtTotal.Text = $"Total: {total:C}";

            string hora = DateTime.Now.ToString("HH:mm");
            pendientesCocina.Add($"{numeroMesa}|{usuarioActivo}|{hora}|{producto}|{cantidad}|Pendiente");

            lineas.Add(new LineaFactura
            {
                Codigo = "P" + (cmbProductos.SelectedIndex + 1).ToString("00"),
                Descripcion = producto,
                Cantidad = cantidad,
                Precio = precios[producto]
            });
        }
        public void LimpiarComanda()
        {
            lstComanda.Items.Clear();
            lineas.Clear();
            total = 0;
            txtTotal.Text = $"Total: {total:C}";
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            menuPadre.Show();
            this.Close();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (lstComanda.Items.Count == 0)
            {
                MessageBox.Show("No hay productos en la comanda para facturar.");
                return;
            }

            new Facturación(this, numeroMesa, usuarioActivo, nombreCliente, lineas, total).Show();
            this.Hide();
        }

        private void lstComanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTituloMesa_Click(object sender, EventArgs e)
        {

        }

        private void btnSendCocina_Click(object sender, EventArgs e)
        {
            if (pendientesCocina.Count == 0)
            {
                MessageBox.Show("No hay productos nuevos para enviar a cocina.");
                return;
            }

            try
            {
                File.AppendAllLines(Archivos.RutaPedidos, pendientesCocina);

                MessageBox.Show($"Se enviaron {pendientesCocina.Count} producto(s) a cocina.");
                pendientesCocina.Clear();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tengo permiso para escribir el pedido.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error al enviar a cocina: {ex.Message}");
            }
        }

        private void pnlSelecProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerEstado_Click(object sender, EventArgs e)
        {
            var mios = Pedidos.Leer()
                .Where(p => p[0] == numeroMesa.ToString())
                .ToList();

            if (mios.Count == 0)
            {
                MessageBox.Show("Esta mesa no tiene pedidos enviados a cocina.");
                return;
            }

            string texto = string.Join("\n", mios.Select(p => $"{p[4]} x {p[3]}  -  {p[5]}"));
            MessageBox.Show(texto, $"Estado - Mesa {numeroMesa}");
        }
    }
}
