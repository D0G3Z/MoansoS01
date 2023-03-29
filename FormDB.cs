using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MoansoS01
{
    public partial class FormDB : Form
    {
        SqlConnection conexionBD = new SqlConnection("server= localhost; database= LibreriaMoanso; integrated security= true");
        public FormDB()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conexionBD.Open();
            string consulta = "select Usuario, Contrasena from Usuarios where usuario = '" + 
                txtUsuario.Text + "' and contrasena = '" + txtContra.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexionBD);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bienvenido nuevamente");
                txtUsuario.Text = string.Empty;
                txtContra.Text = string.Empty;
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Datos no encontrados en la base de datos");
                txtUsuario.Text = string.Empty;
                txtContra.Text = string.Empty;
                txtUsuario.Focus();
            }               
            conexionBD.Close();
        }
    }
}
