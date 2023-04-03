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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = Nivel.Listar();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInserirNivel_Click(object sender, EventArgs e)
        {
            Nivel n = new Nivel(txtNomeNivel.Text, txtSigla.Text);
            n.Inserir();
            //CarregaComboNivel();
        }

        private void btnConsultarNivel_Click(object sender, EventArgs e)
        {
            Nivel n = Nivel.ObterPorId(Convert.ToInt32(txtIdNivel.Text));
            if (n != null)
            {
                txtNomeNivel.Text = n.Nome;
                txtSigla.Text = n.Sigla;
            }
            else
            {
                MessageBox.Show("Nível não localizado!");
                txtSigla.Clear();
                txtNomeNivel.Clear();

            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
