using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Cadastro : Form
    {
        static public bool IsEdicao = false;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && cmbCategoria.Text != "" && txtQuantidade.Text != "" && txtPreco.Text != "")
            {
                if (IsEdicao == false)
                {
                    ProdutoService.CadastrarProduto(new Produto(txtNome.Text, cmbCategoria.Text, int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text)));

                    MessageBox.Show("Produto cadastro com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                }
                else
                {
                    ProdutoService.EditarProduto(new Produto(txtNome.Text, cmbCategoria.Text, int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text)), Estoque.IdAtual);

                    MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    IsEdicao = false;

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtPreco.Text = "0";
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
