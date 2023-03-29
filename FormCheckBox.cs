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
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        #region Precios
        public int proc1 = 1968;
        public int proc2 = 3581;
        public int proc3 = 1400;
        #endregion
        private void chkProcesadores_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcesadores.Checked)
            {
                govProductos.Visible = true;
                chkProc1.Visible = true;
                chkProc2.Visible = true;
                chkProc3.Visible = true;
            }
            else
            {
                govProductos.Visible = false;
                chkProc1.Visible = false;
                chkProc2.Visible = false;
                chkProc3.Visible = false;
                txtPrecio.Text = string.Empty;
            }    
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (chkProcesadores.Checked || chkProc1.Checked || chkProc2.Checked || chkProc3.Checked)
            {
                if (chkProc1.Checked)
                    total += proc1;
                if (chkProc2.Checked)
                    total += proc2;
                if (chkProc3.Checked)
                    total += proc3;

                MessageBox.Show("El total es: S/." + total.ToString());
                chkProcesadores.Checked = false;
                if (chkProc1.Checked)
                    chkProc1.Checked = false;
                if (chkProc2.Checked)
                    chkProc2.Checked = false;
                if (chkProc3.Checked)
                    chkProc3.Checked = false;
                txtPrecio.Text = string.Empty;
            }
            else MessageBox.Show("Escoja una opción");
        }

        private void chkProc1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkProc1.Checked)
            {
                txtPrecio.Text = proc1.ToString();
            }
            else txtPrecio.Text = string.Empty;
        }

        private void chkProc2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProc2.Checked)
            {
                txtPrecio.Text = proc2.ToString();
            }
            else txtPrecio.Text = string.Empty;
        }

        private void chkProc3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProc3.Checked)
            {
                txtPrecio.Text = proc3.ToString();
            }
            else txtPrecio.Text = string.Empty;
        }

    }
}
