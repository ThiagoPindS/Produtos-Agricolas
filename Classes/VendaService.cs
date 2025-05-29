using System.Collections.Generic;
using System.Globalization;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace Produtos_Agrícolas.Classes
{
    internal class VendaService
    {
        public static BancoDeDados bancoDeDados = new BancoDeDados("C:\\Users\\Thiago\\source\\repos\\Produtos-Agricolas\\Produtos-Agricolas-BD.db");

        public static void RegistrarVenda(int id, int quantidade, Venda venda)
        {
            bancoDeDados.ExecuteNonQuery($"UPDATE Produtos SET Quantidade = Quantidade - {quantidade} WHERE Id = {id}");

            bancoDeDados.ExecuteNonQuery($"INSERT INTO Vendas (ProdutoId, Data, Quantidade, PrecoUnitario, PrecoTotal) SELECT Id, {DateTime.Now}, {venda.Nome}, {venda.Quantidade}, {venda.PrecoUnitario.ToString(CultureInfo.InvariantCulture)}, {venda.PrecoTotal.ToString(CultureInfo.InvariantCulture)} FROM Produtos WHERE Id = 1;\r\n");
        }

        //public static List<Venda> CarregarVendas(Venda venda)
        //{ }
    }
}
