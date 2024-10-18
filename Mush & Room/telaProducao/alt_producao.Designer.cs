namespace Mush___Room.telaProducao
{
    partial class alt_producao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alt_producao));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAltNomeProducao = new System.Windows.Forms.TextBox();
            this.txtAltInfoProducao = new System.Windows.Forms.TextBox();
            this.txtAltIniProducao = new System.Windows.Forms.MaskedTextBox();
            this.txtAltTrocaSubstrato = new System.Windows.Forms.MaskedTextBox();
            this.btnAltProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Troca do substrato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Início da produção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informações produção";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nome da produção";
            // 
            // txtAltNomeProducao
            // 
            this.txtAltNomeProducao.Location = new System.Drawing.Point(28, 39);
            this.txtAltNomeProducao.Name = "txtAltNomeProducao";
            this.txtAltNomeProducao.Size = new System.Drawing.Size(147, 20);
            this.txtAltNomeProducao.TabIndex = 22;
            // 
            // txtAltInfoProducao
            // 
            this.txtAltInfoProducao.Location = new System.Drawing.Point(240, 39);
            this.txtAltInfoProducao.Name = "txtAltInfoProducao";
            this.txtAltInfoProducao.Size = new System.Drawing.Size(147, 20);
            this.txtAltInfoProducao.TabIndex = 23;
            // 
            // txtAltIniProducao
            // 
            this.txtAltIniProducao.Location = new System.Drawing.Point(28, 113);
            this.txtAltIniProducao.Mask = "00/00/0000";
            this.txtAltIniProducao.Name = "txtAltIniProducao";
            this.txtAltIniProducao.Size = new System.Drawing.Size(147, 20);
            this.txtAltIniProducao.TabIndex = 27;
            // 
            // txtAltTrocaSubstrato
            // 
            this.txtAltTrocaSubstrato.Location = new System.Drawing.Point(240, 113);
            this.txtAltTrocaSubstrato.Mask = "00/00/0000";
            this.txtAltTrocaSubstrato.Name = "txtAltTrocaSubstrato";
            this.txtAltTrocaSubstrato.Size = new System.Drawing.Size(147, 20);
            this.txtAltTrocaSubstrato.TabIndex = 28;
            // 
            // btnAltProd
            // 
            this.btnAltProd.BackColor = System.Drawing.Color.Chocolate;
            this.btnAltProd.Location = new System.Drawing.Point(149, 165);
            this.btnAltProd.Name = "btnAltProd";
            this.btnAltProd.Size = new System.Drawing.Size(107, 41);
            this.btnAltProd.TabIndex = 29;
            this.btnAltProd.Text = "Alterar \r\nprodução";
            this.btnAltProd.UseVisualStyleBackColor = false;
            this.btnAltProd.Click += new System.EventHandler(this.btnAltProd_Click_1);
            // 
            // alt_producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(399, 244);
            this.Controls.Add(this.btnAltProd);
            this.Controls.Add(this.txtAltTrocaSubstrato);
            this.Controls.Add(this.txtAltIniProducao);
            this.Controls.Add(this.txtAltInfoProducao);
            this.Controls.Add(this.txtAltNomeProducao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alt_producao";
            this.Text = "Alterar dados de produção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltInfoProducao;
        public System.Windows.Forms.TextBox txtAltNomeProducao;
        private System.Windows.Forms.MaskedTextBox txtAltIniProducao;
        private System.Windows.Forms.MaskedTextBox txtAltTrocaSubstrato;
        private System.Windows.Forms.Button btnAltProd;
    }
}