namespace Produtos_Agrícolas.Telas
{
    public partial class Venda : Form
    {
        public static Venda venda = new Venda();

        public Venda()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro.cadastro.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Estoque.estoque.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Você já está na tela de venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Venda_VisibleChanged(object sender, EventArgs e)
        {
            venda.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
             );
        }
    }
}
