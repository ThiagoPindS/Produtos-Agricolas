namespace Produtos_Agrícolas.Telas
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            lblNome = new Label();
            lblCategoria = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(245, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(91, 97);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(245, 23);
            txtCategoria.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(91, 126);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(245, 23);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.Text = "0";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(91, 155);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(245, 23);
            txtPreco.TabIndex = 3;
            txtPreco.Text = "0";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 71);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 100);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 129);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 158);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preco";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(262, 184);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, estoqueToolStripMenuItem, vendaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Image = Properties.Resources.Cadastro;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(96, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Image = Properties.Resources.Estoque;
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(90, 24);
            estoqueToolStripMenuItem.Text = "Estoque";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Image = Properties.Resources.Venda;
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(78, 24);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(62, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(menuStrip1);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblCategoria);
            Controls.Add(lblNome);
            Controls.Add(txtPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCategoria);
            Controls.Add(txtNome);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            VisibleChanged += Cadastro_VisibleChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCategoria;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private Label lblNome;
        private Label lblCategoria;
        private Label lblQuantidade;
        private Label lblPreco;
        private Button btnSalvar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}