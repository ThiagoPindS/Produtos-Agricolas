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
            frutasToolStripMenuItem = new ToolStripMenuItem();
            grãosToolStripMenuItem = new ToolStripMenuItem();
            hortaliçasToolStripMenuItem = new ToolStripMenuItem();
            vegetaisToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            dgvEstoque = new DataGridView();
            voltarAoMenuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarAoMenuToolStripMenuItem, pesquisarToolStripMenuItem, sairToolStripMenuItem });
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
            frutasToolStripMenuItem.Size = new Size(145, 24);
            frutasToolStripMenuItem.Text = "Frutas";
            frutasToolStripMenuItem.Click += frutasToolStripMenuItem_Click;
            // 
            // grãosToolStripMenuItem
            // 
            grãosToolStripMenuItem.Image = Properties.Resources.Grãos;
            grãosToolStripMenuItem.Name = "grãosToolStripMenuItem";
            grãosToolStripMenuItem.Size = new Size(145, 24);
            grãosToolStripMenuItem.Text = "Grãos";
            grãosToolStripMenuItem.Click += grãosToolStripMenuItem_Click;
            // 
            // hortaliçasToolStripMenuItem
            // 
            hortaliçasToolStripMenuItem.Image = Properties.Resources.Hortaliças;
            hortaliçasToolStripMenuItem.Name = "hortaliçasToolStripMenuItem";
            hortaliçasToolStripMenuItem.Size = new Size(145, 24);
            hortaliçasToolStripMenuItem.Text = "Hortaliças";
            hortaliçasToolStripMenuItem.Click += hortaliçasToolStripMenuItem_Click;
            // 
            // vegetaisToolStripMenuItem
            // 
            vegetaisToolStripMenuItem.Image = Properties.Resources.Vegetais;
            vegetaisToolStripMenuItem.Name = "vegetaisToolStripMenuItem";
            vegetaisToolStripMenuItem.Size = new Size(145, 24);
            vegetaisToolStripMenuItem.Text = "Vegetais";
            vegetaisToolStripMenuItem.Click += vegetaisToolStripMenuItem_Click;
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
            // voltarAoMenuToolStripMenuItem
            // 
            voltarAoMenuToolStripMenuItem.Image = Properties.Resources.Voltar;
            voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            voltarAoMenuToolStripMenuItem.Size = new Size(138, 24);
            voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu";
            voltarAoMenuToolStripMenuItem.Click += voltarAoMenuToolStripMenuItem_Click;
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private DataGridView dgvEstoque;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem grãosToolStripMenuItem;
        private ToolStripMenuItem hortaliçasToolStripMenuItem;
        private ToolStripMenuItem frutasToolStripMenuItem;
        private ToolStripMenuItem vegetaisToolStripMenuItem;
        private ToolStripMenuItem voltarAoMenuToolStripMenuItem;
    }
}