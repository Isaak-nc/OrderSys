using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Integrador_II_OrderSys_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string usuario = txtBoxUsuario.Text.Trim();
           string contraseña = txtBoxContraseña.Text;

            try
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                {
                    throw new ArgumentException("Debes llenar usuario y contraseña.");
                }

                string rol = Users.ValidarLogin(usuario, contraseña);

                if (rol == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return;
                }

                txtBoxContraseña.Clear();

                switch (rol)
                {
                    case "mesero":
                    {
                       MenuMesas menu = new MenuMesas(usuario);
                       menu.Show();
                       this.Hide();
                       break;
                    }
                    /*case "cocina":
                    {
                       Cocina pantallaCocina = new Cocina(usuario, this);
                       pantallaCocina.Show();
                       this.Hide();
                       break;
                        }*/
                    case "admin":
                    {
                       MessageBox.Show("La pantalla de admin está en construcción.");
                       break;
                    }
                    default:
                    {
                        MessageBox.Show($"Rol desconocido en usuarios.txt: {rol}");
                        break;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"No se pudo leer el archivo de usuarios: {ex.Message}");

            }
        }
    }
}
