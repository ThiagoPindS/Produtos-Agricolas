using System.Globalization;

namespace Produtos_Agrícolas.Classes
{
    internal class VendaService
    {
        public static BancoDeDados bancoDeDados = new BancoDeDados("C:\\Users\\Thiago\\source\\repos\\Produtos-Agricolas\\Produtos-Agricolas-BD.db");

        public static void RegistrarVenda(int id, int quantidade, double precoUnitario)
        {
            bancoDeDados.ExecuteNonQuery($"UPDATE Produtos SET Quantidade = Quantidade - {quantidade} WHERE Id = {id}");

            bancoDeDados.ExecuteNonQuery($"INSERT INTO Vendas (ProdutoId, Data, Quantidade, PrecoUnitario, PrecoTotal) SELECT Id, '{DateTime.Now}', {quantidade}, '{precoUnitario.ToString(CultureInfo.InvariantCulture)}', '{(precoUnitario * quantidade).ToString(CultureInfo.InvariantCulture)}' FROM Produtos WHERE Id = '{id}'");
        }

        public static List<Venda> CarregarVendas()
        {
            using (var Leitor = bancoDeDados.ExecuteQuery("select b.Id, a.Data, b.Nome, a.PrecoUnitario, a.Quantidade, a.PrecoTotal from Vendas as a inner join Produtos as b where a.ProdutoId = b.Id"))
            {
                List<Venda> VendasBD = new List<Venda>();

                while (Leitor.Read())
                {
                    VendasBD.Add(new Venda(Leitor.GetInt32(0), Leitor.GetString(1), Leitor.GetString(2), Leitor.GetDouble(3), Leitor.GetInt32(4), Leitor.GetDouble(5)));
                }

                return VendasBD;
            }
        }
    }
}
