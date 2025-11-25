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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnPrueba = new System.Windows.Forms.Button();
            this.CmbFiltrar = new System.Windows.Forms.ComboBox();
            this.BtnPendientes = new System.Windows.Forms.Button();
            this.BtnUrgentes = new System.Windows.Forms.Button();
            this.BtnAtrasadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(9, 40);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 28);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(9, 83);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(649, 333);
            this.DtgDatos.TabIndex = 5;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(630, 10);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(28, 19);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnPrueba
            // 
            this.BtnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrueba.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrueba.Location = new System.Drawing.Point(184, 40);
            this.BtnPrueba.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrueba.Name = "BtnPrueba";
            this.BtnPrueba.Size = new System.Drawing.Size(64, 28);
            this.BtnPrueba.TabIndex = 8;
            this.BtnPrueba.Text = "Ver";
            this.BtnPrueba.UseVisualStyleBackColor = true;
            this.BtnPrueba.Click += new System.EventHandler(this.BtnPrueba_Click);
            // 
            // CmbFiltrar
            // 
            this.CmbFiltrar.FormattingEnabled = true;
            this.CmbFiltrar.Items.AddRange(new object[] {
            "Pendiente",
            "En Proceso",
            "Pausado",
            "Completado",
            "Cancelado"});
            this.CmbFiltrar.Location = new System.Drawing.Point(88, 49);
            this.CmbFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.CmbFiltrar.Name = "CmbFiltrar";
            this.CmbFiltrar.Size = new System.Drawing.Size(92, 21);
            this.CmbFiltrar.TabIndex = 9;
            this.CmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.CmbFiltrar_SelectedIndexChanged);
            // 
            // BtnPendientes
            // 
            this.BtnPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPendientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPendientes.Location = new System.Drawing.Point(390, 33);
            this.BtnPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPendientes.Name = "BtnPendientes";
            this.BtnPendientes.Size = new System.Drawing.Size(86, 41);
            this.BtnPendientes.TabIndex = 2;
            this.BtnPendientes.UseVisualStyleBackColor = true;
            this.BtnPendientes.Click += new System.EventHandler(this.BtnPendientes_Click);
            // 
            // BtnUrgentes
            // 
            this.BtnUrgentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUrgentes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUrgentes.Location = new System.Drawing.Point(481, 33);
            this.BtnUrgentes.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUrgentes.Name = "BtnUrgentes";
            this.BtnUrgentes.Size = new System.Drawing.Size(86, 41);
            this.BtnUrgentes.TabIndex = 3;
            this.BtnUrgentes.UseVisualStyleBackColor = true;
            this.BtnUrgentes.Click += new System.EventHandler(this.BtnUrgentes_Click);
            // 
            // BtnAtrasadas
            // 
            this.BtnAtrasadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtrasadas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtrasadas.Location = new System.Drawing.Point(572, 33);
            this.BtnAtrasadas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAtrasadas.Name = "BtnAtrasadas";
            this.BtnAtrasadas.Size = new System.Drawing.Size(86, 41);
            this.BtnAtrasadas.TabIndex = 4;
            this.BtnAtrasadas.UseVisualStyleBackColor = true;
            this.BtnAtrasadas.Click += new System.EventHandler(this.BtnAtrasadas_Click);
            // 
            // FrmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 426);
            this.Controls.Add(this.CmbFiltrar);
            this.Controls.Add(this.BtnPrueba);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnAtrasadas);
            this.Controls.Add(this.BtnUrgentes);
            this.Controls.Add(this.BtnPendientes);
            this.Controls.Add(this.BtnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProyectos";
            this.Load += new System.EventHandler(this.FrmProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnPrueba;
        private System.Windows.Forms.ComboBox CmbFiltrar;
        private System.Windows.Forms.Button BtnPendientes;
        private System.Windows.Forms.Button BtnUrgentes;
        private System.Windows.Forms.Button BtnAtrasadas;
    }
}