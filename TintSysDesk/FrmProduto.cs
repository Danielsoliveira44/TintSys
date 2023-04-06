﻿using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TintSysDesk
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                txtDescricao.Text,
                cmdUnidade.Text,
                txtCodBar.Text,
                double.Parse(txtPreco.Text),
                double.Parse(txtDesconto.Text)
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                txtId.Text = produto.Id.ToString();
                CarregaGrid();
                MessageBox.Show("Produto gravado com sucesso!");

            }
            else
                MessageBox.Show("Falha ao gravar o Produto!1");
        }
        private void CarregaGrid(string texto="")
        {
            List<Produto> lista = null;
            if(texto!=string.Empty)               
                lista = Produto.Listar(texto);
            else
                lista = Produto.Listar();
            int cont = 0;
            dgvLista.Rows.Clear();
            foreach (Produto item in lista)
            {
                dgvLista.Rows.Add();
                dgvLista.Rows[cont].Cells[0].Value = item.Id;
                dgvLista.Rows[cont].Cells[1].Value = item.Descricao;
                dgvLista.Rows[cont].Cells[2].Value = item.Unidade;
                dgvLista.Rows[cont].Cells[3].Value = item.CodBar;
                dgvLista.Rows[cont].Cells[4].Value = item.Preco.ToString("R$ ##0.00");
                dgvLista.Rows[cont].Cells[5].Value = item.Desconto.ToString("#.##%");
                dgvLista.Rows[cont].Cells[6].Value = item.Descontinuado;
                cont++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Produto.Listar();
            int cont = 0;
            dgvLista.Rows.Clear();
            foreach (Produto item in lista)
            {
                dgvLista.Rows.Add(item);
                dgvLista.Rows[cont].Cells[0].Value = item.Id;
                dgvLista.Rows[cont].Cells[1].Value = item.Descricao;
                dgvLista.Rows[cont].Cells[2].Value = item.Unidade;
                dgvLista.Rows[cont].Cells[3].Value = item.CodBar;
                dgvLista.Rows[cont].Cells[4].Value = item.Preco.ToString("R$ ##0.00");
                dgvLista.Rows[cont].Cells[5].Value = item.Desconto.ToString("#.##%");
                dgvLista.Rows[cont].Cells[6].Value = item.Descontinuado;

                cont++;
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "Obter";
            }
            else if (txtId.Text != String.Empty)
            {
                txtId.ReadOnly = true;
                btnBuscar.Text = "...";
                var produto = Produto.ObterPorId(int.Parse(txtId.Text));
                txtDescricao.Text = produto.Descricao;
                txtDesconto.Text = produto.Desconto.ToString();
                txtPreco.Text = produto.Preco.ToString();
                txtCodBar.Text = produto.CodBar;
                cmdUnidade.Text = produto.Unidade;
                chkDescontinuado.Checked = produto.Descontinuado.();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                
               txtDescricao.Text,
               cmdUnidade.Text,
               txtCodBar.Text,
               double.Parse(txtPreco.Text),
               double.Parse(txtDesconto.Text),
               chkDescontinuado.Checked
               );
            produto.Atualizar();
            CarregaGrid();
        }

        private void chkDescontinuado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescontinuado.Checked)
                Produto.Arquivar(int.Parse(txtId));
            else
                Produto.Restaurar(int.Parse(txtId));
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text.Length > 1) 
            {
                CarregaGrid(txtPesquisar.Text);
            }
        }

        
    }
}