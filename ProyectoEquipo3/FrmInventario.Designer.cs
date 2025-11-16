namespace ProyectoEquipo3
{
    partial class FrmInventario
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
            this.components = new System.ComponentModel.Container();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.ilThumbnails = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(663, 714);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(30, 28);
            this.DtgDatos.TabIndex = 0;
            this.DtgDatos.Visible = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(1409, 719);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 47);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "reset";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(1536, 702);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(110, 64);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar Materia Prima";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lvProductos
            // 
            this.lvProductos.HideSelection = false;
            this.lvProductos.LargeImageList = this.ilThumbnails;
            this.lvProductos.Location = new System.Drawing.Point(320, 40);
            this.lvProductos.MultiSelect = false;
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(1326, 627);
            this.lvProductos.TabIndex = 4;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // ilThumbnails
            // 
            this.ilThumbnails.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilThumbnails.ImageSize = new System.Drawing.Size(16, 16);
            this.ilThumbnails.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(628, 686);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 802);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DtgDatos);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ImageList ilThumbnails;
        private System.Windows.Forms.TextBox textBox1;
    }
}