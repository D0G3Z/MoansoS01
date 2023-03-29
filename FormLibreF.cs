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

    public partial class FormLibreF : Form
    {
        SqlConnection conexionBD = new SqlConnection("server= localhost; database= LibreriaMoanso; integrated security= true");

        public FormLibreF()
        {
            InitializeComponent();
        }

        public bool check = false;

        public void ActualizarTabla()
        {
            string consulta = "select *from Libros";
            SqlDataAdapter adatador = new SqlDataAdapter(consulta, conexionBD);
            DataTable dt = new DataTable();
            adatador.Fill(dt);
            dgvLibros.DataSource = dt;
            dgvLibros.ClearSelection();
            dgvLibros.CurrentCell = null;
        }

        public void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtAutor.Text = "";
            txtCodigo.Text = "";
            if(chkSi.Checked)
                chkSi.Checked = false;
            else if(chkNo.Checked)
                chkNo.Checked = true;
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                conexionBD.Open();
                DataGridViewRow filaSelec = dgvLibros.SelectedRows[0];
                int id = Convert.ToInt32(filaSelec.Cells["Id"].Value);
                string consulta = "delete from Libros where Id = @id";
                SqlCommand comando = new SqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                ActualizarTabla();
                LimpiarCampos();
                conexionBD.Close();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtCodigo.Text != "" && txtAutor.Text != "" && (!chkSi.Checked || !chkNo.Checked))
            {
                conexionBD.Open();
                if (chkSi.Checked)
                    check = true;
                string consulta = "insert into Libros (Nombre,Autor,Codigo,Prestado) values (@nombre, @autor, @codigo, @prestado)";
                SqlCommand comando = new SqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@autor", txtAutor.Text);
                comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                comando.Parameters.AddWithValue("@prestado", check);
                comando.ExecuteNonQuery();
                MessageBox.Show("Agregado correctamente");
                LimpiarCampos();
                ActualizarTabla();
                conexionBD.Close();
            }
            else
                MessageBox.Show("Complete todos los campos antes de continuar");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvLibros.SelectedRows.Count > 0)
            {
                conexionBD.Open();
                if (chkSi.Checked)
                    check = true;
                DataGridViewRow filaSelec = dgvLibros.SelectedRows[0];
                int id = Convert.ToInt32(filaSelec.Cells["Id"].Value);
                string consulta = "update Libros set Nombre = @nombre, Autor = @autor, Codigo = @codigo, Prestado = @prestado where Id = @id";
                SqlCommand comando = new SqlCommand(consulta, conexionBD);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@autor", txtAutor.Text);
                comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                comando.Parameters.AddWithValue("@prestado", check);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                MessageBox.Show("Editado correctamente");
                LimpiarCampos();
                ActualizarTabla();
                conexionBD.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvLibros.SelectedCells[1].Value.ToString();
            txtAutor.Text = dgvLibros.SelectedCells[2].Value.ToString();
            txtCodigo.Text = dgvLibros.SelectedCells[3].Value.ToString();
            bool op = Convert.ToBoolean(dgvLibros.SelectedCells[4].Value);
            if (op == true)
                chkSi.Checked = true;
            else chkNo.Checked = true;
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNo.Checked == true)
                chkSi.Checked = false;
            else chkSi.Checked = true;
        }

        private void chkSi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSi.Checked == true)
                chkNo.Checked = false;
            else chkNo.Checked = true;
        }

        
    }
}
