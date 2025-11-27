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
            this.btnProgramar = new RoundedButton();
            this.btnCancelar = new RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha y hora";
            // 
            // dtpFechaNotificacion
            // 
            this.dtpFechaNotificacion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNotificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNotificacion.Location = new System.Drawing.Point(52, 50);
            this.dtpFechaNotificacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNotificacion.Name = "dtpFechaNotificacion";
            this.dtpFechaNotificacion.ShowUpDown = true;
            this.dtpFechaNotificacion.Size = new System.Drawing.Size(260, 29);
            this.dtpFechaNotificacion.TabIndex = 1;
            this.dtpFechaNotificacion.Value = new System.DateTime(2025, 11, 21, 12, 16, 8, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aviso";
            // 
            // txtAviso
            // 
            this.txtAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAviso.Location = new System.Drawing.Point(54, 122);
            this.txtAviso.Margin = new System.Windows.Forms.Padding(2);
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(258, 179);
            this.txtAviso.TabIndex = 3;
            // 
            // btnProgramar
            // 
            this.btnProgramar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnProgramar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnProgramar.BorderColor = System.Drawing.Color.Transparent;
            this.btnProgramar.BorderRadius = 20;
            this.btnProgramar.BorderSize = 1;
            this.btnProgramar.FlatAppearance.BorderSize = 0;
            this.btnProgramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramar.ForeColor = System.Drawing.Color.White;
            this.btnProgramar.Location = new System.Drawing.Point(54, 319);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(117, 47);
            this.btnProgramar.TabIndex = 6;
            this.btnProgramar.Text = "+ Guardar";
            this.btnProgramar.TextColor = System.Drawing.Color.White;
            this.btnProgramar.UseVisualStyleBackColor = false;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(195, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 47);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "x Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmProgramarNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 406);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProgramar);
            this.Controls.Add(this.txtAviso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaNotificacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private RoundedButton btnProgramar;
        private RoundedButton btnCancelar;
    }
}