namespace Produtos_Agrícolas
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastro = new Button();
            btnEstoque = new Button();
            btnVender = new Button();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(166, 46);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(75, 23);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Location = new Point(166, 75);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(75, 23);
            btnEstoque.TabIndex = 1;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(166, 104);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(75, 23);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVender);
            Controls.Add(btnEstoque);
            Controls.Add(btnCadastro);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastro;
        private Button btnEstoque;
        private Button btnVender;
    }
}
