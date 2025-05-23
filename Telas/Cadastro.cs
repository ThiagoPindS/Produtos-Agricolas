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
            Produto.CadastrarProduto(new Produto(txtNome.Text, txtCategoria.Text, int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text)));
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você já está na tela de cadastro");
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            Navegacao.menu.Hide();
            Navegacao.estoque.Close();
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Navegacao.menu.Show();
        }
    }
}
