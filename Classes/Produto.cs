using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos_Agrícolas.Classes
{
    internal class Produto
    {
        private int _id;
        private string _nome;
        private string _categoria;
        private int _quantidade;
        private double _preco;

        public int Id
        {
            get { return _id; }

            set
            {
                if (value >= 0)
                {
                    _id = value;
                }
            }
        }

        public string Nome
        {
            get { return _nome;  }

            set
            {
                if (value != null)
                {
                    _nome = value;
                }
                else
                {
                    MessageBox.Show("Insira um nome para o produto", "Erro");
                }
            }
        }

        public string Categoria
        {
            get { return _categoria; }

            set
            {
                if (value != null)
                {
                    _categoria = value;
                }
                else
                {
                    MessageBox.Show("Insira uma categoria para o produto", "Erro");
                }
            }
        }

        public int Quantidade
        {
            get { return _quantidade ; }

            set
            {
                if (value >= 0)
                {
                    _quantidade = value;
                }
                else
                {
                    MessageBox.Show("Insira uma quantidade para o produto", "Erro");
                }
            }
        }

        public double Preco
        {
            get { return _preco; }

            set
            {
                if (value >= 0 )
                {
                    _preco = value;
                }
                else
                {
                    MessageBox.Show("Insira um preço para o produto", "Erro");
                }
            }
        }

        public Produto (string nome, string categoria, int quantidade, double preco)
        {
            Nome = nome;
            Categoria = categoria;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
