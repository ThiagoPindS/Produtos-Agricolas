using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Estoque : Form
    {
        public static Estoque estoque = new Estoque();

        public Estoque()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro.cadastro.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você já está na tela de estoque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venda.venda.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Estoque_VisibleChanged(object sender, EventArgs e)
        {
            estoque.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
             );
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            ProdutoService.CarregarProdutos();

            dgvEstoque.DataSource = ProdutoService.Produtos;
        }
    }
}

