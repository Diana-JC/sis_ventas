﻿using System;
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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cb_estado.Items.Add("Nuevo");
            cb_estado.Items.Add("Usado");
            cb_estado.Items.Add("Muy Usado");
            cb_estado.Items.Add("Casi Nuevo");

        }
        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
