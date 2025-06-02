using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Cadastro : Form
    {
        private List<Produto> Produtos = new List<Produto>();

        static public bool IsEdicao = false;

        public Cadastro()
        {
            InitializeComponent();

            CarregarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && cmbCategoria.Text != "" && txtQuantidade.Text != "" && txtPreco.Text != "")
            {
                if (IsEdicao)
                {
                    ProdutoService.EditarProduto(new Produto(txtNome.Text.ToUpper(), cmbCategoria.Text.ToUpper(), int.Parse(txtQuantidade.Text.Trim()), double.Parse(txtPreco.Text.Trim())), Estoque.IdAtual);

                    MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    IsEdicao = false;

                    this.Close();
                }
                else
                {
                    bool IsNovo = true;

                    foreach (Produto produto in Produtos)
                    {
                        if (txtNome.Text.ToUpper() == produto.Nome)
                        {
                            MessageBox.Show($"Já existe um produto com esse nome cadastrado, ID: {produto.Id}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            IsNovo = false;

                            break;
                        }
                    }

                    if (IsNovo == true)
                    {
                        ProdutoService.CadastrarProduto(new Produto(txtNome.Text.ToUpper(), cmbCategoria.Text.ToUpper(), int.Parse(txtQuantidade.Text.Trim()), double.Parse(txtPreco.Text.Trim())));

                        MessageBox.Show("Produto cadastro com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregarProdutos();

                        LimparCampos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LimparCampos()
        {
            txtNome.Text = "";
            cmbCategoria.Text = "";
            txtQuantidade.Text = "0";
            txtPreco.Text = "0,00";
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PressionarApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;

                MessageBox.Show("Digite apenas números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarProdutos()
        {
            Produtos = ProdutoService.CarregarProdutos("");
        }
    }
}
