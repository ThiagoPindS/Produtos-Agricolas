using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Produtos_Agrícolas.Classes
{
    internal class VendaService
    {
        public static BancoDeDados bancoDeDados = new BancoDeDados("C:\\Users\\Thiago\\source\\repos\\Produtos-Agricolas\\Produtos-Agricolas-BD.db");

        public static void RegistrarVenda(int id, int quantidade, Venda venda)
        {
            bancoDeDados.ExecuteNonQuery($"UPDATE Produtos SET Quantidade = Quantidade - {quantidade} WHERE Id = {id}");

            bancoDeDados.ExecuteNonQuery($"INSERT INTO Vendas (ProdutoId, Nome, Data, Quantidade, PrecoUnitario, PrecoTotal) SELECT Id, '{venda.Nome}', '{DateTime.Now}', {quantidade}, '{venda.PrecoUnitario.ToString(CultureInfo.InvariantCulture)}', '{(venda.PrecoUnitario * quantidade).ToString(CultureInfo.InvariantCulture)}' FROM Produtos WHERE Id = '{id}';");
        }

        public static List<Venda> CarregarVendas()
        {
            using (var Leitor = bancoDeDados.ExecuteQuery("SELECT * FROM Vendas"))
            {
                List<Venda> VendasBD = new List<Venda>();

                while (Leitor.Read())
                {
                    VendasBD.Add(new Venda(Leitor.GetInt32(0), Leitor.GetString(2), Leitor.GetString(3), Leitor.GetInt32(4), Leitor.GetDouble(5), Leitor.GetDouble(6)));
                }

                return VendasBD;
            }
        }
    }
}
