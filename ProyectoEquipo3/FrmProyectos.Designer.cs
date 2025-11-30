namespace ProyectoEquipo3
{
    partial class FrmProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProyectos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmbFiltrar = new System.Windows.Forms.ComboBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new RoundedButton();
            this.BtnPendientes = new RoundedButton();
            this.BtnAtrasadas = new RoundedButton();
            this.BtnUrgentes = new RoundedButton();
            this.roundedButton1 = new RoundedButton();
            this.FlpAngosto.SuspendLayout();
            this.FlpAncho.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbFiltrar
            // 
            this.CmbFiltrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltrar.FormattingEnabled = true;
            this.CmbFiltrar.Items.AddRange(new object[] {
            "Pendiente",
            "En Proceso",
            "Pausado",
            "Completado",
            "Cancelado"});
            this.CmbFiltrar.Location = new System.Drawing.Point(413, 104);
            this.CmbFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.CmbFiltrar.Name = "CmbFiltrar";
            this.CmbFiltrar.Size = new System.Drawing.Size(114, 28);
            this.CmbFiltrar.TabIndex = 9;
            this.CmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.CmbFiltrar_SelectedIndexChanged);
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
            this.FlpAngosto.TabIndex = 26;
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
            this.BtnMenu1.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnInventario1
            // 
            this.BtnInventario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
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
            this.BtnInventario1.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnProyectos1
            // 
            this.BtnProyectos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
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
            this.BtnProveedores1.Click += new System.EventHandler(this.BtnProveedores_Click);
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
            this.BtnNotificaciones1.Click += new System.EventHandler(this.BtnNotificaciones_Click);
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
            this.BtnPresupuesto1.Click += new System.EventHandler(this.BtnPresupuesto_Click);
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
            this.BtnUsuarios1.Click += new System.EventHandler(this.BtnUsuarios_Click);
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
            this.FlpAncho.TabIndex = 25;
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
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
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
            this.BtnProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
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
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.BtnMin);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 54);
            this.panel2.TabIndex = 24;
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
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.button1.BackgroundImage = global::ProyectoEquipo3.Properties.Resources.icons8_x_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1207, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.AllowUserToResizeColumns = false;
            this.DtgDatos.AllowUserToResizeRows = false;
            this.DtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            this.DtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(137)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(96)))), ((int)(((byte)(93)))));
            this.DtgDatos.Location = new System.Drawing.Point(114, 179);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtgDatos.RowHeadersVisible = false;
            this.DtgDatos.Size = new System.Drawing.Size(1095, 450);
            this.DtgDatos.TabIndex = 27;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(185)))), ((int)(((byte)(116)))));
            this.BtnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(185)))), ((int)(((byte)(116)))));
            this.BtnAgregar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BorderRadius = 20;
            this.BtnAgregar.BorderSize = 1;
            this.BtnAgregar.ButtonImage = null;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.BtnAgregar.Location = new System.Drawing.Point(114, 90);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(139)))), ((int)(((byte)(70)))));
            this.BtnAgregar.Size = new System.Drawing.Size(131, 52);
            this.BtnAgregar.TabIndex = 28;
            this.BtnAgregar.Text = "+ Agregar";
            this.BtnAgregar.TextColor = System.Drawing.Color.White;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnPendientes
            // 
            this.BtnPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(185)))), ((int)(((byte)(116)))));
            this.BtnPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(185)))), ((int)(((byte)(116)))));
            this.BtnPendientes.BorderColor = System.Drawing.Color.Transparent;
            this.BtnPendientes.BorderRadius = 20;
            this.BtnPendientes.BorderSize = 1;
            this.BtnPendientes.ButtonImage = null;
            this.BtnPendientes.FlatAppearance.BorderSize = 0;
            this.BtnPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPendientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPendientes.ForeColor = System.Drawing.Color.White;
            this.BtnPendientes.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.BtnPendientes.Location = new System.Drawing.Point(796, 76);
            this.BtnPendientes.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPendientes.Name = "BtnPendientes";
            this.BtnPendientes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(139)))), ((int)(((byte)(70)))));
            this.BtnPendientes.Size = new System.Drawing.Size(131, 81);
            this.BtnPendientes.TabIndex = 28;
            this.BtnPendientes.TextColor = System.Drawing.Color.White;
            this.BtnPendientes.UseVisualStyleBackColor = false;
            this.BtnPendientes.Click += new System.EventHandler(this.BtnPendientes_Click);
            // 
            // BtnAtrasadas
            // 
            this.BtnAtrasadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(175)))), ((int)(((byte)(78)))));
            this.BtnAtrasadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(175)))), ((int)(((byte)(78)))));
            this.BtnAtrasadas.BorderColor = System.Drawing.Color.Transparent;
            this.BtnAtrasadas.BorderRadius = 20;
            this.BtnAtrasadas.BorderSize = 1;
            this.BtnAtrasadas.ButtonImage = null;
            this.BtnAtrasadas.FlatAppearance.BorderSize = 0;
            this.BtnAtrasadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtrasadas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtrasadas.ForeColor = System.Drawing.Color.White;
            this.BtnAtrasadas.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(149)))), ((int)(((byte)(22)))));
            this.BtnAtrasadas.Location = new System.Drawing.Point(1078, 76);
            this.BtnAtrasadas.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtrasadas.Name = "BtnAtrasadas";
            this.BtnAtrasadas.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(122)))), ((int)(((byte)(18)))));
            this.BtnAtrasadas.Size = new System.Drawing.Size(131, 81);
            this.BtnAtrasadas.TabIndex = 28;
            this.BtnAtrasadas.TextColor = System.Drawing.Color.White;
            this.BtnAtrasadas.UseVisualStyleBackColor = false;
            this.BtnAtrasadas.Click += new System.EventHandler(this.BtnAtrasadas_Click);
            // 
            // BtnUrgentes
            // 
            this.BtnUrgentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnUrgentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnUrgentes.BorderColor = System.Drawing.Color.Transparent;
            this.BtnUrgentes.BorderRadius = 20;
            this.BtnUrgentes.BorderSize = 1;
            this.BtnUrgentes.ButtonImage = null;
            this.BtnUrgentes.FlatAppearance.BorderSize = 0;
            this.BtnUrgentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUrgentes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUrgentes.ForeColor = System.Drawing.Color.White;
            this.BtnUrgentes.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnUrgentes.Location = new System.Drawing.Point(937, 76);
            this.BtnUrgentes.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUrgentes.Name = "BtnUrgentes";
            this.BtnUrgentes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnUrgentes.Size = new System.Drawing.Size(131, 81);
            this.BtnUrgentes.TabIndex = 47;
            this.BtnUrgentes.TextColor = System.Drawing.Color.White;
            this.BtnUrgentes.UseVisualStyleBackColor = false;
            this.BtnUrgentes.Click += new System.EventHandler(this.BtnUrgentes_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.roundedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedButton1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.BorderSize = 1;
            this.roundedButton1.ButtonImage = global::ProyectoEquipo3.Properties.Resources.icons8_filtrar_50;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.HoverColor = System.Drawing.Color.Silver;
            this.roundedButton1.ImagePadding = 10;
            this.roundedButton1.Location = new System.Drawing.Point(255, 90);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(5);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.roundedButton1.Size = new System.Drawing.Size(151, 52);
            this.roundedButton1.TabIndex = 48;
            this.roundedButton1.Text = "Filtrar";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.BtnPrueba_Click);
            // 
            // FrmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoEquipo3.Properties.Resources.Group_291;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 677);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.BtnUrgentes);
            this.Controls.Add(this.BtnAtrasadas);
            this.Controls.Add(this.BtnPendientes);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.FlpAngosto);
            this.Controls.Add(this.FlpAncho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CmbFiltrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProyectos";
            this.Load += new System.EventHandler(this.FrmProyectos_Load);
            this.FlpAngosto.ResumeLayout(false);
            this.FlpAncho.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbFiltrar;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DtgDatos;
        private RoundedButton BtnAgregar;
        private RoundedButton BtnPendientes;
        private RoundedButton BtnAtrasadas;
        private RoundedButton BtnUrgentes;
        private RoundedButton roundedButton1;
    }
}