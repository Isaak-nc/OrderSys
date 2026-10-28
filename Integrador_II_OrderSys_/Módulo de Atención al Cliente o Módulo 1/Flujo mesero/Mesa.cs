using Integrador_II_OrderSys_.Flujo_mesero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private Dictionary<string, ItemInventario> catalogo;

        public Mesa(int numero, string usuario, MenuMesas menu)
        {
            InitializeComponent();
            numeroMesa = numero;
            usuarioActivo = usuario;
            menuPadre = menu;

            this.Text = $"Mesa {numeroMesa}";
            txtTituloMesa.Text = $"Mesa {numeroMesa}";

            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            catalogo = Inventario.Leer().ToDictionary(i => i.Descripcion);
            foreach (string desc in catalogo.Keys) cmbProductos.Items.Add(desc);
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
            ItemInventario item = catalogo[producto];

            int yaEnComanda = lineas.Where(l => l.Codigo == item.Codigo).Sum(l => l.Cantidad);
            if (cantidad + yaEnComanda > item.Stock)
            {
                MessageBox.Show($"Stock insuficiente. Disponibles: {item.Stock - yaEnComanda}.");
                return;
            }

            decimal subtotal = item.Precio * cantidad;
            lineas.Add(new LineaFactura { Codigo = item.Codigo, Descripcion = item.Descripcion, Cantidad = cantidad, Precio = item.Precio });

            total += subtotal;
            lstComanda.Items.Add($"{cantidad} x {item.Descripcion}  -  {subtotal:C}");
            txtTotal.Text = $"Total: {total:C}";

            // mesa|usuario|hora|producto|cantidad|estado
            pendientesCocina.Add(string.Join("|", numeroMesa, usuarioActivo,
                DateTime.Now.ToString("HH:mm:ss"), item.Descripcion, cantidad, "Pendiente"));

            nuDownCantidad.Value = 1;
        }
        public void LimpiarComanda()
        {
            lstComanda.Items.Clear();
            pendientesCocina.Clear();
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
