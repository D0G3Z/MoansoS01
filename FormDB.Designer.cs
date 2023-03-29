
namespace MoansoS01
{
    partial class FormDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSi = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPrestado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(765, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Libro: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(173, 57);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(215, 22);
            this.txtAutor.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(173, 96);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(215, 22);
            this.txtCodigo.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(507, 17);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ha sido prestado?: ";
            // 
            // chkSi
            // 
            this.chkSi.AutoSize = true;
            this.chkSi.Location = new System.Drawing.Point(173, 143);
            this.chkSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSi.Name = "chkSi";
            this.chkSi.Size = new System.Drawing.Size(41, 20);
            this.chkSi.TabIndex = 10;
            this.chkSi.Text = "SI";
            this.chkSi.UseVisualStyleBackColor = true;
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(229, 143);
            this.chkNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(49, 20);
            this.chkNo.TabIndex = 11;
            this.chkNo.Text = "NO";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(507, 54);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPrestado
            // 
            this.btnPrestado.Location = new System.Drawing.Point(507, 90);
            this.btnPrestado.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrestado.Name = "btnPrestado";
            this.btnPrestado.Size = new System.Drawing.Size(111, 28);
            this.btnPrestado.TabIndex = 13;
            this.btnPrestado.Text = "Quitar Prestado";
            this.btnPrestado.UseVisualStyleBackColor = true;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPrestado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkSi);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDB";
            this.Text = "FormDB";
            this.Load += new System.EventHandler(this.FormDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSi;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPrestado;
    }
}