namespace ProyectoEquipo3
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.FlpAngosto = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnMenu1 = new System.Windows.Forms.Button();
            this.BtnInventario1 = new System.Windows.Forms.Button();
            this.BtnProyectos1 = new System.Windows.Forms.Button();
            this.BtnProveedores1 = new System.Windows.Forms.Button();
            this.BtnNotificaciones1 = new System.Windows.Forms.Button();
            this.BtnPresupuesto1 = new System.Windows.Forms.Button();
            this.BtnUsuarios1 = new System.Windows.Forms.Button();
            this.FlpAncho = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnProyectos = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnNotificaciones = new System.Windows.Forms.Button();
            this.BtnPresupuesto = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.FlpAngosto.SuspendLayout();
            this.FlpAncho.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::ProyectoEquipo3.Properties.Resources.IconoBuscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(541, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 47);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Mostrar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(370, 116);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 47);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "+  Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::ProyectoEquipo3.Properties.Resources.IconoEditar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(888, 116);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 47);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseCompatibleTextRendering = true;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::ProyectoEquipo3.Properties.Resources.IconoEliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(1057, 116);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 47);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FlpAngosto
            // 
            this.FlpAngosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.FlpAngosto.Controls.Add(this.BtnMenu1);
            this.FlpAngosto.Controls.Add(this.BtnInventario1);
            this.FlpAngosto.Controls.Add(this.BtnProyectos1);
            this.FlpAngosto.Controls.Add(this.BtnProveedores1);
            this.FlpAngosto.Controls.Add(this.BtnNotificaciones1);
            this.FlpAngosto.Controls.Add(this.BtnPresupuesto1);
            this.FlpAngosto.Controls.Add(this.BtnUsuarios1);
            this.FlpAngosto.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpAngosto.Location = new System.Drawing.Point(0, 54);
            this.FlpAngosto.Name = "FlpAngosto";
            this.FlpAngosto.Size = new System.Drawing.Size(67, 623);
            this.FlpAngosto.TabIndex = 30;
            // 
            // BtnMenu1
            // 
            this.BtnMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnMenu1.FlatAppearance.BorderSize = 0;
            this.BtnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu1.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu1.Image")));
            this.BtnMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu1.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnMenu1.Name = "BtnMenu1";
            this.BtnMenu1.Size = new System.Drawing.Size(66, 88);
            this.BtnMenu1.TabIndex = 0;
            this.BtnMenu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu1.UseVisualStyleBackColor = false;
            // 
            // BtnInventario1
            // 
            this.BtnInventario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnInventario1.FlatAppearance.BorderSize = 0;
            this.BtnInventario1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario1.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario1.Image")));
            this.BtnInventario1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario1.Location = new System.Drawing.Point(0, 89);
            this.BtnInventario1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnInventario1.Name = "BtnInventario1";
            this.BtnInventario1.Size = new System.Drawing.Size(66, 88);
            this.BtnInventario1.TabIndex = 1;
            this.BtnInventario1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventario1.UseVisualStyleBackColor = false;
            // 
            // BtnProyectos1
            // 
            this.BtnProyectos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnProyectos1.FlatAppearance.BorderSize = 0;
            this.BtnProyectos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProyectos1.Image = ((System.Drawing.Image)(resources.GetObject("BtnProyectos1.Image")));
            this.BtnProyectos1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProyectos1.Location = new System.Drawing.Point(0, 178);
            this.BtnProyectos1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnProyectos1.Name = "BtnProyectos1";
            this.BtnProyectos1.Size = new System.Drawing.Size(66, 88);
            this.BtnProyectos1.TabIndex = 2;
            this.BtnProyectos1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProyectos1.UseVisualStyleBackColor = false;
            // 
            // BtnProveedores1
            // 
            this.BtnProveedores1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnProveedores1.FlatAppearance.BorderSize = 0;
            this.BtnProveedores1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores1.Image = ((System.Drawing.Image)(resources.GetObject("BtnProveedores1.Image")));
            this.BtnProveedores1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores1.Location = new System.Drawing.Point(0, 267);
            this.BtnProveedores1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnProveedores1.Name = "BtnProveedores1";
            this.BtnProveedores1.Size = new System.Drawing.Size(66, 88);
            this.BtnProveedores1.TabIndex = 3;
            this.BtnProveedores1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedores1.UseVisualStyleBackColor = false;
            // 
            // BtnNotificaciones1
            // 
            this.BtnNotificaciones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnNotificaciones1.FlatAppearance.BorderSize = 0;
            this.BtnNotificaciones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotificaciones1.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotificaciones1.Image")));
            this.BtnNotificaciones1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotificaciones1.Location = new System.Drawing.Point(0, 356);
            this.BtnNotificaciones1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnNotificaciones1.Name = "BtnNotificaciones1";
            this.BtnNotificaciones1.Size = new System.Drawing.Size(66, 88);
            this.BtnNotificaciones1.TabIndex = 4;
            this.BtnNotificaciones1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNotificaciones1.UseVisualStyleBackColor = false;
            // 
            // BtnPresupuesto1
            // 
            this.BtnPresupuesto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnPresupuesto1.FlatAppearance.BorderSize = 0;
            this.BtnPresupuesto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPresupuesto1.Image = ((System.Drawing.Image)(resources.GetObject("BtnPresupuesto1.Image")));
            this.BtnPresupuesto1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPresupuesto1.Location = new System.Drawing.Point(0, 445);
            this.BtnPresupuesto1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnPresupuesto1.Name = "BtnPresupuesto1";
            this.BtnPresupuesto1.Size = new System.Drawing.Size(66, 88);
            this.BtnPresupuesto1.TabIndex = 5;
            this.BtnPresupuesto1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPresupuesto1.UseVisualStyleBackColor = false;
            // 
            // BtnUsuarios1
            // 
            this.BtnUsuarios1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnUsuarios1.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios1.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuarios1.Image")));
            this.BtnUsuarios1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios1.Location = new System.Drawing.Point(0, 534);
            this.BtnUsuarios1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnUsuarios1.Name = "BtnUsuarios1";
            this.BtnUsuarios1.Size = new System.Drawing.Size(66, 88);
            this.BtnUsuarios1.TabIndex = 6;
            this.BtnUsuarios1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios1.UseVisualStyleBackColor = false;
            // 
            // FlpAncho
            // 
            this.FlpAncho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.FlpAncho.Controls.Add(this.BtnMenu);
            this.FlpAncho.Controls.Add(this.BtnInventario);
            this.FlpAncho.Controls.Add(this.BtnProyectos);
            this.FlpAncho.Controls.Add(this.BtnProveedores);
            this.FlpAncho.Controls.Add(this.BtnNotificaciones);
            this.FlpAncho.Controls.Add(this.BtnPresupuesto);
            this.FlpAncho.Controls.Add(this.BtnUsuarios);
            this.FlpAncho.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlpAncho.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpAncho.Location = new System.Drawing.Point(0, 54);
            this.FlpAncho.Name = "FlpAncho";
            this.FlpAncho.Size = new System.Drawing.Size(227, 623);
            this.FlpAncho.TabIndex = 29;
            this.FlpAncho.Visible = false;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(226, 88);
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.Text = "     Menú";
            this.BtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(0, 89);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(226, 88);
            this.BtnInventario.TabIndex = 1;
            this.BtnInventario.Text = "Gestion \r\n     de inventario";
            this.BtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnProyectos
            // 
            this.BtnProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnProyectos.FlatAppearance.BorderSize = 0;
            this.BtnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProyectos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProyectos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProyectos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProyectos.Image")));
            this.BtnProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProyectos.Location = new System.Drawing.Point(0, 178);
            this.BtnProyectos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnProyectos.Name = "BtnProyectos";
            this.BtnProyectos.Size = new System.Drawing.Size(226, 88);
            this.BtnProyectos.TabIndex = 2;
            this.BtnProyectos.Text = "     Proyectos\r\n     pendientes";
            this.BtnProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProyectos.UseVisualStyleBackColor = false;
            this.BtnProyectos.Click += new System.EventHandler(this.BtnProyectos_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnProveedores.FlatAppearance.BorderSize = 0;
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("BtnProveedores.Image")));
            this.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores.Location = new System.Drawing.Point(0, 267);
            this.BtnProveedores.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(226, 88);
            this.BtnProveedores.TabIndex = 3;
            this.BtnProveedores.Text = "     Proveedores";
            this.BtnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // BtnNotificaciones
            // 
            this.BtnNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnNotificaciones.FlatAppearance.BorderSize = 0;
            this.BtnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotificaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotificaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnNotificaciones.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotificaciones.Image")));
            this.BtnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotificaciones.Location = new System.Drawing.Point(0, 356);
            this.BtnNotificaciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnNotificaciones.Name = "BtnNotificaciones";
            this.BtnNotificaciones.Size = new System.Drawing.Size(226, 88);
            this.BtnNotificaciones.TabIndex = 4;
            this.BtnNotificaciones.Text = "     Notificaciones";
            this.BtnNotificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNotificaciones.UseVisualStyleBackColor = false;
            this.BtnNotificaciones.Click += new System.EventHandler(this.BtnNotificaciones_Click);
            // 
            // BtnPresupuesto
            // 
            this.BtnPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnPresupuesto.FlatAppearance.BorderSize = 0;
            this.BtnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPresupuesto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPresupuesto.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("BtnPresupuesto.Image")));
            this.BtnPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPresupuesto.Location = new System.Drawing.Point(0, 445);
            this.BtnPresupuesto.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnPresupuesto.Name = "BtnPresupuesto";
            this.BtnPresupuesto.Size = new System.Drawing.Size(226, 88);
            this.BtnPresupuesto.TabIndex = 5;
            this.BtnPresupuesto.Text = "     Presupuesto";
            this.BtnPresupuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPresupuesto.UseVisualStyleBackColor = false;
            this.BtnPresupuesto.Click += new System.EventHandler(this.BtnPresupuesto_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuarios.Image")));
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 534);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(226, 88);
            this.BtnUsuarios.TabIndex = 6;
            this.BtnUsuarios.Text = "     Usuarios";
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios.UseVisualStyleBackColor = false;
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
            this.panel2.TabIndex = 28;
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(132)))));
            this.BtnMin.BackgroundImage = global::ProyectoEquipo3.Properties.Resources.icons8_minimizar_50;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.Location = new System.Drawing.Point(1164, 10);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(35, 35);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.UseVisualStyleBackColor = false;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(172, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Proveedores aprobados";
            // 
            // dtgDatosUsuarios
            // 
            this.dtgDatosUsuarios.AllowUserToAddRows = false;
            this.dtgDatosUsuarios.AllowUserToDeleteRows = false;
            this.dtgDatosUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatosUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            this.dtgDatosUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatosUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDatosUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDatosUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(96)))), ((int)(((byte)(93)))));
            this.dtgDatosUsuarios.Location = new System.Drawing.Point(86, 176);
            this.dtgDatosUsuarios.Name = "dtgDatosUsuarios";
            this.dtgDatosUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgDatosUsuarios.RowHeadersWidth = 62;
            this.dtgDatosUsuarios.Size = new System.Drawing.Size(1120, 475);
            this.dtgDatosUsuarios.TabIndex = 2;
            this.dtgDatosUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatosUsuarios_CellClick);
            this.dtgDatosUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatosUsuarios_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label3.Location = new System.Drawing.Point(81, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Miembro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Administrador";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(476, 65);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(711, 46);
            this.TxtBuscar.TabIndex = 34;
            this.TxtBuscar.Visible = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoEquipo3.Properties.Resources.Group_29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 677);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlpAngosto);
            this.Controls.Add(this.FlpAncho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtgDatosUsuarios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.FlpAngosto.ResumeLayout(false);
            this.FlpAncho.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.FlowLayoutPanel FlpAngosto;
        private System.Windows.Forms.Button BtnMenu1;
        private System.Windows.Forms.Button BtnInventario1;
        private System.Windows.Forms.Button BtnProyectos1;
        private System.Windows.Forms.Button BtnProveedores1;
        private System.Windows.Forms.Button BtnNotificaciones1;
        private System.Windows.Forms.Button BtnPresupuesto1;
        private System.Windows.Forms.Button BtnUsuarios1;
        private System.Windows.Forms.FlowLayoutPanel FlpAncho;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnProyectos;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnNotificaciones;
        private System.Windows.Forms.Button BtnPresupuesto;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgDatosUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBuscar;
    }
}