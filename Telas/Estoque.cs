using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Cadastro cadastro = new Cadastro())
            {
                cadastro.ShowDialog();
            }
            this.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você já está na tela de estoque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Estoque_Load(object sender, EventArgs e)
        {
            ProdutoService.CarregarProdutos();
            
            AtualizarDataGridView();
        }

        private void frutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoService.FiltrarProduto("Fruta");

            AtualizarDataGridView();
        }

        private void grãosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoService.FiltrarProduto("Grão");

            AtualizarDataGridView();
        }

        private void hortaliçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoService.FiltrarProduto("Hortaliça");

            AtualizarDataGridView();
        }

        private void vegetaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoService.FiltrarProduto("Vegetal");

            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            dgvEstoque.DataSource = "null";

            dgvEstoque.DataSource = ProdutoService.Produtos;
        }
    }
}

