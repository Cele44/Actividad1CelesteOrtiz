﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computadora.Vista.Computadora.Vistas
{
    public partial class ComputadoraListarVista : Form
    {
        public ComputadoraListarVista()
        {
            InitializeComponent();
        }
        
        private void ComputadoraListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputadoraBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComputadoraInsertarVista fr = new ComputadoraInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();

                // Refrescar la vista del DataGridView OPCIONAL-----
                dataGridView1.Refresh();
            }
        }

        
    }
}


