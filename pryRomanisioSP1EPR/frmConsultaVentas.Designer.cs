namespace pryRomanisioSP1EPR
{
    partial class frmConsultaVentas
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
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.FacturaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacturaTipo,
            this.FacturaNumero,
            this.Fecha,
            this.ClienteID,
            this.vendedorid,
            this.Monto});
            this.dgvConsultaVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.Size = new System.Drawing.Size(647, 352);
            this.dgvConsultaVentas.TabIndex = 0;
            // 
            // FacturaTipo
            // 
            this.FacturaTipo.HeaderText = "Factura Tipo";
            this.FacturaTipo.Name = "FacturaTipo";
            // 
            // FacturaNumero
            // 
            this.FacturaNumero.HeaderText = "Factura Numero";
            this.FacturaNumero.Name = "FacturaNumero";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // ClienteID
            // 
            this.ClienteID.HeaderText = "ID Cliente";
            this.ClienteID.Name = "ClienteID";
            // 
            // vendedorid
            // 
            this.vendedorid.HeaderText = "ID Vendedor";
            this.vendedorid.Name = "vendedorid";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(572, 358);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 393);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultaVentas);
            this.Name = "frmConsultaVentas";
            this.Text = "Consulta Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnConsultar;
    }
}