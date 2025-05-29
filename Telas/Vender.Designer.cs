namespace Produtos_Agrícolas.Telas
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            menuStrip1 = new MenuStrip();
            voltarAoMenuToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnConfirmarVenda = new Button();
            lblId = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            btnBuscar = new Button();
            txtQuantidadeDisponivel = new TextBox();
            lblQuantidadeVenda = new Label();
            txtQuantidadeVenda = new TextBox();
            txtPrecoTotal = new TextBox();
            lblNome = new Label();
            lblPreco = new Label();
            lblQuantidadeDisponivel = new Label();
            txtTotal = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarAoMenuToolStripMenuItem, registrosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            voltarAoMenuToolStripMenuItem.Image = Properties.Resources.Voltar;
            voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            voltarAoMenuToolStripMenuItem.Size = new Size(76, 24);
            voltarAoMenuToolStripMenuItem.Text = "Voltar";
            voltarAoMenuToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.Image = (Image)resources.GetObject("registrosToolStripMenuItem.Image");
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(98, 24);
            registrosToolStripMenuItem.Text = "Registros";
            registrosToolStripMenuItem.Click += registrosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(62, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click_1;
            // 
            // btnConfirmarVenda
            // 
            btnConfirmarVenda.Font = new Font("Segoe UI", 11F);
            btnConfirmarVenda.Location = new Point(236, 266);
            btnConfirmarVenda.Name = "btnConfirmarVenda";
            btnConfirmarVenda.Size = new Size(136, 28);
            btnConfirmarVenda.TabIndex = 4;
            btnConfirmarVenda.Text = "Confirmar Venda";
            btnConfirmarVenda.UseVisualStyleBackColor = true;
            btnConfirmarVenda.Click += btnConfirmarVenda_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(12, 38);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 20;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F);
            txtId.Location = new Point(127, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(245, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(127, 98);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(245, 27);
            txtNome.TabIndex = 21;
            txtNome.Text = "Nome: Insira um ID";
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 11F);
            txtPreco.Location = new Point(127, 135);
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = true;
            txtPreco.Size = new Size(245, 27);
            txtPreco.TabIndex = 22;
            txtPreco.Text = "Preço: Insira um ID";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 11F);
            btnBuscar.Location = new Point(290, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtQuantidadeDisponivel
            // 
            txtQuantidadeDisponivel.Font = new Font("Segoe UI", 11F);
            txtQuantidadeDisponivel.Location = new Point(127, 168);
            txtQuantidadeDisponivel.Name = "txtQuantidadeDisponivel";
            txtQuantidadeDisponivel.ReadOnly = true;
            txtQuantidadeDisponivel.Size = new Size(245, 27);
            txtQuantidadeDisponivel.TabIndex = 23;
            txtQuantidadeDisponivel.Text = "Quantidade disponível: Insira um id";
            // 
            // lblQuantidadeVenda
            // 
            lblQuantidadeVenda.AutoSize = true;
            lblQuantidadeVenda.Font = new Font("Segoe UI", 11F);
            lblQuantidadeVenda.Location = new Point(12, 204);
            lblQuantidadeVenda.Name = "lblQuantidadeVenda";
            lblQuantidadeVenda.Size = new Size(98, 20);
            lblQuantidadeVenda.TabIndex = 24;
            lblQuantidadeVenda.Text = "Qtd a vender:";
            // 
            // txtQuantidadeVenda
            // 
            txtQuantidadeVenda.Font = new Font("Segoe UI", 11F);
            txtQuantidadeVenda.Location = new Point(127, 200);
            txtQuantidadeVenda.Name = "txtQuantidadeVenda";
            txtQuantidadeVenda.Size = new Size(245, 27);
            txtQuantidadeVenda.TabIndex = 25;
            txtQuantidadeVenda.Text = "0";
            txtQuantidadeVenda.TextChanged += txtQuantidadeVenda_TextChanged;
            // 
            // txtPrecoTotal
            // 
            txtPrecoTotal.Font = new Font("Segoe UI", 11F);
            txtPrecoTotal.Location = new Point(127, 233);
            txtPrecoTotal.Name = "txtPrecoTotal";
            txtPrecoTotal.ReadOnly = true;
            txtPrecoTotal.Size = new Size(245, 27);
            txtPrecoTotal.TabIndex = 26;
            txtPrecoTotal.Text = "0";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.Location = new Point(12, 105);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 11F);
            lblPreco.Location = new Point(12, 138);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(49, 20);
            lblPreco.TabIndex = 28;
            lblPreco.Text = "Preço:";
            // 
            // lblQuantidadeDisponivel
            // 
            lblQuantidadeDisponivel.AutoSize = true;
            lblQuantidadeDisponivel.Font = new Font("Segoe UI", 11F);
            lblQuantidadeDisponivel.Location = new Point(12, 171);
            lblQuantidadeDisponivel.Name = "lblQuantidadeDisponivel";
            lblQuantidadeDisponivel.Size = new Size(109, 20);
            lblQuantidadeDisponivel.TabIndex = 29;
            lblQuantidadeDisponivel.Text = "Qtd disponível:";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Segoe UI", 11F);
            txtTotal.Location = new Point(12, 236);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(42, 20);
            txtTotal.TabIndex = 30;
            txtTotal.Text = "Total";
            // 
            // Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 304);
            Controls.Add(txtTotal);
            Controls.Add(lblQuantidadeDisponivel);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(txtPrecoTotal);
            Controls.Add(txtQuantidadeVenda);
            Controls.Add(lblQuantidadeVenda);
            Controls.Add(txtQuantidadeDisponivel);
            Controls.Add(btnBuscar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnConfirmarVenda);
            Controls.Add(menuStrip1);
            Name = "Venda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem voltarAoMenuToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private Button btnConfirmarVenda;
        private Label lblQuantidade;
        public TextBox txtQuantidade;
        private Label lblId;
        public TextBox txtId;
        public TextBox txtNome;
        public TextBox txtPreco;
        private Button btnBuscar;
        public TextBox txtQuantidadeDisponivel;
        private Label lblQuantidadeVenda;
        public TextBox txtQuantidadeVenda;
        public TextBox txtPrecoTotal;
        private Label lblNome;
        private Label lblPreco;
        private Label lblQuantidadeDisponivel;
        private Label txtTotal;
    }
}