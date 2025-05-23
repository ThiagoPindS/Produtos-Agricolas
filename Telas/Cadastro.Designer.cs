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
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            lblNome = new Label();
            lblCategoria = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            Estoque = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(245, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(91, 41);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(245, 23);
            txtCategoria.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(91, 70);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(245, 23);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.Text = "0";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(91, 99);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(245, 23);
            txtPreco.TabIndex = 3;
            txtPreco.Text = "0";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 44);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 73);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 102);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preco";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(262, 128);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Estoque
            // 
            Estoque.Location = new Point(261, 157);
            Estoque.Name = "Estoque";
            Estoque.Size = new Size(75, 23);
            Estoque.TabIndex = 9;
            Estoque.Text = "Estoque";
            Estoque.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 189);
            Controls.Add(Estoque);
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
            Text = "Cadastro";
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
        private Button Estoque;
    }
}