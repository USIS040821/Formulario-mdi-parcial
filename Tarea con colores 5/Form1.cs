﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_con_colores_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void computadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Computadoras = new Form2 ();
            Computadoras.Show();
        }

      

        private void laptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form laptops = new Form3();
            laptops.Show();

        }
    }
}
