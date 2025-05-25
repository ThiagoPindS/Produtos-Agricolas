namespace Produtos_Agrícolas.Telas
{
    partial class Estoque
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            frutasToolStripMenuItem = new ToolStripMenuItem();
            grãosToolStripMenuItem = new ToolStripMenuItem();
            hortaliçasToolStripMenuItem = new ToolStripMenuItem();
            vegetaisToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            dgvEstoque = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pesquisarToolStripMenuItem, cadastroToolStripMenuItem, estoqueToolStripMenuItem, vendaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frutasToolStripMenuItem, grãosToolStripMenuItem, hortaliçasToolStripMenuItem, vegetaisToolStripMenuItem });
            pesquisarToolStripMenuItem.Image = Properties.Resources.Filtrar;
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(75, 24);
            pesquisarToolStripMenuItem.Text = "Filtrar";
            // 
            // frutasToolStripMenuItem
            // 
            frutasToolStripMenuItem.Image = Properties.Resources.Frutas;
            frutasToolStripMenuItem.Name = "frutasToolStripMenuItem";
            frutasToolStripMenuItem.Size = new Size(180, 24);
            frutasToolStripMenuItem.Text = "Frutas";
            frutasToolStripMenuItem.Click += frutasToolStripMenuItem_Click;
            // 
            // grãosToolStripMenuItem
            // 
            grãosToolStripMenuItem.Image = Properties.Resources.Grãos;
            grãosToolStripMenuItem.Name = "grãosToolStripMenuItem";
            grãosToolStripMenuItem.Size = new Size(180, 24);
            grãosToolStripMenuItem.Text = "Grãos";
            grãosToolStripMenuItem.Click += grãosToolStripMenuItem_Click;
            // 
            // hortaliçasToolStripMenuItem
            // 
            hortaliçasToolStripMenuItem.Image = Properties.Resources.Hortaliças;
            hortaliçasToolStripMenuItem.Name = "hortaliçasToolStripMenuItem";
            hortaliçasToolStripMenuItem.Size = new Size(180, 24);
            hortaliçasToolStripMenuItem.Text = "Hortaliças";
            hortaliçasToolStripMenuItem.Click += hortaliçasToolStripMenuItem_Click;
            // 
            // vegetaisToolStripMenuItem
            // 
            vegetaisToolStripMenuItem.Image = Properties.Resources.Vegetais;
            vegetaisToolStripMenuItem.Name = "vegetaisToolStripMenuItem";
            vegetaisToolStripMenuItem.Size = new Size(180, 24);
            vegetaisToolStripMenuItem.Text = "Vegetais";
            vegetaisToolStripMenuItem.Click += vegetaisToolStripMenuItem_Click;
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
            sairToolStripMenuItem.Image = Properties.Resources.Sair;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(62, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.AllowUserToOrderColumns = true;
            dgvEstoque.AllowUserToResizeColumns = false;
            dgvEstoque.AllowUserToResizeRows = false;
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvEstoque.ColumnHeadersHeight = 28;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvEstoque.DefaultCellStyle = dataGridViewCellStyle11;
            dgvEstoque.Location = new Point(0, 31);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEstoque.Size = new Size(1264, 650);
            dgvEstoque.TabIndex = 1;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvEstoque);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Estoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += Estoque_Load;
            VisibleChanged += Estoque_VisibleChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private DataGridView dgvEstoque;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem grãosToolStripMenuItem;
        private ToolStripMenuItem hortaliçasToolStripMenuItem;
        private ToolStripMenuItem frutasToolStripMenuItem;
        private ToolStripMenuItem vegetaisToolStripMenuItem;
    }
}