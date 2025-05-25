using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoService.CadastrarProduto(new Produto(txtNome.Text, cmbCategoria.Text, int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text)));

            LimparCampos();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            cmbCategoria.Text = "";
            txtQuantidade.Text = "0";
            txtPreco.Text = "0";
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
