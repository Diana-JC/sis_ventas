using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        #region "Variables"
        int esta_guardada = 0;
        int n_codigo = 0;
        #endregion

        #region "Mis Metodos"
        private void Formato_categoria()

        {
            dgv_categoria.Columns[0].Width = 80;
            dgv_categoria.Columns[0].HeaderText = "id_categoria";
            dgv_categoria.Columns[1].Width = 150;
            dgv_categoria.Columns[1].HeaderText = "CATEGORIA";
            dgv_categoria.Columns[2].Width = 150;
            dgv_categoria.Columns[2].HeaderText = "PRODUCTO";
        }
        private void listar_categoria(string valor)
        {

            try
            {
                dgv_categoria.DataSource = N_Categoria.listar_categoria(valor);
                this.Formato_categoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }


        }

        private void Estado(bool estado)
        {
            txt_buscar.Enabled = estado;
            btn_guardar.Enabled = estado;
            btn_nuevo.Enabled = !estado;
            btn_modificar.Enabled = !estado;
            btn_eliminar.Enabled = !estado;
            btn_reporte.Enabled = !estado;
            btn_salir.Enabled = !estado;
            btn_buscar.Enabled = !estado;
            dgv_categoria.Enabled = estado;
        }


        #endregion
        private void Categoria_Load(object sender, EventArgs e)
        {
            this.listar_categoria("%");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_buscar.Text))
            {
                MessageBox.Show("Este cmapo no puede estar vacio", "Aviso del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string respuesta = "";
                E_Categoria categorias = new E_Categoria();
                categorias.id_categoria = n_codigo;
                categorias.nombre = txt_nombre.Text.Trim();
                categorias.producto = txt_producto.Text.Trim();
                respuesta = N_Categoria.Guardar_categoria(esta_guardada, categorias);
                if (respuesta == "Ok")
                {
                    MessageBox.Show("Datos guardados correctamente.", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.listar_categoria("%");
                 
                    esta_guardada = 0;
                    n_codigo = 0;
                    txt_nombre.Text = "";
                    txt_producto.Text = "";
                    {
                        MessageBox.Show(respuesta, "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

           
        }
            
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            esta_guardada = 1;
            this.Estado(false);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}