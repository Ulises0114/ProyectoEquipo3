namespace ProyectoEquipo3
{
    partial class FrmProgramarNotificacion
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
            this.dtpFechaNotificacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha y hora";
            // 
            // dtpFechaNotificacion
            // 
            this.dtpFechaNotificacion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaNotificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNotificacion.Location = new System.Drawing.Point(69, 60);
            this.dtpFechaNotificacion.Name = "dtpFechaNotificacion";
            this.dtpFechaNotificacion.ShowUpDown = true;
            this.dtpFechaNotificacion.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNotificacion.TabIndex = 1;
            this.dtpFechaNotificacion.Value = new System.DateTime(2025, 11, 21, 12, 16, 8, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aviso";
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(69, 123);
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(200, 145);
            this.txtAviso.TabIndex = 3;
            // 
            // btnProgramar
            // 
            this.btnProgramar.Location = new System.Drawing.Point(57, 288);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(107, 39);
            this.btnProgramar.TabIndex = 4;
            this.btnProgramar.Text = "+ Guardar";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(179, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "x Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmProgramarNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 364);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProgramar);
            this.Controls.Add(this.txtAviso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaNotificacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProgramarNotificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProgramarNotificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNotificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.Button btnCancelar;
    }
}