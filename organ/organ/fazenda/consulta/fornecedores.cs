﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class fornecedores : UserControl
    {
        public fornecedores()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (novo_fornecedor _novo_fornecedor = new novo_fornecedor())
            {
                _novo_fornecedor.ShowDialog(this);
            }
        }
    }
}
