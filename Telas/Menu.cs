namespace Produtos_Agrícolas.Telas
{
    public partial class Menu : Form
    {

        public Menu()
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
            this.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
