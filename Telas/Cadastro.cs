using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Cadastro : Form
    {
        public static Cadastro cadastro = new Cadastro();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoService.CadastrarProduto(new Produto(txtNome.Text, cmbCategoria.Text, int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text)));

            LimparCampos();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você já está na tela de cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Estoque estoque = new Estoque())
            {
                estoque.ShowDialog();
            }
            this.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Venda venda = new Venda())
            {
                venda.ShowDialog();
            }
            this.Show(); Venda.venda.ShowDialog();
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
    }
}
