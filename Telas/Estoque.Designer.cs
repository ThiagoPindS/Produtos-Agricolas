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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            voltarAoMenuToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            frutasToolStripMenuItem = new ToolStripMenuItem();
            grãosToolStripMenuItem = new ToolStripMenuItem();
            hortaliçasToolStripMenuItem = new ToolStripMenuItem();
            legumesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            dgvEstoque = new DataGridView();
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
            // voltarAoMenuToolStripMenuItem
            // 
            voltarAoMenuToolStripMenuItem.Image = Properties.Resources.Voltar;
            voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            voltarAoMenuToolStripMenuItem.Size = new Size(138, 24);
            voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu";
            voltarAoMenuToolStripMenuItem.Click += voltarAoMenuToolStripMenuItem_Click;
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frutasToolStripMenuItem, grãosToolStripMenuItem, hortaliçasToolStripMenuItem, legumesToolStripMenuItem });
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
            // legumesToolStripMenuItem
            // 
            legumesToolStripMenuItem.Image = Properties.Resources.Legumes;
            legumesToolStripMenuItem.Name = "legumesToolStripMenuItem";
            legumesToolStripMenuItem.Size = new Size(180, 24);
            legumesToolStripMenuItem.Text = "Legumes";
            legumesToolStripMenuItem.Click += legumesToolStripMenuItem_Click;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEstoque.ColumnHeadersHeight = 28;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvEstoque.DefaultCellStyle = dataGridViewCellStyle5;
            dgvEstoque.Location = new Point(0, 31);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
        private ToolStripMenuItem legumesToolStripMenuItem;
        private ToolStripMenuItem voltarAoMenuToolStripMenuItem;
    }
}