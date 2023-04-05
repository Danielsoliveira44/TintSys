using ClassLibrary2;
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
                MessageBox.Show("Produto gravado");
            else
                MessageBox.Show("Falha ao gravar");
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
            if(btnBuscar.Text=="...")
            {
                txtId.ReadOnly= false;
                txtId.Focus();
                btnBuscar.Text = "Obter";
            }
            else if(tx)
            {
                txtId.ReadOnly= true;
            }
        }
    }
