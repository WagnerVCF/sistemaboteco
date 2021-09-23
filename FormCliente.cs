using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boteco
{
    public partial class FormCliente : Form
    {
        public FormCliente(){
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e){
            Botecli botecli = new Botecli();
            botecli.InserirCli(txtNome.Text, txtCPF.Text, txtDataNascimento.Text, txtCelular.Text);
            MessageBox.Show("Cliente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";

        }

        private void btnLocalizar_Click(object sender, EventArgs e){
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botecli botecli = new Botecli();
            botecli.LocalizaCli(id);
            txtNome.Text = botecli.nome;
            txtCPF.Text = botecli.cpf;
            txtDataNascimento.Text = botecli.data_nascimento;
            txtCelular.Text = botecli.celular;
        }

        private void btnAtualizar_Click(object sender, EventArgs e){
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botecli botecli = new Botecli();
            botecli.AtualizarCli(id, txtNome.Text, txtCPF.Text, txtDataNascimento.Text, txtCelular.Text);
            MessageBox.Show("Cliente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e){
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botecli botecli = new Botecli();
            botecli.ExcluirCli(id);
            MessageBox.Show("Cliente apagado com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Pegarid = dgvCliente.CurrentCell.RowIndex;
            var Pegarid2 = dgvCliente.Rows[Pegarid].Cells[0].Value.ToString();
            int id = Convert.ToInt32(Pegarid2);
            Botecli botecli = new Botecli();
            botecli.LocalizaCli(id);
            txtId.Text = Convert.ToString(id);
            txtNome.Text = botecli.nome;
            txtCPF.Text = botecli.cpf;
            txtDataNascimento.Text = botecli.data_nascimento;
            txtCelular.Text = botecli.celular;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Botecli botecli = new Botecli();
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
        }
    }
}
