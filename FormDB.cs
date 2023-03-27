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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexionBD.Open();
            MessageBox.Show("La conexion a DB: " + conexionBD.Database + " ha sido exitosa");
            conexionBD.Close();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            string consulta = "select *from Libros";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBD);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
