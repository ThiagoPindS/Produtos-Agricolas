using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Produtos_Agrícolas.Telas;

namespace Produtos_Agrícolas.Classes
{
    static internal class Navegacao
    {
        static public Menu menu = new Menu();
        static public Cadastro cadastro = new Cadastro();
        static public Estoque estoque = new Estoque();
        static public Venda venda = new Venda();
    }
}
