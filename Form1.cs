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
    public partial class Form1 : Form
    {
        private Form frmactual;
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form actual)
        {
            if (frmactual != null)
                frmactual.Close();
            frmactual = actual;

            actual.TopLevel = false;
            actual.FormBorderStyle = FormBorderStyle.None;
            actual.Dock = DockStyle.Fill;
            panelForms.Controls.Add(actual);
            actual.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (frmactual != null)
                frmactual.Close();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormComboBox());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormLB());
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormCheckBox());
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormDB());
        }

        private void btnLibre_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormLibreF());
        }
    }
}
