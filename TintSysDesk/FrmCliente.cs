using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;

namespace TintSysDesk
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void Cpf_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente n = new Cliente(txtNome.Text, txtCpf.Text, txtEmail, txtCadastro, );
            n.Inserir();
            //CarregaComboNivel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Cliente> lista = Cliente.Listar();
            int linha = 0;
            dgvCliente.Rows.Clear();
            foreach (Usuario iten in lista)
            {
                dgvCliente.Rows.Add();
                //dgvCliente.Rows[linha].Cells[0].Value = iten.Id.ToString();
                dgvCliente.Rows[linha].Cells[0].Value = iten.Nome_Cli;
                dgvCliente.Rows[linha].Cells[1].Value = iten.Cpf;
                dgvCliente.Rows[linha].Cells[2].Value = iten.Email;
                dgvCliente.Rows[linha].Cells[3].Value = iten.Ativo;
                linha++;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
