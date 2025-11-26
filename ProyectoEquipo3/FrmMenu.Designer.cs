namespace ProyectoEquipo3
{
    partial class FrmMenu
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnNotifiaciones = new System.Windows.Forms.Button();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(192, 98);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(112, 97);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.Location = new System.Drawing.Point(310, 98);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(112, 97);
            this.btnProyectos.TabIndex = 0;
            this.btnProyectos.Text = "proyectos";
            this.btnProyectos.UseVisualStyleBackColor = true;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(428, 98);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(112, 97);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnNotifiaciones
            // 
            this.btnNotifiaciones.Location = new System.Drawing.Point(192, 201);
            this.btnNotifiaciones.Name = "btnNotifiaciones";
            this.btnNotifiaciones.Size = new System.Drawing.Size(112, 97);
            this.btnNotifiaciones.TabIndex = 0;
            this.btnNotifiaciones.Text = "notificaciones";
            this.btnNotifiaciones.UseVisualStyleBackColor = true;
            this.btnNotifiaciones.Click += new System.EventHandler(this.btnNotifiaciones_Click);
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Location = new System.Drawing.Point(310, 201);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(112, 97);
            this.btnPresupuesto.TabIndex = 0;
            this.btnPresupuesto.Text = "presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(428, 201);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(112, 97);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "gestion de usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 677);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.btnNotifiaciones);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProyectos);
            this.Controls.Add(this.btnInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnNotifiaciones;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnUsuarios;
    }
}