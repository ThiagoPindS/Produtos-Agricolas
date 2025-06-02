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
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            lblNome = new Label();
            lblCategoria = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            menuStrip1 = new MenuStrip();
            voltarAoMenuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cmbCategoria = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(123, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(282, 27);
            txtNome.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 11F);
            txtQuantidade.Location = new Point(123, 131);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(282, 27);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.KeyPress += PressionarApenasNumeros;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 11F);
            txtPreco.Location = new Point(123, 164);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(282, 27);
            txtPreco.TabIndex = 3;
            txtPreco.KeyPress += PressionarApenasNumeros;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.Location = new Point(30, 63);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 11F);
            lblCategoria.Location = new Point(30, 100);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 11F);
            lblQuantidade.Location = new Point(30, 134);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(87, 20);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 11F);
            lblPreco.Location = new Point(30, 167);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preco";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 11F);
            btnSalvar.Location = new Point(330, 206);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 28);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarAoMenuToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(434, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            voltarAoMenuToolStripMenuItem.Image = Properties.Resources.Voltar;
            voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            voltarAoMenuToolStripMenuItem.Size = new Size(76, 24);
            voltarAoMenuToolStripMenuItem.Text = "Voltar";
            voltarAoMenuToolStripMenuItem.Click += voltarAoMenuToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(62, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 11F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Fruta", "Grão", "Hortaliça", "Legume" });
            cmbCategoria.Location = new Point(123, 97);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(282, 28);
            cmbCategoria.TabIndex = 1;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 261);
            Controls.Add(cmbCategoria);
            Controls.Add(menuStrip1);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblCategoria);
            Controls.Add(lblNome);
            Controls.Add(txtPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtNome;
        public TextBox txtQuantidade;
        public TextBox txtPreco;
        private Label lblNome;
        private Label lblCategoria;
        private Label lblQuantidade;
        private Label lblPreco;
        private Button btnSalvar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        public ComboBox cmbCategoria;
        private ToolStripMenuItem voltarAoMenuToolStripMenuItem;
    }
}