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
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            MenuMesas menuMesas = new MenuMesas(usuarioActivo);
            MenuMesas pantallaMenuMesas = menuMesas;
            pantallaMenuMesas.Show();
            this.Hide();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (lstComanda.Items.Count == 0)
            {
                MessageBox.Show("No hay productos en la comanda para facturar.");
                return;
            }
            string factura = $"Factura - M3wq {numeroMesa}\n";
            factura += $"Atiende: {usuarioActivo}\n\n";
            factura += "------------------------\n";

            foreach (var item in lstComanda.Items)
            {
                factura += item + "\n";
            }
            factura += "------------------------\n";
            factura += $"Total: {total:C}\n";

            try
            { 
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas");
                Directory.CreateDirectory(carpeta);

                string ruta = Path.Combine(carpeta, "facturas.txt");

                string registro = $"[{DateTime.Now:dd/MM/yyyy HH:mm}]\n{factura}\n==========\n\n";
                File.AppendAllText(ruta, registro);

                MessageBox.Show("Factura generada y guardada correctamente.");

                lstComanda.Items.Clear();
                total = 0;
                txtTotal.Text = $"Total: {total:C}";
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"Error al generar la factura.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
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
    }
}
