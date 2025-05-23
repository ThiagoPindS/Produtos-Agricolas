using Produtos_Agrícolas.Telas;

namespace Produtos_Agrícolas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            this.Hide();

            cadastro.ShowDialog();

            this.Show();
        }
    }
}
