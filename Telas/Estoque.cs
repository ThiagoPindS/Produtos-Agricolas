using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            ProdutoService.CarregarProdutos();

            AtualizarDataGridView();
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow != null)
            {
                this.Hide();
                using (Cadastro cadastro = new Cadastro())
                {
                    Cadastro.IsEdicao = true;

                    Menu.CurrentId = int.Parse(dgvEstoque.CurrentRow.Cells[0].Value.ToString());

                    cadastro.txtNome.Text = dgvEstoque.CurrentRow.Cells[1].Value.ToString();
                    cadastro.cmbCategoria.Text = dgvEstoque.CurrentRow.Cells[2].Value.ToString();
                    cadastro.txtQuantidade.Text = dgvEstoque.CurrentRow.Cells[3].Value.ToString();
                    cadastro.txtPreco.Text = dgvEstoque.CurrentRow.Cells[4].Value.ToString();

                    cadastro.ShowDialog();

                    Cadastro.IsEdicao = false;
                }

                ProdutoService.CarregarProdutos();

                AtualizarDataGridView();

                this.Show();
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow != null)
            {
                this.Hide();
                using (Venda venda = new Venda())
                {
                    venda.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AtualizarDataGridView()
        {
            dgvEstoque.DataSource = "null";

            dgvEstoque.DataSource = ProdutoService.Produtos;
        }
    }
}

