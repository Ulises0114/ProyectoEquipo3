namespace ProyectoEquipo3
{
    partial class Frm_Presupuesto
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
            this.DgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.TxtBuscarPresupuesto = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPresupuesto
            // 
            this.DgvPresupuesto.AllowUserToAddRows = false;
            this.DgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPresupuesto.Location = new System.Drawing.Point(48, 148);
            this.DgvPresupuesto.Name = "DgvPresupuesto";
            this.DgvPresupuesto.ReadOnly = true;
            this.DgvPresupuesto.RowHeadersWidth = 51;
            this.DgvPresupuesto.RowTemplate.Height = 24;
            this.DgvPresupuesto.Size = new System.Drawing.Size(895, 385);
            this.DgvPresupuesto.TabIndex = 0;
            this.DgvPresupuesto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPresupuesto_CellClick);
            // 
            // TxtBuscarPresupuesto
            // 
            this.TxtBuscarPresupuesto.Location = new System.Drawing.Point(48, 94);
            this.TxtBuscarPresupuesto.Name = "TxtBuscarPresupuesto";
            this.TxtBuscarPresupuesto.Size = new System.Drawing.Size(577, 26);
            this.TxtBuscarPresupuesto.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(388, 27);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(104, 35);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(570, 27);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(104, 35);
            this.BtnFiltrar.TabIndex = 3;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRESUPUESTO";
            // 
            // Frm_Presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBuscarPresupuesto);
            this.Controls.Add(this.DgvPresupuesto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Presupuesto";
            this.Text = "Frm_Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPresupuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPresupuesto;
        private System.Windows.Forms.TextBox TxtBuscarPresupuesto;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label1;
    }
}