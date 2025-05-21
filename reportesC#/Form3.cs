using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportesC_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_FacturacionPruebasDataSet.Productoes' Puede moverla o quitarla según sea necesario.
            this.productoesTableAdapter.Fill(this.bD_FacturacionPruebasDataSet.Productoes);

            this.reportViewer1.RefreshReport();
        }
    }
}
