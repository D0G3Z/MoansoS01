
namespace MoansoS01
{
    partial class FormCheckBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkProcesadores = new System.Windows.Forms.CheckBox();
            this.govProductos = new System.Windows.Forms.GroupBox();
            this.chkProc3 = new System.Windows.Forms.CheckBox();
            this.chkProc2 = new System.Windows.Forms.CheckBox();
            this.chkProc1 = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.govProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkProcesadores);
            this.groupBox1.Location = new System.Drawing.Point(35, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(118, 39);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // chkProcesadores
            // 
            this.chkProcesadores.AutoSize = true;
            this.chkProcesadores.Location = new System.Drawing.Point(11, 17);
            this.chkProcesadores.Margin = new System.Windows.Forms.Padding(2);
            this.chkProcesadores.Name = "chkProcesadores";
            this.chkProcesadores.Size = new System.Drawing.Size(91, 17);
            this.chkProcesadores.TabIndex = 0;
            this.chkProcesadores.Text = "Procesadores";
            this.chkProcesadores.UseVisualStyleBackColor = true;
            this.chkProcesadores.CheckedChanged += new System.EventHandler(this.chkProcesadores_CheckedChanged);
            // 
            // govProductos
            // 
            this.govProductos.Controls.Add(this.chkProc3);
            this.govProductos.Controls.Add(this.chkProc2);
            this.govProductos.Controls.Add(this.chkProc1);
            this.govProductos.Location = new System.Drawing.Point(173, 24);
            this.govProductos.Margin = new System.Windows.Forms.Padding(2);
            this.govProductos.Name = "govProductos";
            this.govProductos.Padding = new System.Windows.Forms.Padding(2);
            this.govProductos.Size = new System.Drawing.Size(145, 85);
            this.govProductos.TabIndex = 1;
            this.govProductos.TabStop = false;
            this.govProductos.Text = "Productos";
            this.govProductos.Visible = false;
            // 
            // chkProc3
            // 
            this.chkProc3.AutoSize = true;
            this.chkProc3.Location = new System.Drawing.Point(11, 59);
            this.chkProc3.Margin = new System.Windows.Forms.Padding(2);
            this.chkProc3.Name = "chkProc3";
            this.chkProc3.Size = new System.Drawing.Size(125, 17);
            this.chkProc3.TabIndex = 5;
            this.chkProc3.Text = "Intel Core i5-12600K ";
            this.chkProc3.UseVisualStyleBackColor = true;
            this.chkProc3.Visible = false;
            this.chkProc3.CheckedChanged += new System.EventHandler(this.chkProc3_CheckedChanged);
            // 
            // chkProc2
            // 
            this.chkProc2.AutoSize = true;
            this.chkProc2.Location = new System.Drawing.Point(11, 38);
            this.chkProc2.Margin = new System.Windows.Forms.Padding(2);
            this.chkProc2.Name = "chkProc2";
            this.chkProc2.Size = new System.Drawing.Size(126, 17);
            this.chkProc2.TabIndex = 4;
            this.chkProc2.Text = "Amd Ryzen 9 3950X ";
            this.chkProc2.UseVisualStyleBackColor = true;
            this.chkProc2.Visible = false;
            this.chkProc2.CheckedChanged += new System.EventHandler(this.chkProc2_CheckedChanged);
            // 
            // chkProc1
            // 
            this.chkProc1.AutoSize = true;
            this.chkProc1.Location = new System.Drawing.Point(11, 17);
            this.chkProc1.Margin = new System.Windows.Forms.Padding(2);
            this.chkProc1.Name = "chkProc1";
            this.chkProc1.Size = new System.Drawing.Size(122, 17);
            this.chkProc1.TabIndex = 3;
            this.chkProc1.Text = "Intel Core i7-12700K";
            this.chkProc1.UseVisualStyleBackColor = true;
            this.chkProc1.Visible = false;
            this.chkProc1.CheckedChanged += new System.EventHandler(this.chkProc1_CheckedChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(92, 124);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Precio: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalcular.IconColor = System.Drawing.Color.Black;
            this.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcular.IconSize = 20;
            this.btnCalcular.Location = new System.Drawing.Point(221, 116);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.govProductos);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCheckBox";
            this.Text = "FormCheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.govProductos.ResumeLayout(false);
            this.govProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkProcesadores;
        private System.Windows.Forms.GroupBox govProductos;
        private System.Windows.Forms.CheckBox chkProc3;
        private System.Windows.Forms.CheckBox chkProc2;
        private System.Windows.Forms.CheckBox chkProc1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCalcular;
    }
}