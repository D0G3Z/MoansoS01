using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoansoS01
{
    public partial class FormLB : Form
    {
        public FormLB()
        {
            InitializeComponent();
        }

        private void FormLB_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Incompleto");
            cmbEstado.Items.Add("Completado");
            lstTareas.Items.Add("Sacar a pasear al perro" + " , " + "Completado");
            lstTareas.Items.Add("Ir a clases" + " , " + "Incompleto");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTarea.Text != "" && cmbEstado.SelectedIndex != -1)
            {
                lstTareas.Items.Add(txtTarea.Text + " , " + cmbEstado.SelectedItem.ToString());
                MessageBox.Show("Ingresado Correctamente");
                txtTarea.Clear();
                cmbEstado.SelectedIndex= -1;
            }              
            else
                MessageBox.Show("Todos los campos deben ser completados");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lstTareas.SelectedIndex != -1)
            {
                lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
                MessageBox.Show("Eliminado satisfactoriamente");
            }
            else MessageBox.Show("Seleccione una tarea primero");
        }

    }
}
