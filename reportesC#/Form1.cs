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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var producto = new Producto
                {
                    
                    Descripcion = txbDESCRIPCION.Text,
                    Categoria = txbCATEGORIA.Text,
                    Cantidad = int.Parse(txbCANTIDAD.Text),
                    Precio_Unitario = decimal.Parse(txbPRECIO_UNITARIO.Text),
                    Descuento = decimal.Parse(txbDESCUENTO.Text)
                };

                db.Productos.Add(producto);  
                db.SaveChanges();  
                MessageBox.Show("Producto creado correctamente.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                int id = int.Parse(txbID.Text);  
                var producto = db.Productos.Find(id);  

                if (producto != null)
                {
                    
                    producto.Descripcion = txbDESCRIPCION.Text;
                    producto.Categoria = txbCATEGORIA.Text;
                    producto.Cantidad = int.Parse(txbCANTIDAD.Text);
                    producto.Precio_Unitario = decimal.Parse(txbPRECIO_UNITARIO.Text);
                    producto.Descuento = decimal.Parse(txbDESCUENTO.Text);

                    db.SaveChanges();  
                    MessageBox.Show("Producto actualizado.");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                int id = int.Parse(txbID.Text);  
                var producto = db.Productos.Find(id);

                if (producto != null)
                {
                    db.Productos.Remove(producto);
                    db.SaveChanges();
                    MessageBox.Show("Producto eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(); 
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
