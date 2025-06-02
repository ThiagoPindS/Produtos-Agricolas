namespace Produtos_Agrícolas.Telas
{
    partial class Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            voltarAoMenuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            dgvRegistros = new DataGridView();
            IdDoProduto = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            PrecoUnitario = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            PrecoTotal = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarAoMenuToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 28);
            menuStrip1.TabIndex = 11;
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
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(62, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AllowUserToOrderColumns = true;
            dgvRegistros.AllowUserToResizeColumns = false;
            dgvRegistros.AllowUserToResizeRows = false;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { IdDoProduto, Nome, Data, PrecoUnitario, Quantidade, PrecoTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.Location = new Point(0, 31);
            dgvRegistros.Name = "dgvRegistros";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.Size = new Size(1264, 650);
            dgvRegistros.TabIndex = 12;
            // 
            // IdDoProduto
            // 
            IdDoProduto.HeaderText = "ID DO PRODUTO";
            IdDoProduto.Name = "IdDoProduto";
            IdDoProduto.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Data
            // 
            Data.HeaderText = "DATA";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // PrecoUnitario
            // 
            PrecoUnitario.HeaderText = "PREÇO UNITÁRIO";
            PrecoUnitario.Name = "PrecoUnitario";
            PrecoUnitario.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "QUANTIDADE";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // PrecoTotal
            // 
            PrecoTotal.HeaderText = "PREÇO TOTAL";
            PrecoTotal.Name = "PrecoTotal";
            PrecoTotal.ReadOnly = true;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvRegistros);
            Controls.Add(menuStrip1);
            Name = "Registros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarAoMenuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private DataGridView dgvRegistros;
        private DataGridViewTextBoxColumn IdDoProduto;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn PrecoUnitario;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn PrecoTotal;
    }
}