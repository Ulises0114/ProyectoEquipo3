namespace ProyectoEquipo3
{
    partial class FrmDatosInventario
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new RoundedButton();
            this.btnGuardar = new RoundedButton();
            this.btnSeleccionarImagen = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(71, 73);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(684, 26);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(333, 235);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(139, 26);
            this.txtPrecioCompra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(71, 146);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(684, 28);
            this.cmbProveedor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio de compra";
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "Pieza",
            "Litro",
            "Pulgadas",
            "Kilogramo",
            "Metro"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(71, 228);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(133, 28);
            this.cmbUnidadMedida.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidad de medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Location = new System.Drawing.Point(616, 235);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(139, 26);
            this.dtpFechaIngreso.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stock mínimo";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMinimo.Location = new System.Drawing.Point(204, 289);
            this.txtStockMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(133, 26);
            this.txtStockMinimo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stock actual";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActual.Location = new System.Drawing.Point(470, 289);
            this.txtStockActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(139, 26);
            this.txtStockActual.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripción";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripción.Location = new System.Drawing.Point(71, 352);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(684, 123);
            this.txtDescripción.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(811, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Foto";
            // 
            // pbImagen
            // 
            this.pbImagen.FileName = "openFileDialog1";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(807, 73);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(218, 186);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 20;
            this.pictureBoxPreview.TabStop = false;
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
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(470, 493);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 59);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "x Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 1;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(211, 493);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 59);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "+ Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.BackColor = System.Drawing.Color.Gray;
            this.btnSeleccionarImagen.BackgroundColor = System.Drawing.Color.Gray;
            this.btnSeleccionarImagen.BorderColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarImagen.BorderRadius = 20;
            this.btnSeleccionarImagen.BorderSize = 1;
            this.btnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarImagen.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(855, 265);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(126, 37);
            this.btnSeleccionarImagen.TabIndex = 23;
            this.btnSeleccionarImagen.Text = "Subir";
            this.btnSeleccionarImagen.TextColor = System.Drawing.Color.White;
            this.btnSeleccionarImagen.UseVisualStyleBackColor = false;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // FrmDatosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1072, 573);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDatosInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosInventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog pbImagen;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private RoundedButton btnCancelar;
        private RoundedButton btnGuardar;
        private RoundedButton btnSeleccionarImagen;
    }
}