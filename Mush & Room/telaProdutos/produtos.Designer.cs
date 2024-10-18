namespace Mush___Room.telaProdutos
{
    partial class produtos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produtos));
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.nomeEmpresa = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.btnAltProduto = new System.Windows.Forms.Button();
            this.btnExcProduto = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblInfoProduto = new System.Windows.Forms.Label();
            this.lblQtdMin = new System.Windows.Forms.Label();
            this.lblQtdEst = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtInfoProduto = new System.Windows.Forms.TextBox();
            this.txtQtdMin = new System.Windows.Forms.TextBox();
            this.txtQtdEst = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // logoEmpresa
            // 
            this.logoEmpresa.Image = global::Mush___Room.Properties.Resources.mushroom_icon_138360;
            this.logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.logoEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.logoEmpresa.Name = "logoEmpresa";
            this.logoEmpresa.Size = new System.Drawing.Size(93, 62);
            this.logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoEmpresa.TabIndex = 11;
            this.logoEmpresa.TabStop = false;
            this.logoEmpresa.Click += new System.EventHandler(this.logoEmpresa_Click_1);
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.AutoSize = true;
            this.nomeEmpresa.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2F);
            this.nomeEmpresa.Location = new System.Drawing.Point(80, 37);
            this.nomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.Size = new System.Drawing.Size(112, 25);
            this.nomeEmpresa.TabIndex = 12;
            this.nomeEmpresa.Text = "Mush && Room";
            this.nomeEmpresa.Click += new System.EventHandler(this.nomeEmpresa_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
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
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.produçãoToolStripMenuItem.Text = "Produção";
            this.produçãoToolStripMenuItem.Click += new System.EventHandler(this.produçãoToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.AllowUserToResizeColumns = false;
            this.gridProdutos.AllowUserToResizeRows = false;
            this.gridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdutos.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridProdutos.Location = new System.Drawing.Point(513, 100);
            this.gridProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.gridProdutos.Name = "gridProdutos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowHeadersWidth = 51;
            this.gridProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProdutos.Size = new System.Drawing.Size(571, 369);
            this.gridProdutos.TabIndex = 14;
            this.gridProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridProdutos_MouseDoubleClick);
            // 
            // btnAltProduto
            // 
            this.btnAltProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnAltProduto.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAltProduto.Location = new System.Drawing.Point(201, 369);
            this.btnAltProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltProduto.Name = "btnAltProduto";
            this.btnAltProduto.Size = new System.Drawing.Size(128, 58);
            this.btnAltProduto.TabIndex = 17;
            this.btnAltProduto.Text = "Alterar dados\r\ndo produto\r\n";
            this.btnAltProduto.UseVisualStyleBackColor = false;
            this.btnAltProduto.Click += new System.EventHandler(this.btnAltProduto_Click);
            // 
            // btnExcProduto
            // 
            this.btnExcProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnExcProduto.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnExcProduto.Location = new System.Drawing.Point(64, 369);
            this.btnExcProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcProduto.Name = "btnExcProduto";
            this.btnExcProduto.Size = new System.Drawing.Size(128, 58);
            this.btnExcProduto.TabIndex = 18;
            this.btnExcProduto.Text = "Excluir\r\nproduto\r\n";
            this.btnExcProduto.UseVisualStyleBackColor = false;
            this.btnExcProduto.Click += new System.EventHandler(this.btnExcProduto_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.Color.Chocolate;
            this.btnCadProduto.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadProduto.Location = new System.Drawing.Point(335, 369);
            this.btnCadProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(128, 58);
            this.btnCadProduto.TabIndex = 19;
            this.btnCadProduto.Text = "Registrar produto";
            this.btnCadProduto.UseVisualStyleBackColor = false;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomeProduto.Location = new System.Drawing.Point(15, 166);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(123, 17);
            this.lblNomeProduto.TabIndex = 20;
            this.lblNomeProduto.Text = "Nome do produto";
            // 
            // lblInfoProduto
            // 
            this.lblInfoProduto.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoProduto.Location = new System.Drawing.Point(15, 208);
            this.lblInfoProduto.Name = "lblInfoProduto";
            this.lblInfoProduto.Size = new System.Drawing.Size(185, 16);
            this.lblInfoProduto.TabIndex = 21;
            this.lblInfoProduto.Text = "Informações do produto";
            // 
            // lblQtdMin
            // 
            this.lblQtdMin.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblQtdMin.Location = new System.Drawing.Point(15, 250);
            this.lblQtdMin.Name = "lblQtdMin";
            this.lblQtdMin.Size = new System.Drawing.Size(172, 16);
            this.lblQtdMin.TabIndex = 22;
            this.lblQtdMin.Text = "Quantidade mínima";
            // 
            // lblQtdEst
            // 
            this.lblQtdEst.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblQtdEst.Location = new System.Drawing.Point(15, 290);
            this.lblQtdEst.Name = "lblQtdEst";
            this.lblQtdEst.Size = new System.Drawing.Size(181, 16);
            this.lblQtdEst.TabIndex = 23;
            this.lblQtdEst.Text = "Quantidade em estoque";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(205, 161);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(265, 22);
            this.txtNomeProduto.TabIndex = 24;
            this.txtNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeProduto_KeyPress);
            // 
            // txtInfoProduto
            // 
            this.txtInfoProduto.Location = new System.Drawing.Point(205, 203);
            this.txtInfoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfoProduto.Name = "txtInfoProduto";
            this.txtInfoProduto.Size = new System.Drawing.Size(265, 22);
            this.txtInfoProduto.TabIndex = 25;
            this.txtInfoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfoProduto_KeyPress);
            // 
            // txtQtdMin
            // 
            this.txtQtdMin.Location = new System.Drawing.Point(205, 245);
            this.txtQtdMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdMin.Name = "txtQtdMin";
            this.txtQtdMin.Size = new System.Drawing.Size(120, 22);
            this.txtQtdMin.TabIndex = 26;
            this.txtQtdMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdMin_KeyPress);
            // 
            // txtQtdEst
            // 
            this.txtQtdEst.Location = new System.Drawing.Point(205, 284);
            this.txtQtdEst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdEst.Name = "txtQtdEst";
            this.txtQtdEst.Size = new System.Drawing.Size(120, 22);
            this.txtQtdEst.TabIndex = 27;
            this.txtQtdEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdEst_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(379, 270);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 41);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1099, 543);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtQtdEst);
            this.Controls.Add(this.txtQtdMin);
            this.Controls.Add(this.txtInfoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblQtdEst);
            this.Controls.Add(this.lblQtdMin);
            this.Controls.Add(this.lblInfoProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.btnCadProduto);
            this.Controls.Add(this.btnExcProduto);
            this.Controls.Add(this.btnAltProduto);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.logoEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de produtos";
            this.Load += new System.EventHandler(this.produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
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
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.Button btnAltProduto;
        private System.Windows.Forms.Button btnExcProduto;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblInfoProduto;
        private System.Windows.Forms.Label lblQtdMin;
        private System.Windows.Forms.Label lblQtdEst;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtInfoProduto;
        private System.Windows.Forms.TextBox txtQtdMin;
        private System.Windows.Forms.TextBox txtQtdEst;
        private System.Windows.Forms.Button btnCancelar;
    }
}