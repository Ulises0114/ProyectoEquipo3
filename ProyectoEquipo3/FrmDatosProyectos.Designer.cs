namespace ProyectoEquipo3
{
    partial class FrmDatosProyectos
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMueble = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DtgMateriales = new System.Windows.Forms.DataGridView();
            this.BtnAgregarMaterial = new System.Windows.Forms.Button();
            this.PanelMateriales = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriales)).BeginInit();
            this.PanelMateriales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del mueble";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(31, 395);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(86, 32);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(136, 395);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 32);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbEstado
            // 
            this.CmbEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En Proceso",
            "Pausado",
            "Completado",
            "Cancelado"});
            this.CmbEstado.Location = new System.Drawing.Point(37, 160);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(176, 24);
            this.CmbEstado.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estado Proyecto";
            // 
            // TxtMueble
            // 
            this.TxtMueble.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMueble.Location = new System.Drawing.Point(37, 97);
            this.TxtMueble.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMueble.Name = "TxtMueble";
            this.TxtMueble.Size = new System.Drawing.Size(176, 23);
            this.TxtMueble.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha Estimada";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(31, 232);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 27;
            // 
            // DtgMateriales
            // 
            this.DtgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMateriales.Location = new System.Drawing.Point(250, 38);
            this.DtgMateriales.Name = "DtgMateriales";
            this.DtgMateriales.Size = new System.Drawing.Size(373, 211);
            this.DtgMateriales.TabIndex = 28;
            this.DtgMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMateriales_CellClick);
            // 
            // BtnAgregarMaterial
            // 
            this.BtnAgregarMaterial.Location = new System.Drawing.Point(249, 265);
            this.BtnAgregarMaterial.Name = "BtnAgregarMaterial";
            this.BtnAgregarMaterial.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarMaterial.TabIndex = 29;
            this.BtnAgregarMaterial.Text = "button1";
            this.BtnAgregarMaterial.UseVisualStyleBackColor = true;
            this.BtnAgregarMaterial.Click += new System.EventHandler(this.BtnAgregarMaterial_Click);
            // 
            // PanelMateriales
            // 
            this.PanelMateriales.Controls.Add(this.BtnAgregarMaterial);
            this.PanelMateriales.Location = new System.Drawing.Point(237, 20);
            this.PanelMateriales.Name = "PanelMateriales";
            this.PanelMateriales.Size = new System.Drawing.Size(398, 357);
            this.PanelMateriales.TabIndex = 30;
            // 
            // FrmDatosProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 458);
            this.Controls.Add(this.DtgMateriales);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMueble);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDatosProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriales)).EndInit();
            this.PanelMateriales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMueble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridView DtgMateriales;
        private System.Windows.Forms.Button BtnAgregarMaterial;
        private System.Windows.Forms.Panel PanelMateriales;
    }
}