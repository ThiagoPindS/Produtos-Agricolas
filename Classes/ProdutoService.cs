namespace Produtos_Agrícolas.Classes
{
    internal class ProdutoService
    {
        public static List<Produto> Produtos = new List<Produto>();

        public static void CarregarProdutos()
        {
            BancoDeDados bancoDeDados = new BancoDeDados("C:\\Users\\Thiago\\source\\repos\\Produtos-Agrícolas\\Produtos-Agricolas-BD.db");

            using (var Leitor = bancoDeDados.ExecuteQuery("SELECT Id, Nome, Categoria, Quantidade, Preco FROM Produtos"))
            {
                while (Leitor.Read())
                {
                    int id = Leitor.GetInt32(0);
                    string nome = Leitor.GetString(1);
                    string categoria = Leitor.GetString(2);
                    int quantidade = Leitor.GetInt32(3);
                    double preco = Leitor.GetDouble(4);

                    Produtos.Add(new Produto(id, nome, categoria, quantidade, preco));
                }
            }

        }

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
