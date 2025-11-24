using System;

namespace ProyectoEquipo3
{
    partial class FrmDatosPresupuestos
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
            this.CmbIdMueble = new System.Windows.Forms.ComboBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.TxtCostoMaterial = new System.Windows.Forms.TextBox();
            this.TxtCostoManoObra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbIdMueble
            // 
            this.CmbIdMueble.FormattingEnabled = true;
            this.CmbIdMueble.Location = new System.Drawing.Point(123, 61);
            this.CmbIdMueble.Name = "CmbIdMueble";
            this.CmbIdMueble.Size = new System.Drawing.Size(300, 33);
            this.CmbIdMueble.TabIndex = 0;
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(123, 313);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(300, 33);
            this.CmbEstado.TabIndex = 1;
            // 
            // TxtCostoMaterial
            // 
            this.TxtCostoMaterial.Location = new System.Drawing.Point(123, 139);
            this.TxtCostoMaterial.Name = "TxtCostoMaterial";
            this.TxtCostoMaterial.Size = new System.Drawing.Size(300, 30);
            this.TxtCostoMaterial.TabIndex = 2;
            // 
            // TxtCostoManoObra
            // 
            this.TxtCostoManoObra.Location = new System.Drawing.Point(123, 227);
            this.TxtCostoManoObra.Name = "TxtCostoManoObra";
            this.TxtCostoManoObra.Size = new System.Drawing.Size(300, 30);
            this.TxtCostoManoObra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(118, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del Mueble";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(118, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costo del Material";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(118, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Costo de la mano en obra";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(118, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(52, 389);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(146, 39);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(327, 389);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(146, 39);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Frm_Datos_Presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 480);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCostoManoObra);
            this.Controls.Add(this.TxtCostoMaterial);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.CmbIdMueble);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Datos_Presupuesto";
            this.Text = "FrmDatosPresupuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox CmbIdMueble;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.TextBox TxtCostoMaterial;
        private System.Windows.Forms.TextBox TxtCostoManoObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}