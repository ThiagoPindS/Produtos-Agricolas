using System.Globalization;

namespace Produtos_Agrícolas.Classes
{
    internal class ProdutoService
    {
        public static BancoDeDados bancoDeDados = new BancoDeDados("C:\\Users\\Thiago\\source\\repos\\Produtos-Agrícolas\\Produtos-Agricolas-BD.db");

        public static List<Produto> CarregarProdutos(string filtro)
        {
            if (filtro != "")
            {
                filtro = $" WHERE Categoria = '{filtro}'";
            }

            using (var Leitor = bancoDeDados.ExecuteQuery("SELECT * FROM Produtos" + filtro))
            {
                List<Produto> ProdutosBD = new List<Produto>();

                while (Leitor.Read())
                {
                    ProdutosBD.Add(new Produto(Leitor.GetInt32(0), Leitor.GetString(1), Leitor.GetString(2), Leitor.GetInt32(3), Leitor.GetDouble(4)));
                }

                return ProdutosBD;
            }
        }

        public static void CadastrarProduto(Produto produto)
        {
            bancoDeDados.ExecuteNonQuery($"INSERT INTO Produtos (Nome, Categoria, Quantidade, Preco) VALUES ('{produto.Nome}', '{produto.Categoria}', {produto.Quantidade}, '{produto.Preco.ToString(CultureInfo.InvariantCulture)}')");
        }

        public static void EditarProduto(Produto produto, int id)
        {
            bancoDeDados.ExecuteNonQuery($"UPDATE Produtos SET Nome = '{produto.Nome}', Categoria = '{produto.Categoria}', Quantidade = {produto.Quantidade}, Preco = {produto.Preco.ToString(CultureInfo.InvariantCulture)} WHERE Id = {id}");
        }

        public static void VenderProduto(int id, int quantidade)
        {
            bancoDeDados.ExecuteNonQuery($"UPDATE Produtos SET Quantidade = {quantidade} WHERE Id = {id}");
        }
    }
}
