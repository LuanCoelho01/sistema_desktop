namespace Mush___Room.telaCompras
{
    partial class compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compras));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAltCompra = new System.Windows.Forms.Button();
            this.btnRegCompra = new System.Windows.Forms.Button();
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.txtProdComprado = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblProdutoComprado = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeEmpresa = new System.Windows.Forms.Label();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.txtQtdComprada = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(379, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 41);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAltCompra
            // 
            this.btnAltCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnAltCompra.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAltCompra.Location = new System.Drawing.Point(201, 369);
            this.btnAltCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltCompra.Name = "btnAltCompra";
            this.btnAltCompra.Size = new System.Drawing.Size(128, 58);
            this.btnAltCompra.TabIndex = 51;
            this.btnAltCompra.Text = "Alterar dados\r\nda compra";
            this.btnAltCompra.UseVisualStyleBackColor = false;
            this.btnAltCompra.Click += new System.EventHandler(this.btnAltCompra_Click);
            // 
            // btnRegCompra
            // 
            this.btnRegCompra.BackColor = System.Drawing.Color.Chocolate;
            this.btnRegCompra.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegCompra.Location = new System.Drawing.Point(335, 369);
            this.btnRegCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegCompra.Name = "btnRegCompra";
            this.btnRegCompra.Size = new System.Drawing.Size(128, 58);
            this.btnRegCompra.TabIndex = 50;
            this.btnRegCompra.Text = "Registrar\r\ncompra";
            this.btnRegCompra.UseVisualStyleBackColor = false;
            this.btnRegCompra.Click += new System.EventHandler(this.btnRegCompra_Click);
            // 
            // gridCompras
            // 
            this.gridCompras.AllowUserToAddRows = false;
            this.gridCompras.AllowUserToDeleteRows = false;
            this.gridCompras.AllowUserToResizeColumns = false;
            this.gridCompras.AllowUserToResizeRows = false;
            this.gridCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCompras.BackgroundColor = System.Drawing.Color.Snow;
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridCompras.Location = new System.Drawing.Point(513, 100);
            this.gridCompras.MultiSelect = false;
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.ReadOnly = true;
            this.gridCompras.RowHeadersVisible = false;
            this.gridCompras.RowHeadersWidth = 51;
            this.gridCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCompras.RowTemplate.Height = 24;
            this.gridCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCompras.Size = new System.Drawing.Size(571, 369);
            this.gridCompras.TabIndex = 38;
            this.gridCompras.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCompras_MouseDoubleClick);
            // 
            // txtProdComprado
            // 
            this.txtProdComprado.Location = new System.Drawing.Point(205, 203);
            this.txtProdComprado.Name = "txtProdComprado";
            this.txtProdComprado.Size = new System.Drawing.Size(265, 22);
            this.txtProdComprado.TabIndex = 47;
            this.txtProdComprado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdComprado_KeyPress);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(205, 161);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(265, 22);
            this.txtNomeFornecedor.TabIndex = 46;
            this.txtNomeFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFornecedor_KeyPress);
            // 
            // lblProdutoComprado
            // 
            this.lblProdutoComprado.AutoSize = true;
            this.lblProdutoComprado.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblProdutoComprado.Location = new System.Drawing.Point(15, 208);
            this.lblProdutoComprado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoComprado.Name = "lblProdutoComprado";
            this.lblProdutoComprado.Size = new System.Drawing.Size(133, 17);
            this.lblProdutoComprado.TabIndex = 45;
            this.lblProdutoComprado.Text = "Produto comprado";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.Location = new System.Drawing.Point(15, 250);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(153, 17);
            this.lblQuantidade.TabIndex = 44;
            this.lblQuantidade.Text = "Quantidade comprada";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.Location = new System.Drawing.Point(15, 290);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(83, 17);
            this.lblValorTotal.TabIndex = 43;
            this.lblValorTotal.Text = "Valor total";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblFornecedor.Location = new System.Drawing.Point(15, 166);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(141, 17);
            this.lblFornecedor.TabIndex = 42;
            this.lblFornecedor.Text = "Nome do fornecedor";
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
            this.menuStrip1.Location = new System.Drawing.Point(625, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 25);
            this.menuStrip1.TabIndex = 41;
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
            this.fornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.comprasToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.comprasToolStripMenuItem.Text = "Compras";
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
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.AutoSize = true;
            this.nomeEmpresa.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2F);
            this.nomeEmpresa.Location = new System.Drawing.Point(80, 37);
            this.nomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.Size = new System.Drawing.Size(112, 25);
            this.nomeEmpresa.TabIndex = 40;
            this.nomeEmpresa.Text = "Mush && Room";
            this.nomeEmpresa.Click += new System.EventHandler(this.nomeEmpresa_Click);
            // 
            // logoEmpresa
            // 
            this.logoEmpresa.Image = global::Mush___Room.Properties.Resources.mushroom_icon_138360;
            this.logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.logoEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.logoEmpresa.Name = "logoEmpresa";
            this.logoEmpresa.Size = new System.Drawing.Size(93, 62);
            this.logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoEmpresa.TabIndex = 39;
            this.logoEmpresa.TabStop = false;
            this.logoEmpresa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtQtdComprada
            // 
            this.txtQtdComprada.Location = new System.Drawing.Point(205, 245);
            this.txtQtdComprada.Name = "txtQtdComprada";
            this.txtQtdComprada.Size = new System.Drawing.Size(120, 22);
            this.txtQtdComprada.TabIndex = 54;
            this.txtQtdComprada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdComprada_KeyPress);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(205, 287);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(120, 22);
            this.txtValorTotal.TabIndex = 55;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1099, 543);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtQtdComprada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAltCompra);
            this.Controls.Add(this.btnRegCompra);
            this.Controls.Add(this.gridCompras);
            this.Controls.Add(this.txtProdComprado);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblProdutoComprado);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.logoEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de compras";
            this.Load += new System.EventHandler(this.compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAltCompra;
        private System.Windows.Forms.Button btnRegCompra;
        private System.Windows.Forms.DataGridView gridCompras;
        private System.Windows.Forms.TextBox txtProdComprado;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblProdutoComprado;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.Label nomeEmpresa;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.TextBox txtQtdComprada;
        private System.Windows.Forms.TextBox txtValorTotal;
    }
}