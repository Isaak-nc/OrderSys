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

namespace Integrador_II_OrderSys_.Módulo_de_Atención_al_Cliente_o_Módulo_1.Flujo_cocina
{
    public partial class Cocina : Form
    {
        private string usuarioActivo;
        private Form loginPadre;

        public Cocina(string usuario, Form login)
        {
            InitializeComponent();
            usuarioActivo = usuario;
            loginPadre = login;
            this.Text = $"Cocina - {usuarioActivo}";
            CargarPedidos();

            this.FormClosed += (s, e) => loginPadre.Show();
        }

        private void CargarPedidos()
        {
            lvPedidos.Items.Clear();
            foreach (string[] p in Pedidos.Leer())
            {
                if (p[5] == "Listo") continue; // ocultar los terminados
                var item = new ListViewItem(new[] { p[0], p[2], p[3], p[4], p[5] });
                lvPedidos.Items.Add(item);
            }
        }

        private void CambiarEstado(string nuevoEstado)
        {
            if (lvPedidos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido.");
                return;
            }

            var sel = lvPedidos.SelectedItems[0];
            var todos = Pedidos.Leer();

            // Busca la primera coincidencia no terminada (mesa, hora, producto)
            var objetivo = todos.FirstOrDefault(p =>
                p[0] == sel.SubItems[0].Text &&
                p[2] == sel.SubItems[1].Text &&
                p[3] == sel.SubItems[2].Text &&
                p[5] != "Listo");

            if (objetivo != null)
            {
                objetivo[5] = nuevoEstado;
                try { Pedidos.Guardar(todos); }
                catch (IOException ex) { MessageBox.Show($"Error: {ex.Message}"); }
            }
            CargarPedidos();
        }
        private void btnPreparar_Click(object sender, EventArgs e) => CambiarEstado("En preparación");
        private void btnListo_Click_1(object sender, EventArgs e) => CambiarEstado("Listo");
        private void btnActualizar_Click_1(object sender, EventArgs e) => CargarPedidos();
        private void btnSalir_Click_1(object sender, EventArgs e) => this.Close();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            loginPadre.Show();
            this.Close();
        }

        private void lvPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }

}
