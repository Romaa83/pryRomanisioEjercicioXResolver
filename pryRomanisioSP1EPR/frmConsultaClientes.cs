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
    public partial class frmConsultaClientes : Form
    {
        string [,] matConsultaCliente = new string[100,2];

        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            dgvConsultaCliente.Rows.Clear();
            char separador = Convert.ToChar(",");
            StreamReader srConsultarCliente = new StreamReader("./cliente.txt");
            int f = 0;
            while (!srConsultarCliente.EndOfStream)
            {
                string [] arrayConsultaCliente = srConsultarCliente.ReadLine().Split(separador); 
                matConsultaCliente[f,0] = arrayConsultaCliente[0];
                matConsultaCliente[f,1] = arrayConsultaCliente[1];
                dgvConsultaCliente.Rows.Add(matConsultaCliente[f, 0], matConsultaCliente[f, 1]);
                f++;
            }
        }
    }
}
