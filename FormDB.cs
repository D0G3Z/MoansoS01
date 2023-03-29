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

namespace MoansoS01{

    public partial class FormDB : Form
    {
        SqlConnection conexionBD = new SqlConnection("server= localhost; database= LibreriaMoanso; integrated security= true");

        private void ActualizarTabla()
        {
            conexionBD.Open();
            string consulta = "select *from Libros";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionBD);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexionBD.Close();
        }

        public FormDB()
        {
            InitializeComponent();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            ActualizarTabla();        
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexionBD.Open();
            DataGridViewRow fila = dataGridView1.CurrentRow.Cells["Id"];
            int id = Convert.ToInt32(fila.Cells["Id"].Value);
            string consulta = "delete *from Libros where Id = @Id";
            SqlCommand comando = new SqlCommand(consulta,conexionBD);
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();

            dataGridView1.Rows.Remove(fila);
            conexionBD.Close();
        }
    }
}
