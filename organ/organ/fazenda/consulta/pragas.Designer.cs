﻿namespace organ
{
    partial class pragas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPragas = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPragas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPragas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPragas, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1384, 66);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // lblPragas
            // 
            this.lblPragas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPragas.AutoSize = true;
            this.lblPragas.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblPragas.Location = new System.Drawing.Point(584, 20);
            this.lblPragas.Name = "lblPragas";
            this.lblPragas.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.lblPragas.Size = new System.Drawing.Size(137, 34);
            this.lblPragas.TabIndex = 6;
            this.lblPragas.Text = "Pragas";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnVoltar.Image = global::organ.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(23, 23);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVoltar.Size = new System.Drawing.Size(106, 30);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "   Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnAdd.Image = global::organ.Properties.Resources.soma;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1176, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(204, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "  Adicionar novo";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvPragas
            // 
            this.dgvPragas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPragas.Location = new System.Drawing.Point(32, 100);
            this.dgvPragas.Name = "dgvPragas";
            this.dgvPragas.Size = new System.Drawing.Size(1321, 575);
            this.dgvPragas.TabIndex = 39;
            // 
            // pragas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPragas);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "pragas";
            this.Size = new System.Drawing.Size(1384, 774);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPragas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPragas;
        private System.Windows.Forms.DataGridView dgvPragas;
    }
}