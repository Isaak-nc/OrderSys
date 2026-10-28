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

namespace Integrador_II_OrderSys_.Módulo_de_Administración_o_Módulo_2.Flujo_Admin
{
    public partial class Admin : Form
    {
        private Form loginPadre;

        public Admin(string usuario, Form login)
        {
            InitializeComponent();
            loginPadre = login;
            this.Text = $"Administración - {usuario}";
            this.FormClosed += (s, e) => loginPadre.Show();

            btnSalir.Click += btnSalir_Click;
            btnInvAgregar.Click += btnInvAgregar_Click;
            btnInvModificar.Click += btnInvModificar_Click;
            btnInvEliminar.Click += btnInvEliminar_Click;
            btnInvLimpiar.Click += btnInvLimpiar_Click;
            btnVentasFiltrar.Click += btnVentasFiltrar_Click;
            btnVentasDetalle.Click += btnVentasDetalle_Click;
            btnVentasAnular.Click += btnVentasAnular_Click;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            btnGuardarReporte.Click += btnGuardarReporte_Click;

            foreach (ListView lv in new[] { lvInventario, lvVentas })
            {
                lv.View = View.Details;
                lv.FullRowSelect = true;
                lv.GridLines = true;
            }

            DateTime inicioMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDesde.Value = dtpRepDesde.Value = inicioMes;
            dtpHasta.Value = dtpRepHasta.Value = DateTime.Today;

            cmbRepMesero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepMesero.Items.Add("(Todos)");
            Users.CrearArchivoSiNoExiste();
            foreach (string linea in File.ReadAllLines(Archivos.RutaUsuarios))
            {
                string[] p = linea.Split('|');
                if (p.Length == 3 && p[2].Trim().ToLower() == "mesero") cmbRepMesero.Items.Add(p[0].Trim());
            }
            cmbRepMesero.SelectedIndex = 0;

            CargarInventario();
            CargarVentas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============ INVENTARIO ============

        private void CargarInventario()
        {
            lvInventario.Items.Clear();
            try
            {
                foreach (ItemInventario i in Inventario.Leer())
                {
                    var it = new ListViewItem(new[] { i.Codigo, i.Descripcion, i.Precio.ToString("C"), i.Stock.ToString() });
                    it.Tag = i;
                    if (i.Stock <= 5) it.ForeColor = Color.Red; // stock bajo
                    lvInventario.Items.Add(it);
                }
            }
            catch (IOException ex) { MessageBox.Show($"Error al leer el inventario: {ex.Message}"); }
        }

        private bool GuardarInventario(List<ItemInventario> lista)
        {
            try { Inventario.Guardar(lista); return true; }
            catch (IOException ex) { MessageBox.Show($"Error al guardar el inventario: {ex.Message}"); return false; }
            catch (UnauthorizedAccessException) { MessageBox.Show("No tengo permiso para escribir el inventario."); return false; }
        }

        private bool LeerFormularioInv(out ItemInventario item)
        {
            item = null;
            string cod = txtInvCodigo.Text.Trim();
            string desc = txtInvDescripcion.Text.Trim();
            decimal precio; int stock;

            if (cod == "" || desc == "" || cod.Contains("|") || desc.Contains("|") || desc.Contains(";") || desc.Contains("="))
            {
                MessageBox.Show("Código y descripción son obligatorios y no pueden contener los símbolos | ; =");
                return false;
            }
            if (!decimal.TryParse(txtInvPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.");
                return false;
            }
            if (!int.TryParse(txtInvStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Stock inválido.");
                return false;
            }

            item = new ItemInventario { Codigo = cod, Descripcion = desc, Precio = precio, Stock = stock };
            return true;
        }

        private void LimpiarFormularioInv()
        {
            txtInvCodigo.Clear(); txtInvDescripcion.Clear(); txtInvPrecio.Clear(); txtInvStock.Clear();
            txtInvCodigo.ReadOnly = false;
            lvInventario.SelectedItems.Clear();
        }

        private void lvInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInventario.SelectedItems.Count == 0) return;
            var i = (ItemInventario)lvInventario.SelectedItems[0].Tag;
            txtInvCodigo.Text = i.Codigo;
            txtInvDescripcion.Text = i.Descripcion;
            txtInvPrecio.Text = i.Precio.ToString("F2");
            txtInvStock.Text = i.Stock.ToString();
            txtInvCodigo.ReadOnly = true; // el código no se cambia al modificar
        }

        private void btnInvAgregar_Click(object sender, EventArgs e)
        {
            ItemInventario nuevo;
            if (!LeerFormularioInv(out nuevo)) return;

            var lista = Inventario.Leer();
            if (lista.Any(i => i.Codigo.Equals(nuevo.Codigo, StringComparison.OrdinalIgnoreCase) ||
                               i.Descripcion.Equals(nuevo.Descripcion, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un producto con ese código o descripción.");
                return;
            }

            lista.Add(nuevo);
            if (GuardarInventario(lista)) { CargarInventario(); LimpiarFormularioInv(); }
        }

        private void btnInvModificar_Click(object sender, EventArgs e)
        {
            ItemInventario cambios;
            if (!LeerFormularioInv(out cambios)) return;

            var lista = Inventario.Leer();
            var actual = lista.FirstOrDefault(i => i.Codigo == cambios.Codigo);
            if (actual == null)
            {
                MessageBox.Show("Selecciona un producto de la lista para modificarlo.");
                return;
            }
            if (lista.Any(i => i.Codigo != actual.Codigo &&
                               i.Descripcion.Equals(cambios.Descripcion, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe otro producto con esa descripción.");
                return;
            }

            actual.Descripcion = cambios.Descripcion;
            actual.Precio = cambios.Precio;
            actual.Stock = cambios.Stock;
            if (GuardarInventario(lista)) { CargarInventario(); LimpiarFormularioInv(); }
        }

        private void btnInvEliminar_Click(object sender, EventArgs e)
        {
            if (lvInventario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }
            var sel = (ItemInventario)lvInventario.SelectedItems[0].Tag;
            if (MessageBox.Show($"¿Eliminar \"{sel.Descripcion}\"?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var lista = Inventario.Leer();
            lista.RemoveAll(i => i.Codigo == sel.Codigo);
            if (GuardarInventario(lista)) { CargarInventario(); LimpiarFormularioInv(); }
        }

        private void btnInvLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioInv();
        }

        // ============ VENTAS ============

        private void CargarVentas()
        {
            lvVentas.Items.Clear();
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1);
            decimal suma = 0;

            try
            {
                foreach (Factura f in Facturas.Leer().Where(x => x.Fecha >= desde && x.Fecha < hasta).OrderByDescending(x => x.Fecha))
                {
                    var it = new ListViewItem(new[]
                    {
                        f.Codigo, f.Fecha.ToString("dd/MM/yyyy HH:mm"), f.Mesa, f.Cliente,
                        f.Atiende, f.Pago, f.Total.ToString("C"), f.Estado
                    });
                    it.Tag = f;
                    if (f.Estado == "Anulada") it.ForeColor = Color.Gray;
                    else suma += f.Total;
                    lvVentas.Items.Add(it);
                }
            }
            catch (IOException ex) { MessageBox.Show($"Error al leer las facturas: {ex.Message}"); }

            lblVentasTotal.Text = $"Total vendido: {suma:C}";
        }

        private void btnVentasFiltrar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnVentasDetalle_Click(object sender, EventArgs e)
        {
            if (lvVentas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una factura.");
                return;
            }
            var f = (Factura)lvVentas.SelectedItems[0].Tag;
            MessageBox.Show(f.Detalle.Replace(";", "\n"), $"Factura {f.Codigo} - {f.Cliente}");
        }

        private void btnVentasAnular_Click(object sender, EventArgs e)
        {
            if (lvVentas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una factura.");
                return;
            }
            var sel = (Factura)lvVentas.SelectedItems[0].Tag;
            if (sel.Estado == "Anulada")
            {
                MessageBox.Show("Esa factura ya está anulada.");
                return;
            }
            if (MessageBox.Show($"¿Anular la factura {sel.Codigo}?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                var todas = Facturas.Leer();
                todas.First(x => x.Codigo == sel.Codigo).Estado = "Anulada";
                Facturas.Guardar(todas);
                CargarVentas();
            }
            catch (IOException ex) { MessageBox.Show($"Error al anular: {ex.Message}"); }
        }

        // ============ REPORTES ============

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpRepDesde.Value.Date;
            DateTime hasta = dtpRepHasta.Value.Date.AddDays(1);
            string mesero = cmbRepMesero.SelectedItem.ToString();
            bool general = mesero == "(Todos)";

            try
            {
                var lista = Facturas.Leer()
                    .Where(f => f.Fecha >= desde && f.Fecha < hasta &&
                                (general || f.Atiende.Equals(mesero, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
                var pagadas = lista.Where(f => f.Estado == "Pagada").ToList();

                var sb = new StringBuilder();
                sb.AppendLine(general ? "REPORTE GENERAL" : $"REPORTE INDIVIDUAL - {mesero}");
                sb.AppendLine($"Periodo: {desde:dd/MM/yyyy} al {hasta.AddDays(-1):dd/MM/yyyy}");
                sb.AppendLine(new string('-', 40));
                sb.AppendLine($"Facturas pagadas:  {pagadas.Count}");
                sb.AppendLine($"Facturas anuladas: {lista.Count - pagadas.Count}");
                sb.AppendLine($"Total vendido:     {pagadas.Sum(f => f.Total):C}");
                if (pagadas.Count > 0)
                    sb.AppendLine($"Promedio por factura: {pagadas.Average(f => f.Total):C}");

                sb.AppendLine().AppendLine("Por formato de pago:");
                foreach (var g in pagadas.GroupBy(f => f.Pago))
                    sb.AppendLine($"  {g.Key}: {g.Count()} factura(s) - {g.Sum(f => f.Total):C}");

                var productos = new Dictionary<string, int>();
                foreach (Factura f in pagadas)
                {
                    foreach (string parte in f.Detalle.Split(';'))
                    {
                        int ix = parte.IndexOf('x');
                        int ie = parte.LastIndexOf('=');
                        int cant;
                        if (ix < 1 || ie < ix || !int.TryParse(parte.Substring(0, ix), out cant)) continue;
                        string desc = parte.Substring(ix + 1, ie - ix - 1);
                        productos[desc] = (productos.ContainsKey(desc) ? productos[desc] : 0) + cant;
                    }
                }
                sb.AppendLine().AppendLine("Productos vendidos:");
                foreach (var kv in productos.OrderByDescending(k => k.Value))
                    sb.AppendLine($"  {kv.Value} x {kv.Key}");

                if (general)
                {
                    var bajos = Inventario.Leer().Where(i => i.Stock <= 5).ToList();
                    sb.AppendLine().AppendLine("Stock bajo (5 o menos):");
                    if (bajos.Count == 0) sb.AppendLine("  Ninguno");
                    foreach (ItemInventario i in bajos) sb.AppendLine($"  {i.Descripcion}: {i.Stock}");
                }

                txtReporte.Text = sb.ToString();
            }
            catch (IOException ex) { MessageBox.Show($"Error al generar el reporte: {ex.Message}"); }
        }

        private void btnGuardarReporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReporte.Text))
            {
                MessageBox.Show("Genera un reporte primero.");
                return;
            }
            try
            {
                string carpeta = Path.Combine(Archivos.CarpetaDatos, "Reportes");
                Directory.CreateDirectory(carpeta);
                string ruta = Path.Combine(carpeta, $"reporte_{DateTime.Now:yyyyMMdd_HHmm}.txt");
                File.WriteAllText(ruta, txtReporte.Text);
                MessageBox.Show($"Reporte guardado en:\n{ruta}");
            }
            catch (IOException ex) { MessageBox.Show($"Error al guardar: {ex.Message}"); }
            catch (UnauthorizedAccessException) { MessageBox.Show("No tengo permiso para guardar el reporte."); }
        }

        // Handlers vacíos que el diseñador tiene enlazados (no borrar sin quitarlos de Admin.Designer.cs)
        private void Admin_Load(object sender, EventArgs e) { }
        private void Inventario_Click(object sender, EventArgs e) { }
        private void cmbRepMesero_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtVentasTotal_Click(object sender, EventArgs e) { }
    }
}