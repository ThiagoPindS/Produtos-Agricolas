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
    }
}
