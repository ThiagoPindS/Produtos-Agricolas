using System.Globalization;

namespace Produtos_Agrícolas.Classes
{
    internal class ProdutoService
    {
        public static List<Produto> Produtos = new List<Produto>();

        public static BancoDeDados bancoDeDados = new BancoDeDados("C:\\Users\\Thiago\\source\\repos\\Produtos-Agrícolas\\Produtos-Agricolas-BD.db");


        public static void CarregarProdutos()
        {
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

        public static void FiltrarProduto(string filtro)
        {
            using (var Leitor = bancoDeDados.ExecuteQuery($"SELECT Id, Nome, Categoria, Quantidade, Preco FROM Produtos WHERE Categoria = '{filtro}'"))
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
                bancoDeDados.ExecuteNonQuery($"INSERT INTO Produtos (Nome, Categoria, Quantidade, Preco) VALUES ('{produto.Nome}', '{produto.Categoria}', {produto.Quantidade}, '{produto.Preco.ToString(CultureInfo.InvariantCulture)}')");

                MessageBox.Show("Produto cadastro com sucesso.");
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
