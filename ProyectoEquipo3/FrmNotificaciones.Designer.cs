namespace ProyectoEquipo3
{
    partial class FrmNotificaciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificaciones));
            this.panelSistemaContainer = new System.Windows.Forms.Panel();
            this.flpNotificacionesSistema = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.timerAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpProgramadas = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProgramadas = new System.Windows.Forms.DataGridView();
            this.lblBadgeCount = new System.Windows.Forms.Label();
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
            this.btnRefrescarNotificaciones = new System.Windows.Forms.Button();
            this.btnProgramarNotificacion = new RoundedButton();
            this.panelSistemaContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramadas)).BeginInit();
            this.FlpAngosto.SuspendLayout();
            this.FlpAncho.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSistemaContainer
            // 
            this.panelSistemaContainer.Controls.Add(this.flpNotificacionesSistema);
            this.panelSistemaContainer.Controls.Add(this.lblTituloSistema);
            this.panelSistemaContainer.Location = new System.Drawing.Point(251, 143);
            this.panelSistemaContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSistemaContainer.Name = "panelSistemaContainer";
            this.panelSistemaContainer.Size = new System.Drawing.Size(405, 563);
            this.panelSistemaContainer.TabIndex = 2;
            // 
            // flpNotificacionesSistema
            // 
            this.flpNotificacionesSistema.AutoScroll = true;
            this.flpNotificacionesSistema.BackColor = System.Drawing.Color.Silver;
            this.flpNotificacionesSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNotificacionesSistema.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNotificacionesSistema.Location = new System.Drawing.Point(0, 20);
            this.flpNotificacionesSistema.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpNotificacionesSistema.Name = "flpNotificacionesSistema";
            this.flpNotificacionesSistema.Padding = new System.Windows.Forms.Padding(6);
            this.flpNotificacionesSistema.Size = new System.Drawing.Size(405, 543);
            this.flpNotificacionesSistema.TabIndex = 1;
            this.flpNotificacionesSistema.WrapContents = false;
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSistema.Location = new System.Drawing.Point(0, 0);
            this.lblTituloSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloSistema.Name = "lblTituloSistema";
            this.lblTituloSistema.Size = new System.Drawing.Size(192, 20);
            this.lblTituloSistema.TabIndex = 0;
            this.lblTituloSistema.Text = "Notificaciones del sistema";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpProgramadas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(661, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 563);
            this.panel1.TabIndex = 3;
            // 
            // flpProgramadas
            // 
            this.flpProgramadas.AutoScroll = true;
            this.flpProgramadas.BackColor = System.Drawing.Color.Silver;
            this.flpProgramadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProgramadas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProgramadas.Location = new System.Drawing.Point(0, 20);
            this.flpProgramadas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpProgramadas.Name = "flpProgramadas";
            this.flpProgramadas.Padding = new System.Windows.Forms.Padding(6);
            this.flpProgramadas.Size = new System.Drawing.Size(405, 543);
            this.flpProgramadas.TabIndex = 1;
            this.flpProgramadas.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificaciones programadas";
            // 
            // dgvProgramadas
            // 
            this.dgvProgramadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramadas.Location = new System.Drawing.Point(628, 60);
            this.dgvProgramadas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvProgramadas.Name = "dgvProgramadas";
            this.dgvProgramadas.RowHeadersWidth = 51;
            this.dgvProgramadas.RowTemplate.Height = 24;
            this.dgvProgramadas.Size = new System.Drawing.Size(47, 25);
            this.dgvProgramadas.TabIndex = 3;
            this.dgvProgramadas.Visible = false;
            // 
            // lblBadgeCount
            // 
            this.lblBadgeCount.Location = new System.Drawing.Point(1309, 253);
            this.lblBadgeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBadgeCount.Name = "lblBadgeCount";
            this.lblBadgeCount.Size = new System.Drawing.Size(10, 10);
            this.lblBadgeCount.TabIndex = 3;
            this.lblBadgeCount.Text = "0";
            this.lblBadgeCount.Visible = false;
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
            this.BtnProyectos1.Click += new System.EventHandler(this.BtnProyectos_Click);
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
            this.BtnNotificaciones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
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
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(109)))), ((int)(((byte)(84)))));
            this.BtnNotificaciones.FlatAppearance.BorderSize = 0;
            this.BtnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // BtnPresupuesto
            // 
            this.BtnPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(134)))), ((int)(((byte)(105)))));
            this.BtnPresupuesto.FlatAppearance.BorderSize = 0;
            this.BtnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel2.Controls.Add(this.BtnCerrar);
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
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.Location = new System.Drawing.Point(1164, 10);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(35, 35);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Location = new System.Drawing.Point(1207, 10);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(35, 35);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnRefrescarNotificaciones
            // 
            this.btnRefrescarNotificaciones.BackColor = System.Drawing.Color.Silver;
            this.btnRefrescarNotificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefrescarNotificaciones.Location = new System.Drawing.Point(827, 72);
            this.btnRefrescarNotificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescarNotificaciones.Name = "btnRefrescarNotificaciones";
            this.btnRefrescarNotificaciones.Size = new System.Drawing.Size(53, 52);
            this.btnRefrescarNotificaciones.TabIndex = 27;
            this.btnRefrescarNotificaciones.UseVisualStyleBackColor = false;
            this.btnRefrescarNotificaciones.Click += new System.EventHandler(this.BtnRefrescarNotificaciones_Click);
            // 
            // btnProgramarNotificacion
            // 
            this.btnProgramarNotificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnProgramarNotificacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnProgramarNotificacion.BorderColor = System.Drawing.Color.Transparent;
            this.btnProgramarNotificacion.BorderRadius = 20;
            this.btnProgramarNotificacion.BorderSize = 1;
            this.btnProgramarNotificacion.FlatAppearance.BorderSize = 0;
            this.btnProgramarNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramarNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramarNotificacion.ForeColor = System.Drawing.Color.White;
            this.btnProgramarNotificacion.Location = new System.Drawing.Point(885, 72);
            this.btnProgramarNotificacion.Name = "btnProgramarNotificacion";
            this.btnProgramarNotificacion.Size = new System.Drawing.Size(181, 52);
            this.btnProgramarNotificacion.TabIndex = 28;
            this.btnProgramarNotificacion.Text = "+ Programar notificación";
            this.btnProgramarNotificacion.TextColor = System.Drawing.Color.White;
            this.btnProgramarNotificacion.UseVisualStyleBackColor = false;
            this.btnProgramarNotificacion.Click += new System.EventHandler(this.btnProgramarNotificacion_Click_1);
            // 
            // FrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 677);
            this.Controls.Add(this.btnProgramarNotificacion);
            this.Controls.Add(this.btnRefrescarNotificaciones);
            this.Controls.Add(this.FlpAngosto);
            this.Controls.Add(this.FlpAncho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProgramadas);
            this.Controls.Add(this.lblBadgeCount);
            this.Controls.Add(this.panelSistemaContainer);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNotificaciones";
            this.Load += new System.EventHandler(this.FrmNotificaciones_Load);
            this.panelSistemaContainer.ResumeLayout(false);
            this.panelSistemaContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramadas)).EndInit();
            this.FlpAngosto.ResumeLayout(false);
            this.FlpAncho.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSistemaContainer;
        private System.Windows.Forms.FlowLayoutPanel flpNotificacionesSistema;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Timer timerAutoRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpProgramadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProgramadas;
        private System.Windows.Forms.Label lblBadgeCount;
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
        private System.Windows.Forms.Button btnRefrescarNotificaciones;
        private RoundedButton btnProgramarNotificacion;
    }
}