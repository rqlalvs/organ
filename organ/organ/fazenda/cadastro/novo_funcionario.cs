﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class novo_funcionario : Form
    {
        string connectionString = @"Data Source=LAB2PC12\SA;Initial Catalog=dbOrgan;Persist Security Info=True;User ID=sa;Password=1234567";
        bool novo;

        public novo_funcionario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string sql = "alter table tbFuncionario nocheck constraint FK_tbFuncionario_tbEndereco;"+" alter table tbFuncionario nocheck constraint FK_tbFuncionario_tbUsuario;" + "alter table tbFuncionario alter column cod_usuario int null;" + " INSERT INTO tbFuncionario (cod_funcionario, nome_func, cpf_func, rg_func, idade_func, tel_func, cel_func, email_func, cargo_func, salario_func, numcasa_func, cep_func) " + "VALUES (" + txtCodigo.Text + ", '" + txtNome.Text + "', " + txtCPF.Text + ", " + txtRG.Text + ", " + txtIdade.Text + ", " + txtTelefone.Text + ", " + txtCelular.Text + ", '" + txtEmail.Text + "', '" + txtCargo.Text + "', " + txtSalario.Text + ", " + txtNumCasa.Text + ", " + txtCEP.Text + ")";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
