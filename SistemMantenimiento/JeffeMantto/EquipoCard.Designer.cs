namespace SistemMantenimiento.JeffeMantto
{
    partial class EquipoCard
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
            this.pnlBorde = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTipoEquipo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.pnlBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBorde.BorderRadius = 20;
            this.pnlBorde.Controls.Add(this.lblAnio);
            this.pnlBorde.Controls.Add(this.lblFechaIngreso);
            this.pnlBorde.Controls.Add(this.lblModelo);
            this.pnlBorde.Controls.Add(this.lblMarca);
            this.pnlBorde.Controls.Add(this.lblTipoEquipo);
            this.pnlBorde.Location = new System.Drawing.Point(3, 4);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Size = new System.Drawing.Size(287, 199);
            this.pnlBorde.TabIndex = 0;
            // 
            // lblTipoEquipo
            // 
            this.lblTipoEquipo.AutoSize = true;
            this.lblTipoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTipoEquipo.Location = new System.Drawing.Point(3, 11);
            this.lblTipoEquipo.Name = "lblTipoEquipo";
            this.lblTipoEquipo.Size = new System.Drawing.Size(50, 16);
            this.lblTipoEquipo.TabIndex = 0;
            this.lblTipoEquipo.Text = "label1";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(3, 75);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 16);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "label1";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(177, 75);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(50, 16);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "label1";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFechaIngreso.Location = new System.Drawing.Point(3, 120);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(50, 16);
            this.lblFechaIngreso.TabIndex = 3;
            this.lblFechaIngreso.Text = "label1";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAnio.Location = new System.Drawing.Point(3, 163);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(50, 16);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "label1";
            // 
            // EquipoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBorde);
            this.Name = "EquipoCard";
            this.Size = new System.Drawing.Size(293, 206);
            this.pnlBorde.ResumeLayout(false);
            this.pnlBorde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBorde;
        private System.Windows.Forms.Label lblTipoEquipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblAnio;
    }
}
