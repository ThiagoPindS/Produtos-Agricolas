using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Venda : Form
    {
        public static int IdAtual = 0;

        public Venda()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Registros registros = new Registros())
            {
                registros.ShowDialog();
            }
            this.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IdAtual = int.Parse(txtId.Text) - 1;

            CarregarProduto(IdAtual);
        }

        private void btnConfirmarVenda_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txtQuantidadeVenda.Text) > 0) && (int.Parse(txtQuantidadeDisponivel.Text) >= (int.Parse(txtQuantidadeVenda.Text))))
            {
                DialogResult resultado = MessageBox.Show($"Confirma a venda de {txtQuantidadeVenda.Text} {txtNome.Text} por {txtPrecoTotal.Text} ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ProdutoService.VenderProduto((IdAtual + 1), int.Parse(txtQuantidadeVenda.Text));

                    Menu.Produtos = ProdutoService.CarregarProdutos("");

                    CarregarProduto(IdAtual);
                }
            }
            else
            {
                MessageBox.Show($"A quantidade a ser vendida não poder ser menor que 0 e nem maior do que a quantidade estocada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregarProduto(int id)
        {
            txtNome.Text = Menu.Produtos[id].Nome.ToString();
            txtQuantidadeDisponivel.Text = Menu.Produtos[id].Quantidade.ToString();
            txtQuantidadeVenda.Text = "0";
            txtPreco.Text = Menu.Produtos[id].Preco.ToString("F2");
        }

        private void txtQuantidadeVenda_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidadeVenda.Text != "")
            {
                txtPrecoTotal.Text = (int.Parse(txtQuantidadeVenda.Text) * Menu.Produtos[IdAtual].Preco).ToString("F2");
            }
        }
    }
}
