
namespace MoansoS01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLibre = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1067, 48);
            this.panelBarra.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnLibre);
            this.panelMenu.Controls.Add(this.btnConexion);
            this.panelMenu.Controls.Add(this.btnCheck);
            this.panelMenu.Controls.Add(this.btnList);
            this.panelMenu.Controls.Add(this.btnCombo);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 48);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 506);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLibre
            // 
            this.btnLibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibre.FlatAppearance.BorderSize = 0;
            this.btnLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibre.Location = new System.Drawing.Point(0, 420);
            this.btnLibre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Size = new System.Drawing.Size(189, 84);
            this.btnLibre.TabIndex = 5;
            this.btnLibre.Text = "Libre";
            this.btnLibre.UseVisualStyleBackColor = true;
            this.btnLibre.Click += new System.EventHandler(this.btnLibre_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexion.Location = new System.Drawing.Point(0, 336);
            this.btnConexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(189, 84);
            this.btnConexion.TabIndex = 4;
            this.btnConexion.Text = "Conexion BD";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(0, 252);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(189, 84);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CheckBox";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnList
            // 
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Location = new System.Drawing.Point(0, 168);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(189, 84);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "ListBox";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCombo.FlatAppearance.BorderSize = 0;
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.Location = new System.Drawing.Point(0, 84);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(189, 84);
            this.btnCombo.TabIndex = 1;
            this.btnCombo.Text = "ComboBox";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(189, 84);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(189, 48);
            this.panelForms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(878, 506);
            this.panelForms.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Button btnLibre;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnInicio;
    }
}

