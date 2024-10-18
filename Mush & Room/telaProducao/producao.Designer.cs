namespace Mush___Room.telaProducao
{
    partial class producao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(producao));
            this.nomeEmpresa = new System.Windows.Forms.Label();
            this.logoEmpresa = new System.Windows.Forms.PictureBox();
            this.gridProducao = new System.Windows.Forms.DataGridView();
            this.lblNomeProducao = new System.Windows.Forms.Label();
            this.lblInfoProducao = new System.Windows.Forms.Label();
            this.lblIniProd = new System.Windows.Forms.Label();
            this.lblTrocaSubstrato = new System.Windows.Forms.Label();
            this.txtNomeProducao = new System.Windows.Forms.TextBox();
            this.txtInfoProducao = new System.Windows.Forms.TextBox();
            this.mskIniProducao = new System.Windows.Forms.MaskedTextBox();
            this.mskTrocaSubstrato = new System.Windows.Forms.MaskedTextBox();
            this.btnExcProd = new System.Windows.Forms.Button();
            this.btnAltProd = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.nomeEmpresa.TabIndex = 40;
            this.nomeEmpresa.Text = "Mush && Room";
            this.nomeEmpresa.Click += new System.EventHandler(this.nomeEmpresa_Click_1);
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
            this.logoEmpresa.Click += new System.EventHandler(this.logoEmpresa_Click_1);
            // 
            // gridProducao
            // 
            this.gridProducao.AllowUserToAddRows = false;
            this.gridProducao.AllowUserToDeleteRows = false;
            this.gridProducao.AllowUserToResizeColumns = false;
            this.gridProducao.AllowUserToResizeRows = false;
            this.gridProducao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducao.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducao.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProducao.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridProducao.Location = new System.Drawing.Point(513, 100);
            this.gridProducao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridProducao.MultiSelect = false;
            this.gridProducao.Name = "gridProducao";
            this.gridProducao.ReadOnly = true;
            this.gridProducao.RowHeadersVisible = false;
            this.gridProducao.RowHeadersWidth = 51;
            this.gridProducao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducao.RowTemplate.Height = 24;
            this.gridProducao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducao.Size = new System.Drawing.Size(571, 369);
            this.gridProducao.TabIndex = 42;
            this.gridProducao.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProducao_CellMouseDoubleClick_1);
            // 
            // lblNomeProducao
            // 
            this.lblNomeProducao.AutoSize = true;
            this.lblNomeProducao.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomeProducao.Location = new System.Drawing.Point(15, 166);
            this.lblNomeProducao.Name = "lblNomeProducao";
            this.lblNomeProducao.Size = new System.Drawing.Size(132, 17);
            this.lblNomeProducao.TabIndex = 43;
            this.lblNomeProducao.Text = "Nome da produção";
            // 
            // lblInfoProducao
            // 
            this.lblInfoProducao.AutoSize = true;
            this.lblInfoProducao.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoProducao.Location = new System.Drawing.Point(15, 208);
            this.lblInfoProducao.Name = "lblInfoProducao";
            this.lblInfoProducao.Size = new System.Drawing.Size(176, 17);
            this.lblInfoProducao.TabIndex = 44;
            this.lblInfoProducao.Text = "Informações da produção";
            // 
            // lblIniProd
            // 
            this.lblIniProd.AutoSize = true;
            this.lblIniProd.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblIniProd.Location = new System.Drawing.Point(15, 250);
            this.lblIniProd.Name = "lblIniProd";
            this.lblIniProd.Size = new System.Drawing.Size(132, 17);
            this.lblIniProd.TabIndex = 45;
            this.lblIniProd.Text = "Início da produção";
            // 
            // lblTrocaSubstrato
            // 
            this.lblTrocaSubstrato.AutoSize = true;
            this.lblTrocaSubstrato.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrocaSubstrato.Location = new System.Drawing.Point(15, 290);
            this.lblTrocaSubstrato.Name = "lblTrocaSubstrato";
            this.lblTrocaSubstrato.Size = new System.Drawing.Size(133, 17);
            this.lblTrocaSubstrato.TabIndex = 46;
            this.lblTrocaSubstrato.Text = "Troca de substrato";
            // 
            // txtNomeProducao
            // 
            this.txtNomeProducao.Location = new System.Drawing.Point(205, 161);
            this.txtNomeProducao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProducao.Name = "txtNomeProducao";
            this.txtNomeProducao.Size = new System.Drawing.Size(265, 22);
            this.txtNomeProducao.TabIndex = 47;
            this.txtNomeProducao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeProducao_KeyPress);
            // 
            // txtInfoProducao
            // 
            this.txtInfoProducao.Location = new System.Drawing.Point(205, 203);
            this.txtInfoProducao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfoProducao.Name = "txtInfoProducao";
            this.txtInfoProducao.Size = new System.Drawing.Size(265, 22);
            this.txtInfoProducao.TabIndex = 48;
            this.txtInfoProducao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfoProducao_KeyPress);
            // 
            // mskIniProducao
            // 
            this.mskIniProducao.Location = new System.Drawing.Point(205, 245);
            this.mskIniProducao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskIniProducao.Mask = "00/00/0000";
            this.mskIniProducao.Name = "mskIniProducao";
            this.mskIniProducao.Size = new System.Drawing.Size(81, 22);
            this.mskIniProducao.TabIndex = 49;
            this.mskIniProducao.ValidatingType = typeof(System.DateTime);
            // 
            // mskTrocaSubstrato
            // 
            this.mskTrocaSubstrato.Location = new System.Drawing.Point(201, 286);
            this.mskTrocaSubstrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTrocaSubstrato.Mask = "00/00/0000";
            this.mskTrocaSubstrato.Name = "mskTrocaSubstrato";
            this.mskTrocaSubstrato.Size = new System.Drawing.Size(85, 22);
            this.mskTrocaSubstrato.TabIndex = 50;
            this.mskTrocaSubstrato.ValidatingType = typeof(System.DateTime);
            // 
            // btnExcProd
            // 
            this.btnExcProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnExcProd.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnExcProd.Location = new System.Drawing.Point(64, 369);
            this.btnExcProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcProd.Name = "btnExcProd";
            this.btnExcProd.Size = new System.Drawing.Size(128, 58);
            this.btnExcProd.TabIndex = 51;
            this.btnExcProd.Text = "Excluir produção";
            this.btnExcProd.UseVisualStyleBackColor = false;
            this.btnExcProd.Click += new System.EventHandler(this.btnExcProd_Click);
            // 
            // btnAltProd
            // 
            this.btnAltProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnAltProd.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAltProd.Location = new System.Drawing.Point(201, 369);
            this.btnAltProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltProd.Name = "btnAltProd";
            this.btnAltProd.Size = new System.Drawing.Size(128, 58);
            this.btnAltProd.TabIndex = 52;
            this.btnAltProd.Text = "Alterar dados \r\nda produção";
            this.btnAltProd.UseVisualStyleBackColor = false;
            this.btnAltProd.Click += new System.EventHandler(this.btnAltProd_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.Chocolate;
            this.btnCadProd.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadProd.Location = new System.Drawing.Point(335, 369);
            this.btnCadProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(128, 58);
            this.btnCadProd.TabIndex = 53;
            this.btnCadProd.Text = "Cadastrar produção";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(379, 270);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 41);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.produçãoToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.produçãoToolStripMenuItem.Text = "Produção";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click_1);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click_1);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click_1);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
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
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1099, 543);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.btnAltProd);
            this.Controls.Add(this.btnExcProd);
            this.Controls.Add(this.mskTrocaSubstrato);
            this.Controls.Add(this.mskIniProducao);
            this.Controls.Add(this.txtInfoProducao);
            this.Controls.Add(this.txtNomeProducao);
            this.Controls.Add(this.lblTrocaSubstrato);
            this.Controls.Add(this.lblIniProd);
            this.Controls.Add(this.lblInfoProducao);
            this.Controls.Add(this.lblNomeProducao);
            this.Controls.Add(this.gridProducao);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.logoEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "producao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de produção";
            this.Load += new System.EventHandler(this.producao_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.logoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomeEmpresa;
        private System.Windows.Forms.PictureBox logoEmpresa;
        private System.Windows.Forms.DataGridView gridProducao;
        private System.Windows.Forms.Label lblNomeProducao;
        private System.Windows.Forms.Label lblInfoProducao;
        private System.Windows.Forms.Label lblIniProd;
        private System.Windows.Forms.Label lblTrocaSubstrato;
        private System.Windows.Forms.TextBox txtNomeProducao;
        private System.Windows.Forms.TextBox txtInfoProducao;
        private System.Windows.Forms.MaskedTextBox mskIniProducao;
        private System.Windows.Forms.MaskedTextBox mskTrocaSubstrato;
        private System.Windows.Forms.Button btnExcProd;
        private System.Windows.Forms.Button btnAltProd;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}