using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRomanisioSP1EPR
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamWriter swVent = new StreamWriter("./Ventas.txt", true);
            swVent.Close();
            if (File.Exists("./cliente.txt") && File.Exists("./Vendedor.txt"))
            {
                char separador = Convert.ToChar(",");
                StreamReader srClientes = new StreamReader("./cliente.txt");
                StreamReader srVendedor = new StreamReader("./Vendedor.txt");
                while (!srClientes.EndOfStream)
                {
                    string[] arrayClientes = srClientes.ReadLine().Split(separador);
                    cboCliente.Items.Add(arrayClientes[0]);
                    string[] arrayVendedor = srVendedor.ReadLine().Split(separador);
                    cboVendedor.Items.Add(arrayVendedor[0]);
                }
                srClientes.Close();
                srVendedor.Close();
            }
            else
            {
                MessageBox.Show("Los archivos no existen, carguelos");
                this.Close();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter swVentas = new StreamWriter("./Ventas.txt",true);
            swVentas.WriteLine(cboCliente.Text + "," + cboVendedor.Text + "," + dtpFecha.Text + "," + cboTipoFactura.Text + "," + nudFactura.Text + "," + nudMonto.Text);
            swVentas.Close();
            MessageBox.Show("Datos ingresados con exito");
            nudFactura.Value = 0;
            nudMonto.Value = 0;
        }
    }
}
