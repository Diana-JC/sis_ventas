using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            Form formulario = new Cliente();
            formulario.Show();
        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            Form formulario = new Factura();
            formulario.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Form formulario = new Categoria();
            formulario.Show();
        }

        private void btndetalle_factura_Click(object sender, EventArgs e)
        {
            Form formulario = new Detalle_Factura();
            formulario.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Inventario();
            formulario.Show();
        }
    }
}
