using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_II_OrderSys_
{
    public partial class MenuMesas : Form
    {
        private string UsuarioActivo;

        public MenuMesas(string usuario)
        {
            InitializeComponent();
            UsuarioActivo = usuario;
            this.Text = $"Menú - Usuario: {UsuarioActivo}";
        }

        private void Menu3_Load(object sender, EventArgs e)
        {

        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Seguro que quiere salir, " + UsuarioActivo + "?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Login pantallaForm1 = new Login();
                pantallaForm1.Show();
                this.Close(); 
            }
            else
            {
              
            }
        }

        private void btnMesaClick(object sender, EventArgs e)
        {
            Button btnPresionado = (Button)sender;
            int numeroMesa = int.Parse(btnPresionado.Tag.ToString());

            Mesa PantallaMesa = new Mesa(numeroMesa, UsuarioActivo, this);
            PantallaMesa.Show();
            this.Hide();
        }
    }
}
