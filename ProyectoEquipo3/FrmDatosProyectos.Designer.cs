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
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMueble = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DtgMateriales = new System.Windows.Forms.DataGridView();
            this.PanelMateriales = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new RoundedButton();
            this.BtnGuardar = new RoundedButton();
            this.BtnAgregarMaterial = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriales)).BeginInit();
            this.PanelMateriales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del mueble";
            // 
            // CmbEstado
            // 
            this.CmbEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En Proceso",
            "Pausado",
            "Completado",
            "Cancelado"});
            this.CmbEstado.Location = new System.Drawing.Point(33, 153);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(176, 26);
            this.CmbEstado.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estado Proyecto";
            // 
            // TxtMueble
            // 
            this.TxtMueble.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMueble.Location = new System.Drawing.Point(33, 52);
            this.TxtMueble.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMueble.Name = "TxtMueble";
            this.TxtMueble.Size = new System.Drawing.Size(176, 26);
            this.TxtMueble.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha Estimada";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Location = new System.Drawing.Point(33, 277);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(176, 26);
            this.DtpFecha.TabIndex = 27;
            // 
            // DtgMateriales
            // 
            this.DtgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMateriales.Location = new System.Drawing.Point(12, 21);
            this.DtgMateriales.Name = "DtgMateriales";
            this.DtgMateriales.Size = new System.Drawing.Size(373, 211);
            this.DtgMateriales.TabIndex = 28;
            this.DtgMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMateriales_CellClick);
            // 
            // PanelMateriales
            // 
            this.PanelMateriales.Controls.Add(this.BtnAgregarMaterial);
            this.PanelMateriales.Controls.Add(this.DtgMateriales);
            this.PanelMateriales.Location = new System.Drawing.Point(243, 13);
            this.PanelMateriales.Margin = new System.Windows.Forms.Padding(5);
            this.PanelMateriales.Name = "PanelMateriales";
            this.PanelMateriales.Size = new System.Drawing.Size(398, 322);
            this.PanelMateriales.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.DtpFecha);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtMueble);
            this.panel1.Controls.Add(this.CmbEstado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PanelMateriales);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 450);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 450);
            this.panel2.TabIndex = 32;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnCancelar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BorderRadius = 20;
            this.BtnCancelar.BorderSize = 1;
            this.BtnCancelar.ButtonImage = null;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnCancelar.Location = new System.Drawing.Point(390, 368);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnCancelar.Size = new System.Drawing.Size(126, 59);
            this.BtnCancelar.TabIndex = 47;
            this.BtnCancelar.Text = "x Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(185)))), ((int)(((byte)(116)))));
            this.BtnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(185)))), ((int)(((byte)(116)))));
            this.BtnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BorderRadius = 20;
            this.BtnGuardar.BorderSize = 1;
            this.BtnGuardar.ButtonImage = null;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.BtnGuardar.Location = new System.Drawing.Point(140, 368);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(139)))), ((int)(((byte)(70)))));
            this.BtnGuardar.Size = new System.Drawing.Size(126, 59);
            this.BtnGuardar.TabIndex = 48;
            this.BtnGuardar.Text = "+ Guardar";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAgregarMaterial
            // 
            this.BtnAgregarMaterial.BackColor = System.Drawing.SystemColors.Window;
            this.BtnAgregarMaterial.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BtnAgregarMaterial.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnAgregarMaterial.BorderRadius = 20;
            this.BtnAgregarMaterial.BorderSize = 2;
            this.BtnAgregarMaterial.ButtonImage = null;
            this.BtnAgregarMaterial.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarMaterial.ForeColor = System.Drawing.Color.Gray;
            this.BtnAgregarMaterial.HoverColor = System.Drawing.SystemColors.Control;
            this.BtnAgregarMaterial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAgregarMaterial.Location = new System.Drawing.Point(284, 249);
            this.BtnAgregarMaterial.Name = "BtnAgregarMaterial";
            this.BtnAgregarMaterial.PressedColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAgregarMaterial.Size = new System.Drawing.Size(101, 41);
            this.BtnAgregarMaterial.TabIndex = 43;
            this.BtnAgregarMaterial.Text = "Agregar\r\nmaterial\r\n";
            this.BtnAgregarMaterial.TextColor = System.Drawing.Color.Gray;
            this.BtnAgregarMaterial.UseVisualStyleBackColor = false;
            this.BtnAgregarMaterial.Click += new System.EventHandler(this.BtnAgregarMaterial_Click);
            // 
            // FrmDatosProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(670, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDatosProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosProyectos";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriales)).EndInit();
            this.PanelMateriales.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMueble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridView DtgMateriales;
        private System.Windows.Forms.Panel PanelMateriales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundedButton BtnCancelar;
        private RoundedButton BtnGuardar;
        private RoundedButton BtnAgregarMaterial;
    }
}