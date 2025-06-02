using Produtos_Agrícolas.Classes;

namespace Produtos_Agrícolas.Telas
{
    public partial class Registros : Form
    {
        private List<Venda> Vendas = new List<Venda>();

        public Registros()
        {
            InitializeComponent();

            AtualizarDataGridView();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AtualizarDataGridView()
        {
            Vendas = VendaService.CarregarVendas();

            dgvRegistros.DataSource = null;

            foreach (Venda venda in Vendas)
            {
                dgvRegistros.Rows.Add(venda.ProdutoId, venda.Nome, venda.Data, venda.PrecoUnitario.ToString("F2"), venda.Quantidade, venda.PrecoTotal.ToString("F2"));
            }
        }
    }
}
