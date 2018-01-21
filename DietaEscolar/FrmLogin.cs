using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietaEscolar
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            txtUsuario.Focus();
            txtUsuario.ResetText();
            txtPassword.ResetText();
        }

        //Evento Tick del timer para actualizar la hora mostrada cada segundo
        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        //Evento Click del boton Ingresar
        //Hacemos una consulta al servidor con los datos del usuario y contraseña
        //introducidos por el usuario para comprobar que los datos sean correctos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese todos los datos antes de iniciar sesión en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(usersTableAdapter.Login(usuario, password));
                    LimpiarControles();

                    if (id != 0)
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        Hide();
                        frm.ShowDialog();
                        Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos\n\nIntente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.ResetText();
                        txtPassword.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Evento Click del boton Salir
        //Cerramos la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
