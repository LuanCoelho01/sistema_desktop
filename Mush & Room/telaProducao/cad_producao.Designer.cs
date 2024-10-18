namespace Mush___Room.telaProducao
{
    partial class cad_producao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cad_producao));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProducao = new System.Windows.Forms.TextBox();
            this.txtInfoProducao = new System.Windows.Forms.TextBox();
            this.txtIniProducao = new System.Windows.Forms.MaskedTextBox();
            this.txtTrocaSubstrato = new System.Windows.Forms.MaskedTextBox();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Troca do substrato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Início da produção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Informações produção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome da produção";
            // 
            // txtNomeProducao
            // 
            this.txtNomeProducao.Location = new System.Drawing.Point(28, 39);
            this.txtNomeProducao.Name = "txtNomeProducao";
            this.txtNomeProducao.Size = new System.Drawing.Size(147, 20);
            this.txtNomeProducao.TabIndex = 18;
            // 
            // txtInfoProducao
            // 
            this.txtInfoProducao.Location = new System.Drawing.Point(240, 39);
            this.txtInfoProducao.Name = "txtInfoProducao";
            this.txtInfoProducao.Size = new System.Drawing.Size(147, 20);
            this.txtInfoProducao.TabIndex = 19;
            // 
            // txtIniProducao
            // 
            this.txtIniProducao.Location = new System.Drawing.Point(28, 113);
            this.txtIniProducao.Mask = "00/00/0000";
            this.txtIniProducao.Name = "txtIniProducao";
            this.txtIniProducao.Size = new System.Drawing.Size(147, 20);
            this.txtIniProducao.TabIndex = 23;
            this.txtIniProducao.ValidatingType = typeof(System.DateTime);
            // 
            // txtTrocaSubstrato
            // 
            this.txtTrocaSubstrato.Location = new System.Drawing.Point(240, 113);
            this.txtTrocaSubstrato.Mask = "00/00/0000";
            this.txtTrocaSubstrato.Name = "txtTrocaSubstrato";
            this.txtTrocaSubstrato.Size = new System.Drawing.Size(147, 20);
            this.txtTrocaSubstrato.TabIndex = 24;
            this.txtTrocaSubstrato.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.Chocolate;
            this.btnCadProd.Location = new System.Drawing.Point(151, 170);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(107, 41);
            this.btnCadProd.TabIndex = 25;
            this.btnCadProd.Text = "Cadastrar \r\nprodução";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // cad_producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(399, 244);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.txtTrocaSubstrato);
            this.Controls.Add(this.txtIniProducao);
            this.Controls.Add(this.txtInfoProducao);
            this.Controls.Add(this.txtNomeProducao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cad_producao";
            this.Text = "Cadastro de produção";
            this.Load += new System.EventHandler(this.cad_producao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProducao;
        private System.Windows.Forms.TextBox txtInfoProducao;
        private System.Windows.Forms.MaskedTextBox txtIniProducao;
        private System.Windows.Forms.MaskedTextBox txtTrocaSubstrato;
        private System.Windows.Forms.Button btnCadProd;
    }
}