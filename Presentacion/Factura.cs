using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;
using Negocio;
namespace Presentacion
{
    public partial class Factura : Form
    {
        private TextBox txtCantidad;
        private TextBox txtDescripcion;
        private TextBox txtTotal;
        private TextBox txtItbis;
        private TextBox txtPrecio;
        private TextBox txtCodigoProducto;
        private TextBox txtProducto;
        private TextBox txtNombreCliente;
        private TextBox txtNumIdentidad;
        private TextBox txtRNC;
        private ComboBox cbxEstado;
        private Button btnSaveFactura;
        private DataGridView dgvFacturas;
        private D_Factura D_factura = new D_Factura();

        public Factura()
        {
            InitializeComponent();
        }

        private void InitializeComponents()
        {
            // Initialize controls
            txt_cantidad = new TextBox { Top = 10, Left = 10, Width = 200, Text = "Cantidad" };
            txt_descrip = new TextBox { Top = 40, Left = 10, Width = 200, Text = "Descripción" };
            txt_total = new TextBox { Top = 70, Left = 10, Width = 200, Text = "Total" };
            txt_itbis = new TextBox { Top = 100, Left = 10, Width = 200, Text = "ITBIS" };
            txt_precio = new TextBox { Top = 130, Left = 10, Width = 200, Text = "Precio" };
            txt_codigo = new TextBox { Top = 160, Left = 10, Width = 200, Text = "Código Producto" };
            txt_producto = new TextBox { Top = 190, Left = 10, Width = 200, Text = "Producto" };
            txt_nom_cliente = new TextBox { Top = 220, Left = 10, Width = 200, Text = "Nombre Cliente" };
            txt_num_identidad = new TextBox { Top = 250, Left = 10, Width = 200, Text = "Número Identidad" };
            txt_rnc = new TextBox { Top = 280, Left = 10, Width = 200, Text = "RNC" };
            cbx_estado = new ComboBox { Top = 310, Left = 10, Width = 200, Text = "Estado" };
            btn_guardar = new Button { Text = "Guardar Factura", Top = 340, Left = 10 };
            dgv_factura = new DataGridView { Top = 370, Left = 10, Width = 500, Height = 200 };

            btn_guardar.Click += btn_guardar_Click;

            // Add controls to the form
            Controls.Add(txt_cantidad);
            Controls.Add(txt_descrip);
            Controls.Add(txt_total);
            Controls.Add(txt_itbis);
            Controls.Add(txt_precio);
            Controls.Add(txt_codigo);
            Controls.Add(txt_producto);
            Controls.Add(txt_nom_cliente);
            Controls.Add(txt_num_identidad);
            Controls.Add(txt_rnc);
            Controls.Add(cbx_estado);
            Controls.Add(btn_guardar);
            Controls.Add(dgv_factura);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Factura e_Factura = new E_Factura
                {
                    Cantidad = decimal.Parse(txtCantidad.Text),
                    Descripcion = txtDescripcion.Text,
                    Total = decimal.Parse(txtTotal.Text),
                    Itbis = decimal.Parse(txtItbis.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                    CodigoProducto = decimal.Parse(txtCodigoProducto.Text),
                    Producto = txtProducto.Text,
                    NombreCliente = txtNombreCliente.Text,
                    NumIdentidad = decimal.Parse(txtNumIdentidad.Text),
                    RNC = decimal.Parse(txtRNC.Text),
                    Estado = cbxEstado.Text
                };

                D_Factura.Guardar_Factura(e_Factura);
                MessageBox.Show("Factura creada exitosamente!");
                txtCantidad.Clear();
                txtDescripcion.Clear();
                txtTotal.Clear();
                txtItbis.Clear();
                txtPrecio.Clear();
                txtCodigoProducto.Clear();
                txtProducto.Clear();
                txtNombreCliente.Clear();
                txtNumIdentidad.Clear();
                txtRNC.Clear();
                cbxEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

