namespace Mush___Room.telaFornecedores
{
    partial class fornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fornecedores));
            this.nomeEmpresa = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnExcForn = new System.Windows.Forms.Button();
            this.btnAltForn = new System.Windows.Forms.Button();
            this.btnCadForn = new System.Windows.Forms.Button();
            this.gridFornecedores = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.AutoSize = true;
            this.nomeEmpresa.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2F);
            this.nomeEmpresa.Location = new System.Drawing.Point(80, 37);
            this.nomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.Size = new System.Drawing.Size(112, 25);
            this.nomeEmpresa.TabIndex = 10;
            this.nomeEmpresa.Text = "Mush && Room";
            this.nomeEmpresa.Click += new System.EventHandler(this.nomeEmpresa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produçãoToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(626, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(454, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.produçãoToolStripMenuItem.Text = "Produção";
            this.produçãoToolStripMenuItem.Click += new System.EventHandler(this.produçãoToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.fornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // logoEmpresa
            // 
            this.logoEmpresa.Image = global::Mush___Room.Properties.Resources.mushroom_icon_138360;
            this.logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.logoEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.logoEmpresa.Name = "logoEmpresa";
            this.logoEmpresa.Size = new System.Drawing.Size(93, 62);
            this.logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoEmpresa.TabIndex = 9;
            this.logoEmpresa.TabStop = false;
            this.logoEmpresa.Click += new System.EventHandler(this.logoEmpresa_Click);
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblCNPJ.Location = new System.Drawing.Point(21, 252);
            this.lblCNPJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(40, 17);
            this.lblCNPJ.TabIndex = 19;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.Location = new System.Drawing.Point(21, 293);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblFornecedor.Location = new System.Drawing.Point(21, 164);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(141, 17);
            this.lblFornecedor.TabIndex = 17;
            this.lblFornecedor.Text = "Nome do fornecedor";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblProduto.Location = new System.Drawing.Point(21, 210);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(123, 17);
            this.lblProduto.TabIndex = 20;
            this.lblProduto.Text = "Nome do produto";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(191, 159);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(265, 22);
            this.txtNomeFornecedor.TabIndex = 21;
            this.txtNomeFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFornecedor_KeyPress);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(191, 206);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(265, 22);
            this.txtNomeProduto.TabIndex = 22;
            this.txtNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeProduto_KeyPress);
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(191, 247);
            this.mskCNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCNPJ.Mask = "00.000.000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(145, 22);
            this.mskCNPJ.TabIndex = 23;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(191, 288);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(101, 22);
            this.mskTelefone.TabIndex = 24;
            // 
            // btnExcForn
            // 
            this.btnExcForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnExcForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcForn.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnExcForn.Location = new System.Drawing.Point(71, 372);
            this.btnExcForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcForn.Name = "btnExcForn";
            this.btnExcForn.Size = new System.Drawing.Size(128, 58);
            this.btnExcForn.TabIndex = 36;
            this.btnExcForn.Text = "Excluir\r\nfornecedor";
            this.btnExcForn.UseVisualStyleBackColor = false;
            this.btnExcForn.Click += new System.EventHandler(this.btnExcForn_Click);
            // 
            // btnAltForn
            // 
            this.btnAltForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnAltForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltForn.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAltForn.Location = new System.Drawing.Point(208, 372);
            this.btnAltForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltForn.Name = "btnAltForn";
            this.btnAltForn.Size = new System.Drawing.Size(128, 58);
            this.btnAltForn.TabIndex = 35;
            this.btnAltForn.Text = "Alterar dados\r\ndo fornecedor";
            this.btnAltForn.UseVisualStyleBackColor = false;
            this.btnAltForn.Click += new System.EventHandler(this.btnAltForn_Click);
            // 
            // btnCadForn
            // 
            this.btnCadForn.BackColor = System.Drawing.Color.Chocolate;
            this.btnCadForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadForn.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadForn.Location = new System.Drawing.Point(344, 372);
            this.btnCadForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadForn.Name = "btnCadForn";
            this.btnCadForn.Size = new System.Drawing.Size(128, 58);
            this.btnCadForn.TabIndex = 34;
            this.btnCadForn.Text = "Cadastrar \r\nfornecedor";
            this.btnCadForn.UseVisualStyleBackColor = false;
            this.btnCadForn.Click += new System.EventHandler(this.btnCadForn_Click_1);
            // 
            // gridFornecedores
            // 
            this.gridFornecedores.AllowUserToAddRows = false;
            this.gridFornecedores.AllowUserToDeleteRows = false;
            this.gridFornecedores.AllowUserToResizeColumns = false;
            this.gridFornecedores.AllowUserToResizeRows = false;
            this.gridFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFornecedores.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedores.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFornecedores.Location = new System.Drawing.Point(513, 100);
            this.gridFornecedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridFornecedores.MultiSelect = false;
            this.gridFornecedores.Name = "gridFornecedores";
            this.gridFornecedores.ReadOnly = true;
            this.gridFornecedores.RowHeadersVisible = false;
            this.gridFornecedores.RowHeadersWidth = 51;
            this.gridFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFornecedores.RowTemplate.Height = 24;
            this.gridFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFornecedores.Size = new System.Drawing.Size(571, 369);
            this.gridFornecedores.TabIndex = 4;
            this.gridFornecedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedores_CellContentClick);
            this.gridFornecedores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridFornecedores_MouseDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(356, 268);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1099, 543);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcForn);
            this.Controls.Add(this.btnAltForn);
            this.Controls.Add(this.btnCadForn);
            this.Controls.Add(this.gridFornecedores);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.logoEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de fornecedores";
            this.Load += new System.EventHandler(this.fornecedores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.Label nomeEmpresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Button btnExcForn;
        private System.Windows.Forms.Button btnAltForn;
        private System.Windows.Forms.Button btnCadForn;
        private System.Windows.Forms.DataGridView gridFornecedores;
        private System.Windows.Forms.Button btnCancelar;
    }
}