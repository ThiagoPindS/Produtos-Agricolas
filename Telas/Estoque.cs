using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Estoque : Form
    {
        public static List<Produto> Produtos = new List<Produto>();

        public static int IdAtual = 0;

        public Estoque()
        {
            InitializeComponent();

            AtualizarDataGridView("");
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView("");
        }

        private void frutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView("Fruta");
        }

        private void grãosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView("Grão");
        }

        private void hortaliçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView("Hortaliça");
        }

        private void legumesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView("Legume");
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow != null)
            {
                this.Hide();

                using (Cadastro cadastro = new Cadastro())
                {
                    Cadastro.IsEdicao = true;

                    IdAtual = int.Parse(dgvEstoque.CurrentRow.Cells[0].Value.ToString());

                    cadastro.txtNome.Text = dgvEstoque.CurrentRow.Cells[1].Value.ToString();
                    cadastro.cmbCategoria.Text = dgvEstoque.CurrentRow.Cells[2].Value.ToString();
                    cadastro.txtQuantidade.Text = dgvEstoque.CurrentRow.Cells[3].Value.ToString();
                    cadastro.txtPreco.Text = dgvEstoque.CurrentRow.Cells[4].Value.ToString();

                    cadastro.ShowDialog();
                }

                IdAtual = 0;

                AtualizarDataGridView("");

                this.Show();
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow != null)
            {
                this.Hide();

                using (Vender venda = new Vender())
                {
                    IdAtual = int.Parse(dgvEstoque.CurrentRow.Cells[0].Value.ToString());

                    venda.txtId.Text = dgvEstoque.CurrentRow.Cells[0].Value.ToString();
                    venda.txtNome.Text = dgvEstoque.CurrentRow.Cells[1].Value.ToString();
                    venda.txtQuantidadeDisponivel.Text = dgvEstoque.CurrentRow.Cells[3].Value.ToString();
                    venda.txtPrecoUnitario.Text = dgvEstoque.CurrentRow.Cells[4].Value.ToString();

                    venda.ShowDialog();
                }

                AtualizarDataGridView("");

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

        private void AtualizarDataGridView(string filtro)
        {
            Produtos = ProdutoService.CarregarProdutos(filtro);

            dgvEstoque.DataSource = "null";

            dgvEstoque.DataSource = Produtos;
        }
    }
}

