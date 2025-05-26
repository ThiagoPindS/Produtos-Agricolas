using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
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

        private void legumesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoService.FiltrarProduto("Legume");

            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            dgvEstoque.DataSource = "null";

            dgvEstoque.DataSource = ProdutoService.Produtos;
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

