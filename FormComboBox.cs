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
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {
            cmbTarea.Items.Add("Realizar un proyecto");
            cmbTarea.Items.Add("Ir al gimnasio");
            cmbTarea.Items.Add("Comprar un juego");

            cmbPrioridad.Items.Add("Baja");
            cmbPrioridad.Items.Add("Normal");
            cmbPrioridad.Items.Add("Alta");
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedIndex != -1 && cmbPrioridad.SelectedIndex != -1)
            {
                MessageBox.Show("Se estableció correctamente");
                cmbPrioridad.Text = "Escoja una ocpión";
                cmbTarea.Text = "Escoja una ocpión";
            }               
            else
                MessageBox.Show("Escoja una opcion en ambos casos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTarea.Text != "")
            {
                cmbTarea.Items.Add(txtTarea.Text);
                MessageBox.Show("Se agregó correctamente");
                lblTarea.Visible = false;
                txtTarea.Visible = false;
                btnAgregar.Visible = false;
            }
                
            else
            {
                MessageBox.Show("El campo no puede estar vacio");
                txtTarea.Focus();
            }
                
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            lblTarea.Visible = true;
            txtTarea.Visible = true;
            btnAgregar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cmbTarea.Items.Remove(cmbTarea.SelectedItem);
            cmbTarea.Text = "Escoja una ocpión";
        }
    }
}
