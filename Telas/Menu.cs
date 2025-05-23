namespace Produtos_Agrícolas.Telas
{
    public partial class Menu : Form
    {
        public static Menu menu = new Menu();

        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro.cadastro.ShowDialog();

            if (Cadastro.cadastro.Visible == false && Estoque.estoque.Visible == false && Venda.venda.Visible == false)
            {
                this.Show();
            }
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estoque.estoque.ShowDialog();
            
            if (Cadastro.cadastro.Visible == false && Estoque.estoque.Visible == false && Venda.venda.Visible == false)
            {
                this.Show();
            }
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venda.venda.ShowDialog();

            if (Cadastro.cadastro.Visible == false && Estoque.estoque.Visible == false && Venda.venda.Visible == false)
            {
                this.Show();
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

        private void Menu_VisibleChanged(object sender, EventArgs e)
        {
            menu.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
             );
        }
    }
}
