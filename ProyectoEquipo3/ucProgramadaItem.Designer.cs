namespace ProyectoEquipo3
{
    partial class ucProgramadaItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRelacionado = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Location = new System.Drawing.Point(466, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "🗑";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFecha.Location = new System.Drawing.Point(18, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(140, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "label1";
            // 
            // lblRelacionado
            // 
            this.lblRelacionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelacionado.ForeColor = System.Drawing.Color.Gray;
            this.lblRelacionado.Location = new System.Drawing.Point(18, 58);
            this.lblRelacionado.Name = "lblRelacionado";
            this.lblRelacionado.Size = new System.Drawing.Size(380, 18);
            this.lblRelacionado.TabIndex = 5;
            this.lblRelacionado.Text = "label1";
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAviso.AutoEllipsis = true;
            this.lblAviso.Location = new System.Drawing.Point(18, 10);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(380, 48);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.Text = "label1";
            // 
            // btnCompletar
            // 
            this.btnCompletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompletar.Location = new System.Drawing.Point(373, 39);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(70, 28);
            this.btnCompletar.TabIndex = 8;
            this.btnCompletar.Text = "✓";
            this.btnCompletar.UseVisualStyleBackColor = true;
            // 
            // ucProgramadaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblRelacionado);
            this.Controls.Add(this.lblAviso);
            this.Name = "ucProgramadaItem";
            this.Size = new System.Drawing.Size(520, 110);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRelacionado;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnCompletar;
    }
}
