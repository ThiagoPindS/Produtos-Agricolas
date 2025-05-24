namespace Produtos_Agrícolas.Classes
{
    internal class ProdutoService
    {
        public static void CadastrarProduto(Produto produto)
        {
            if (produto.Nome != "" && produto.Categoria != "" && produto.Quantidade >= 0 && produto.Preco >= 0)
            {
                BancoDeDados bancoDeDados = new BancoDeDados("C:\\Users\\Thiago\\source\\repos\\Produtos-Agrícolas\\Produtos-Agricolas-BD.db");
                bancoDeDados.ExecuteNonQuery($"INSERT INTO Produtos (Nome, Categoria, Quantidade, Preco) VALUES ('{produto.Nome}', '{produto.Categoria}', {produto.Quantidade}, '{produto.Preco}')");
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente");
            }

        }

        public static void RemoverProduto()
        { }

        public static void EditarProduto()
        { }
    }
}
