namespace pryRomanisioSP1EPR
{
    partial class frmConsultaVendedor
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
            this.dgvConsultaVendedor = new System.Windows.Forms.DataGridView();
            this.VendedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CobraComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaVendedor
            // 
            this.dgvConsultaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VendedorID,
            this.NombreVendedor,
            this.Activo,
            this.CobraComision});
            this.dgvConsultaVendedor.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaVendedor.Name = "dgvConsultaVendedor";
            this.dgvConsultaVendedor.Size = new System.Drawing.Size(445, 344);
            this.dgvConsultaVendedor.TabIndex = 0;
            // 
            // VendedorID
            // 
            this.VendedorID.HeaderText = "ID Vendedor";
            this.VendedorID.Name = "VendedorID";
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.HeaderText = "Nombre Vendedor";
            this.NombreVendedor.Name = "NombreVendedor";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // CobraComision
            // 
            this.CobraComision.HeaderText = "CobraComision";
            this.CobraComision.Name = "CobraComision";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(360, 357);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 392);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultaVendedor);
            this.Name = "frmConsultaVendedor";
            this.Text = "Consulta Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CobraComision;
        private System.Windows.Forms.Button btnConsultar;
    }
}