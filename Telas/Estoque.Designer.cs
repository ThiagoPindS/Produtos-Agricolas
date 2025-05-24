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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            geralToolStripMenuItem = new ToolStripMenuItem();
            irrigaçãoToolStripMenuItem = new ToolStripMenuItem();
            adubaçãoToolStripMenuItem = new ToolStripMenuItem();
            controleDePragasToolStripMenuItem = new ToolStripMenuItem();
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
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geralToolStripMenuItem, irrigaçãoToolStripMenuItem, adubaçãoToolStripMenuItem, controleDePragasToolStripMenuItem });
            pesquisarToolStripMenuItem.Image = Properties.Resources.Pesquisar;
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(98, 24);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // geralToolStripMenuItem
            // 
            geralToolStripMenuItem.Image = Properties.Resources.Geral;
            geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            geralToolStripMenuItem.Size = new Size(205, 24);
            geralToolStripMenuItem.Text = "Geral";
            // 
            // irrigaçãoToolStripMenuItem
            // 
            irrigaçãoToolStripMenuItem.Image = Properties.Resources.Irrigação;
            irrigaçãoToolStripMenuItem.Name = "irrigaçãoToolStripMenuItem";
            irrigaçãoToolStripMenuItem.Size = new Size(205, 24);
            irrigaçãoToolStripMenuItem.Text = "Irrigação";
            // 
            // adubaçãoToolStripMenuItem
            // 
            adubaçãoToolStripMenuItem.Image = Properties.Resources.Adubação;
            adubaçãoToolStripMenuItem.Name = "adubaçãoToolStripMenuItem";
            adubaçãoToolStripMenuItem.Size = new Size(205, 24);
            adubaçãoToolStripMenuItem.Text = "Adubação";
            // 
            // controleDePragasToolStripMenuItem
            // 
            controleDePragasToolStripMenuItem.Image = Properties.Resources.Controle_de_pragas;
            controleDePragasToolStripMenuItem.Name = "controleDePragasToolStripMenuItem";
            controleDePragasToolStripMenuItem.Size = new Size(205, 24);
            controleDePragasToolStripMenuItem.Text = "Controle de pragas";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEstoque.ColumnHeadersHeight = 28;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEstoque.Location = new Point(0, 31);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
        private ToolStripMenuItem geralToolStripMenuItem;
        private ToolStripMenuItem irrigaçãoToolStripMenuItem;
        private ToolStripMenuItem adubaçãoToolStripMenuItem;
        private ToolStripMenuItem controleDePragasToolStripMenuItem;
    }
}