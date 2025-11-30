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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnInventario = new RoundedButton();
            this.BtnProyectos = new RoundedButton();
            this.BtnProveedores = new RoundedButton();
            this.BtnNotificaciones = new RoundedButton();
            this.BtnPresupuestos = new RoundedButton();
            this.BtnUsuarios = new RoundedButton();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.BtnMin);
            this.panel2.Controls.Add(this.BtnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 54);
            this.panel2.TabIndex = 26;
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(132)))));
            this.BtnMin.BackgroundImage = global::ProyectoEquipo3.Properties.Resources.icons8_minimizar_50;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.Location = new System.Drawing.Point(1164, 10);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(35, 35);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnCerrar.BackgroundImage = global::ProyectoEquipo3.Properties.Resources.icons8_x_48;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Location = new System.Drawing.Point(1207, 10);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(35, 35);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnInventario.BorderColor = System.Drawing.Color.Transparent;
            this.BtnInventario.BorderRadius = 8;
            this.BtnInventario.BorderSize = 0;
            this.BtnInventario.ButtonImage = global::ProyectoEquipo3.Properties.Resources.icons8_cajas_50;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnInventario.HoverColor = System.Drawing.Color.Silver;
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInventario.ImagePadding = 40;
            this.BtnInventario.Location = new System.Drawing.Point(277, 130);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(10);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.BtnInventario.Size = new System.Drawing.Size(220, 220);
            this.BtnInventario.TabIndex = 27;
            this.BtnInventario.Text = "Gestión de\r\nInventario";
            this.BtnInventario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // BtnProyectos
            // 
            this.BtnProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnProyectos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnProyectos.BorderColor = System.Drawing.Color.Transparent;
            this.BtnProyectos.BorderRadius = 8;
            this.BtnProyectos.BorderSize = 0;
            this.BtnProyectos.ButtonImage = global::ProyectoEquipo3.Properties.Resources.icons8_martillo_50;
            this.BtnProyectos.FlatAppearance.BorderSize = 0;
            this.BtnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProyectos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnProyectos.HoverColor = System.Drawing.Color.Silver;
            this.BtnProyectos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProyectos.ImagePadding = 40;
            this.BtnProyectos.Location = new System.Drawing.Point(517, 130);
            this.BtnProyectos.Margin = new System.Windows.Forms.Padding(10);
            this.BtnProyectos.Name = "BtnProyectos";
            this.BtnProyectos.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.BtnProyectos.Size = new System.Drawing.Size(220, 220);
            this.BtnProyectos.TabIndex = 27;
            this.BtnProyectos.Text = "Proyectos\r\npendientes";
            this.BtnProyectos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnProyectos.UseVisualStyleBackColor = false;
            this.BtnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnProveedores.BorderColor = System.Drawing.Color.Transparent;
            this.BtnProveedores.BorderRadius = 8;
            this.BtnProveedores.BorderSize = 0;
            this.BtnProveedores.ButtonImage = global::ProyectoEquipo3.Properties.Resources.icons8_proveedor_50;
            this.BtnProveedores.FlatAppearance.BorderSize = 0;
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnProveedores.HoverColor = System.Drawing.Color.Silver;
            this.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProveedores.ImagePadding = 40;
            this.BtnProveedores.Location = new System.Drawing.Point(757, 130);
            this.BtnProveedores.Margin = new System.Windows.Forms.Padding(10);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.BtnProveedores.Size = new System.Drawing.Size(220, 220);
            this.BtnProveedores.TabIndex = 27;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // BtnNotificaciones
            // 
            this.BtnNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnNotificaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnNotificaciones.BorderColor = System.Drawing.Color.Transparent;
            this.BtnNotificaciones.BorderRadius = 8;
            this.BtnNotificaciones.BorderSize = 0;
            this.BtnNotificaciones.ButtonImage = global::ProyectoEquipo3.Properties.Resources.icons8_alarma_50;
            this.BtnNotificaciones.FlatAppearance.BorderSize = 0;
            this.BtnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotificaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnNotificaciones.HoverColor = System.Drawing.Color.Silver;
            this.BtnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNotificaciones.ImagePadding = 40;
            this.BtnNotificaciones.Location = new System.Drawing.Point(277, 377);
            this.BtnNotificaciones.Margin = new System.Windows.Forms.Padding(10);
            this.BtnNotificaciones.Name = "BtnNotificaciones";
            this.BtnNotificaciones.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.BtnNotificaciones.Size = new System.Drawing.Size(220, 220);
            this.BtnNotificaciones.TabIndex = 27;
            this.BtnNotificaciones.Text = "Notificaciones";
            this.BtnNotificaciones.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnNotificaciones.UseVisualStyleBackColor = false;
            this.BtnNotificaciones.Click += new System.EventHandler(this.btnNotifiaciones_Click);
            // 
            // BtnPresupuestos
            // 
            this.BtnPresupuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnPresupuestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnPresupuestos.BorderColor = System.Drawing.Color.Transparent;
            this.BtnPresupuestos.BorderRadius = 8;
            this.BtnPresupuestos.BorderSize = 0;
            this.BtnPresupuestos.ButtonImage = global::ProyectoEquipo3.Properties.Resources.icons8_pila_de_monedas_50;
            this.BtnPresupuestos.FlatAppearance.BorderSize = 0;
            this.BtnPresupuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPresupuestos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPresupuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnPresupuestos.HoverColor = System.Drawing.Color.Silver;
            this.BtnPresupuestos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPresupuestos.ImagePadding = 40;
            this.BtnPresupuestos.Location = new System.Drawing.Point(517, 377);
            this.BtnPresupuestos.Margin = new System.Windows.Forms.Padding(10);
            this.BtnPresupuestos.Name = "BtnPresupuestos";
            this.BtnPresupuestos.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.BtnPresupuestos.Size = new System.Drawing.Size(220, 220);
            this.BtnPresupuestos.TabIndex = 27;
            this.BtnPresupuestos.Text = "Presupuesto";
            this.BtnPresupuestos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnPresupuestos.UseVisualStyleBackColor = false;
            this.BtnPresupuestos.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnUsuarios.BorderColor = System.Drawing.Color.Transparent;
            this.BtnUsuarios.BorderRadius = 8;
            this.BtnUsuarios.BorderSize = 0;
            this.BtnUsuarios.ButtonImage = global::ProyectoEquipo3.Properties.Resources.icons8_cuenta_de_prueba_50;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnUsuarios.HoverColor = System.Drawing.Color.Silver;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUsuarios.ImagePadding = 40;
            this.BtnUsuarios.Location = new System.Drawing.Point(757, 377);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(10);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.BtnUsuarios.Size = new System.Drawing.Size(220, 220);
            this.BtnUsuarios.TabIndex = 27;
            this.BtnUsuarios.Text = "Gestión de\r\nusuarios";
            this.BtnUsuarios.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.LblBienvenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.ForeColor = System.Drawing.SystemColors.Control;
            this.LblBienvenido.Location = new System.Drawing.Point(12, 74);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(187, 32);
            this.LblBienvenido.TabIndex = 28;
            this.LblBienvenido.Text = "BIENVENIDO";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoEquipo3.Properties.Resources.Group_291;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 677);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.BtnUsuarios);
            this.Controls.Add(this.BtnProveedores);
            this.Controls.Add(this.BtnPresupuestos);
            this.Controls.Add(this.BtnNotificaciones);
            this.Controls.Add(this.BtnProyectos);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnCerrar;
        private RoundedButton BtnInventario;
        private RoundedButton BtnProyectos;
        private RoundedButton BtnProveedores;
        private RoundedButton BtnNotificaciones;
        private RoundedButton BtnPresupuestos;
        private RoundedButton BtnUsuarios;
        private System.Windows.Forms.Label LblBienvenido;
    }
}