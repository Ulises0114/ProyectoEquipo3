namespace ProyectoEquipo3
{
    partial class FrmNotificaciones
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
            this.btnProgramarNotificacion = new System.Windows.Forms.Button();
            this.btnRefrescarNotificaciones = new System.Windows.Forms.Button();
            this.panelSistemaContainer = new System.Windows.Forms.Panel();
            this.flpNotificacionesSistema = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.timerAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpProgramadas = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProgramadas = new System.Windows.Forms.DataGridView();
            this.lblBadgeCount = new System.Windows.Forms.Label();
            this.panelSistemaContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramadas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProgramarNotificacion
            // 
            this.btnProgramarNotificacion.BackColor = System.Drawing.Color.Green;
            this.btnProgramarNotificacion.Location = new System.Drawing.Point(1396, 35);
            this.btnProgramarNotificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProgramarNotificacion.Name = "btnProgramarNotificacion";
            this.btnProgramarNotificacion.Size = new System.Drawing.Size(363, 138);
            this.btnProgramarNotificacion.TabIndex = 0;
            this.btnProgramarNotificacion.Text = "+ Programar notificación";
            this.btnProgramarNotificacion.UseVisualStyleBackColor = false;
            this.btnProgramarNotificacion.Click += new System.EventHandler(this.btnProgramarNotificacion_Click_1);
            // 
            // btnRefrescarNotificaciones
            // 
            this.btnRefrescarNotificaciones.Location = new System.Drawing.Point(1171, 49);
            this.btnRefrescarNotificaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarNotificaciones.Name = "btnRefrescarNotificaciones";
            this.btnRefrescarNotificaciones.Size = new System.Drawing.Size(97, 101);
            this.btnRefrescarNotificaciones.TabIndex = 1;
            this.btnRefrescarNotificaciones.Text = "refresh";
            this.btnRefrescarNotificaciones.UseVisualStyleBackColor = true;
            // 
            // panelSistemaContainer
            // 
            this.panelSistemaContainer.Controls.Add(this.flpNotificacionesSistema);
            this.panelSistemaContainer.Controls.Add(this.lblTituloSistema);
            this.panelSistemaContainer.Location = new System.Drawing.Point(274, 216);
            this.panelSistemaContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSistemaContainer.Name = "panelSistemaContainer";
            this.panelSistemaContainer.Size = new System.Drawing.Size(608, 866);
            this.panelSistemaContainer.TabIndex = 2;
            // 
            // flpNotificacionesSistema
            // 
            this.flpNotificacionesSistema.AutoScroll = true;
            this.flpNotificacionesSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNotificacionesSistema.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNotificacionesSistema.Location = new System.Drawing.Point(0, 29);
            this.flpNotificacionesSistema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpNotificacionesSistema.Name = "flpNotificacionesSistema";
            this.flpNotificacionesSistema.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.flpNotificacionesSistema.Size = new System.Drawing.Size(608, 837);
            this.flpNotificacionesSistema.TabIndex = 1;
            this.flpNotificacionesSistema.WrapContents = false;
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSistema.Location = new System.Drawing.Point(0, 0);
            this.lblTituloSistema.Name = "lblTituloSistema";
            this.lblTituloSistema.Size = new System.Drawing.Size(294, 29);
            this.lblTituloSistema.TabIndex = 0;
            this.lblTituloSistema.Text = "Notificaciones del sistema";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpProgramadas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(889, 216);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 866);
            this.panel1.TabIndex = 3;
            // 
            // flpProgramadas
            // 
            this.flpProgramadas.AutoScroll = true;
            this.flpProgramadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProgramadas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProgramadas.Location = new System.Drawing.Point(0, 29);
            this.flpProgramadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpProgramadas.Name = "flpProgramadas";
            this.flpProgramadas.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.flpProgramadas.Size = new System.Drawing.Size(608, 837);
            this.flpProgramadas.TabIndex = 1;
            this.flpProgramadas.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificaciones programadas";
            // 
            // dgvProgramadas
            // 
            this.dgvProgramadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramadas.Location = new System.Drawing.Point(942, 92);
            this.dgvProgramadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProgramadas.Name = "dgvProgramadas";
            this.dgvProgramadas.RowHeadersWidth = 51;
            this.dgvProgramadas.RowTemplate.Height = 24;
            this.dgvProgramadas.Size = new System.Drawing.Size(71, 38);
            this.dgvProgramadas.TabIndex = 3;
            this.dgvProgramadas.Visible = false;
            // 
            // lblBadgeCount
            // 
            this.lblBadgeCount.AutoSize = true;
            this.lblBadgeCount.Location = new System.Drawing.Point(1837, 110);
            this.lblBadgeCount.Name = "lblBadgeCount";
            this.lblBadgeCount.Size = new System.Drawing.Size(51, 20);
            this.lblBadgeCount.TabIndex = 3;
            this.lblBadgeCount.Text = "label1";
            this.lblBadgeCount.Visible = false;
            // 
            // FrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 1142);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProgramadas);
            this.Controls.Add(this.lblBadgeCount);
            this.Controls.Add(this.panelSistemaContainer);
            this.Controls.Add(this.btnRefrescarNotificaciones);
            this.Controls.Add(this.btnProgramarNotificacion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNotificaciones";
            this.Text = "FrmNotificaciones";
            this.panelSistemaContainer.ResumeLayout(false);
            this.panelSistemaContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProgramarNotificacion;
        private System.Windows.Forms.Button btnRefrescarNotificaciones;
        private System.Windows.Forms.Panel panelSistemaContainer;
        private System.Windows.Forms.FlowLayoutPanel flpNotificacionesSistema;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Timer timerAutoRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpProgramadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProgramadas;
        private System.Windows.Forms.Label lblBadgeCount;
    }
}