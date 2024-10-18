namespace Mush___Room
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.nomeEmpresa = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProducao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.gridFornecedoresPrincipal = new System.Windows.Forms.DataGridView();
            this.gridProducaoPrincipal = new System.Windows.Forms.DataGridView();
            this.gridProdutosPrincipal = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProducaoPrincipal = new System.Windows.Forms.Label();
            this.lblFornecedoresPrincipal = new System.Windows.Forms.Label();
            this.lblProdutosPrincipal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedoresPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducaoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.AutoSize = true;
            this.nomeEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.nomeEmpresa.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2F);
            this.nomeEmpresa.Location = new System.Drawing.Point(76, 37);
            this.nomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.Size = new System.Drawing.Size(112, 25);
            this.nomeEmpresa.TabIndex = 1;
            this.nomeEmpresa.Text = "Mush && Room";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProducao,
            this.menuFornecedores,
            this.menuCompras,
            this.menuProdutos,
            this.menuRelatorios});
            this.menuStrip1.Location = new System.Drawing.Point(595, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(454, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProducao
            // 
            this.menuProducao.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuProducao.Name = "menuProducao";
            this.menuProducao.Size = new System.Drawing.Size(85, 21);
            this.menuProducao.Text = "Produção";
            this.menuProducao.Click += new System.EventHandler(this.menuProducao_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(110, 21);
            this.menuFornecedores.Text = "Fornecedores";
            this.menuFornecedores.Click += new System.EventHandler(this.menuFornecedores_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(80, 21);
            this.menuCompras.Text = "Compras";
            this.menuCompras.Click += new System.EventHandler(this.menuCompras_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(82, 21);
            this.menuProdutos.Text = "Produtos";
            this.menuProdutos.Click += new System.EventHandler(this.menuProdutos_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(90, 21);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // gridFornecedoresPrincipal
            // 
            this.gridFornecedoresPrincipal.AllowUserToAddRows = false;
            this.gridFornecedoresPrincipal.AllowUserToDeleteRows = false;
            this.gridFornecedoresPrincipal.AllowUserToResizeColumns = false;
            this.gridFornecedoresPrincipal.AllowUserToResizeRows = false;
            this.gridFornecedoresPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFornecedoresPrincipal.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFornecedoresPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFornecedoresPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedoresPrincipal.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFornecedoresPrincipal.Location = new System.Drawing.Point(40, 130);
            this.gridFornecedoresPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.gridFornecedoresPrincipal.MultiSelect = false;
            this.gridFornecedoresPrincipal.Name = "gridFornecedoresPrincipal";
            this.gridFornecedoresPrincipal.ReadOnly = true;
            this.gridFornecedoresPrincipal.RowHeadersVisible = false;
            this.gridFornecedoresPrincipal.RowHeadersWidth = 51;
            this.gridFornecedoresPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFornecedoresPrincipal.Size = new System.Drawing.Size(501, 170);
            this.gridFornecedoresPrincipal.TabIndex = 4;
            this.gridFornecedoresPrincipal.DoubleClick += new System.EventHandler(this.gridFornecedoresPrincipal_DoubleClick);
            // 
            // gridProducaoPrincipal
            // 
            this.gridProducaoPrincipal.AllowUserToAddRows = false;
            this.gridProducaoPrincipal.AllowUserToDeleteRows = false;
            this.gridProducaoPrincipal.AllowUserToResizeColumns = false;
            this.gridProducaoPrincipal.AllowUserToResizeRows = false;
            this.gridProducaoPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducaoPrincipal.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducaoPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducaoPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducaoPrincipal.Location = new System.Drawing.Point(40, 365);
            this.gridProducaoPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.gridProducaoPrincipal.MultiSelect = false;
            this.gridProducaoPrincipal.Name = "gridProducaoPrincipal";
            this.gridProducaoPrincipal.ReadOnly = true;
            this.gridProducaoPrincipal.RowHeadersVisible = false;
            this.gridProducaoPrincipal.RowHeadersWidth = 51;
            this.gridProducaoPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducaoPrincipal.Size = new System.Drawing.Size(501, 157);
            this.gridProducaoPrincipal.TabIndex = 4;
            this.gridProducaoPrincipal.DoubleClick += new System.EventHandler(this.gridProducaoPrincipal_DoubleClick);
            // 
            // gridProdutosPrincipal
            // 
            this.gridProdutosPrincipal.AllowUserToAddRows = false;
            this.gridProdutosPrincipal.AllowUserToDeleteRows = false;
            this.gridProdutosPrincipal.AllowUserToResizeColumns = false;
            this.gridProdutosPrincipal.AllowUserToResizeRows = false;
            this.gridProdutosPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdutosPrincipal.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutosPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProdutosPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutosPrincipal.Location = new System.Drawing.Point(595, 179);
            this.gridProdutosPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.gridProdutosPrincipal.MultiSelect = false;
            this.gridProdutosPrincipal.Name = "gridProdutosPrincipal";
            this.gridProdutosPrincipal.ReadOnly = true;
            this.gridProdutosPrincipal.RowHeadersVisible = false;
            this.gridProdutosPrincipal.RowHeadersWidth = 51;
            this.gridProdutosPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProdutosPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutosPrincipal.Size = new System.Drawing.Size(437, 301);
            this.gridProdutosPrincipal.TabIndex = 5;
            this.gridProdutosPrincipal.DoubleClick += new System.EventHandler(this.gridProdutosPrincipal_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mush___Room.Properties.Resources.mushroom_icon_138360;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblProducaoPrincipal
            // 
            this.lblProducaoPrincipal.AutoSize = true;
            this.lblProducaoPrincipal.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold);
            this.lblProducaoPrincipal.Location = new System.Drawing.Point(241, 338);
            this.lblProducaoPrincipal.Name = "lblProducaoPrincipal";
            this.lblProducaoPrincipal.Size = new System.Drawing.Size(93, 23);
            this.lblProducaoPrincipal.TabIndex = 6;
            this.lblProducaoPrincipal.Text = "Produção";
            // 
            // lblFornecedoresPrincipal
            // 
            this.lblFornecedoresPrincipal.AutoSize = true;
            this.lblFornecedoresPrincipal.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedoresPrincipal.Location = new System.Drawing.Point(224, 103);
            this.lblFornecedoresPrincipal.Name = "lblFornecedoresPrincipal";
            this.lblFornecedoresPrincipal.Size = new System.Drawing.Size(130, 23);
            this.lblFornecedoresPrincipal.TabIndex = 7;
            this.lblFornecedoresPrincipal.Text = "Fornecedores";
            // 
            // lblProdutosPrincipal
            // 
            this.lblProdutosPrincipal.AutoSize = true;
            this.lblProdutosPrincipal.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold);
            this.lblProdutosPrincipal.Location = new System.Drawing.Point(756, 152);
            this.lblProdutosPrincipal.Name = "lblProdutosPrincipal";
            this.lblProdutosPrincipal.Size = new System.Drawing.Size(89, 23);
            this.lblProdutosPrincipal.TabIndex = 8;
            this.lblProdutosPrincipal.Text = "Produtos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblProdutosPrincipal);
            this.Controls.Add(this.lblFornecedoresPrincipal);
            this.Controls.Add(this.lblProducaoPrincipal);
            this.Controls.Add(this.gridProdutosPrincipal);
            this.Controls.Add(this.gridProducaoPrincipal);
            this.Controls.Add(this.gridFornecedoresPrincipal);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedoresPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducaoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutosPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomeEmpresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProducao;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.DataGridView gridFornecedoresPrincipal;
        private System.Windows.Forms.DataGridView gridProducaoPrincipal;
        private System.Windows.Forms.DataGridView gridProdutosPrincipal;
        private System.Windows.Forms.Label lblProducaoPrincipal;
        private System.Windows.Forms.Label lblFornecedoresPrincipal;
        private System.Windows.Forms.Label lblProdutosPrincipal;
    }
}

