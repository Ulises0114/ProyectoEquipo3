namespace ProyectoEquipo3.Controls
{
    partial class ucNotificacionItem
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
            this.lblMensajePreview = new System.Windows.Forms.Label();
            this.lblRelacionado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensajePreview
            // 
            this.lblMensajePreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensajePreview.AutoEllipsis = true;
            this.lblMensajePreview.Location = new System.Drawing.Point(3, 11);
            this.lblMensajePreview.Name = "lblMensajePreview";
            this.lblMensajePreview.Size = new System.Drawing.Size(442, 48);
            this.lblMensajePreview.TabIndex = 0;
            this.lblMensajePreview.Text = "label1";
            // 
            // lblRelacionado
            // 
            this.lblRelacionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelacionado.ForeColor = System.Drawing.Color.Gray;
            this.lblRelacionado.Location = new System.Drawing.Point(3, 59);
            this.lblRelacionado.Name = "lblRelacionado";
            this.lblRelacionado.Size = new System.Drawing.Size(380, 18);
            this.lblRelacionado.TabIndex = 1;
            this.lblRelacionado.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFecha.Location = new System.Drawing.Point(3, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Location = new System.Drawing.Point(451, 40);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "🗑";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ucNotificacionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblRelacionado);
            this.Controls.Add(this.lblMensajePreview);
            this.Name = "ucNotificacionItem";
            this.Size = new System.Drawing.Size(520, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajePreview;
        private System.Windows.Forms.Label lblRelacionado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnEliminar;
    }
}
