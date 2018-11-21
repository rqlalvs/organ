﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace organ
{
    public partial class fornecedores : UserControl
    {
        public fornecedores()
        {
            InitializeComponent();
            PreencherDataGridView();
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

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT F.cod_fornecedor AS [Código], F.nome_fantasia AS [Nome fantasia], F.razao_social AS [Razão Social], " +
                                                              "F.cnpj_forn AS [CNPJ], F.tel_forn AS [Telefone], F.email_forn AS [Email], F.site_forn " + 
                                                              "AS [Site], E.rua AS [Rua], E.numero AS [Número], E.complemento AS [Complemento], E.bairro AS [Bairro], " + 
                                                              "E.cep AS [CEP], E.cidade AS[Cidade], E.uf AS [UF] FROM tbFornecedor F INNER JOIN tbEndereco E ON F.cep_forn = E.cep " +
                                                              "ORDER BY cod_fornecedor ASC; ", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvFornecedores.DataSource = dtbl;
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}
