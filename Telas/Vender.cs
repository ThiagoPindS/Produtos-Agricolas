using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Vender : Form
    {
        static public int IdAtual = Estoque.IdAtual - 1;

        private List<Produto> Produtos = new List<Produto>();

        public Vender()
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
                    VendaService.RegistrarVenda((IdAtual + 1), int.Parse(txtQuantidadeVenda.Text), new Venda(txtNome.Text, int.Parse(txtQuantidadeVenda.Text), double.Parse(txtPreco.Text), double.Parse(txtPrecoTotal.Text)));

                    CarregarDados("");

                    CarregarProduto(IdAtual);

                    MessageBox.Show("Venda realizada com sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"A quantidade a ser vendida não poder ser menor que 0 e nem maior do que a quantidade estocada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtQuantidadeVenda_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidadeVenda.Text != "")
            {
                txtPrecoTotal.Text = (int.Parse(txtQuantidadeVenda.Text) * Estoque.Produtos[IdAtual].Preco).ToString("F2");
            }
        }

        private void CarregarProduto(int id)
        {
            txtNome.Text = Produtos[id].Nome.ToString();
            txtQuantidadeDisponivel.Text = Produtos[id].Quantidade.ToString();
            txtQuantidadeVenda.Text = "0";
            txtPreco.Text = Produtos[id].Preco.ToString("F2");
        }

        private void CarregarDados(string filtro)
        {
            Produtos = ProdutoService.CarregarProdutos(filtro);
        }
    }
}
