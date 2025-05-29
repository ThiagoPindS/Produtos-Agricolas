namespace Produtos_Agrícolas.Classes
{
    public class Venda
    {
        private int _id;
        private DateTime _data;
        private string _nome;
        private int _quantidade;
        private double _precoUnitario;
        private double _precoTotal;

        public int Id
        {
            get { return _id; }

            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    MessageBox.Show("Id da venda não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null)
                {
                    _nome = value;
                }
                else
                {
                    MessageBox.Show("Nome do produto vendido não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DateTime Data
        {
            get { return _data; }

            set
            {
                if (value != null)
                {
                    _data = value;
                }
                else
                {
                    MessageBox.Show("Data da venda não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int Quantidade
        {
            get { return _quantidade; }

            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
                else
                {
                    MessageBox.Show("Quantidade da venda não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public double PrecoUnitario
        {
            get { return _precoUnitario; }

            set
            {
                if (value >= 0)
                {
                    _precoUnitario = value;
                }
                else
                {
                    MessageBox.Show("Preço da unidade não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public double PrecoTotal
        {
            get { return _precoTotal; }

            set
            {
                if (value >= 0)
                {
                    _precoTotal = value;
                }
                else
                {
                    MessageBox.Show("Preço da unidade não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Venda(string nome, int quantidade, double precoUnitario, double precoTotal)
        {
            Data = DateTime.Now;
            Nome = nome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            PrecoTotal = precoTotal;
        }
    }
}
