namespace SistemaOrcamento.View
{
    partial class FormOrcamentos
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgOrcamentos = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbluscar = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtNumeroOrcamento = new System.Windows.Forms.TextBox();
            this.lblNumeroOrcamento = new System.Windows.Forms.Label();
            this.lblCadastroOrcamentos = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(371, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 10);
            this.label7.TabIndex = 36;
            this.label7.Text = "PRC Sytems @";
            // 
            // dgOrcamentos
            // 
            this.dgOrcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrcamentos.Location = new System.Drawing.Point(311, 105);
            this.dgOrcamentos.Name = "dgOrcamentos";
            this.dgOrcamentos.Size = new System.Drawing.Size(479, 308);
            this.dgOrcamentos.TabIndex = 35;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(553, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(634, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(715, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(472, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(593, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(197, 21);
            this.txtBuscar.TabIndex = 30;
            // 
            // lbluscar
            // 
            this.lbluscar.AutoSize = true;
            this.lbluscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluscar.Location = new System.Drawing.Point(526, 75);
            this.lbluscar.Name = "lbluscar";
            this.lbluscar.Size = new System.Drawing.Size(61, 13);
            this.lbluscar.TabIndex = 29;
            this.lbluscar.Text = "BUSCAR:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(6, 135);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 13);
            this.lblQuantidade.TabIndex = 23;
            this.lblQuantidade.Text = "QUANTIDADE:";
            // 
            // txtNumeroOrcamento
            // 
            this.txtNumeroOrcamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrcamento.Location = new System.Drawing.Point(139, 105);
            this.txtNumeroOrcamento.Name = "txtNumeroOrcamento";
            this.txtNumeroOrcamento.Size = new System.Drawing.Size(166, 21);
            this.txtNumeroOrcamento.TabIndex = 22;
            // 
            // lblNumeroOrcamento
            // 
            this.lblNumeroOrcamento.AutoSize = true;
            this.lblNumeroOrcamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrcamento.Location = new System.Drawing.Point(24, 108);
            this.lblNumeroOrcamento.Name = "lblNumeroOrcamento";
            this.lblNumeroOrcamento.Size = new System.Drawing.Size(109, 13);
            this.lblNumeroOrcamento.TabIndex = 21;
            this.lblNumeroOrcamento.Text = "Nº ORÇAMENTO:";
            // 
            // lblCadastroOrcamentos
            // 
            this.lblCadastroOrcamentos.AutoSize = true;
            this.lblCadastroOrcamentos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroOrcamentos.Location = new System.Drawing.Point(14, 9);
            this.lblCadastroOrcamentos.Name = "lblCadastroOrcamentos";
            this.lblCadastroOrcamentos.Size = new System.Drawing.Size(321, 23);
            this.lblCadastroOrcamentos.TabIndex = 20;
            this.lblCadastroOrcamentos.Text = "CADASTRO DE ORÇAMENTOS";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(108, 132);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(197, 21);
            this.txtQuantidade.TabIndex = 37;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(108, 186);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(197, 21);
            this.cbCliente.TabIndex = 46;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(32, 189);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(65, 13);
            this.lblUnidade.TabIndex = 45;
            this.lblUnidade.Text = "CLIENTE:";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(108, 159);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(197, 21);
            this.cbProduto.TabIndex = 44;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(31, 162);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(71, 13);
            this.lblProduto.TabIndex = 43;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // FormOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgOrcamentos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbluscar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtNumeroOrcamento);
            this.Controls.Add(this.lblNumeroOrcamento);
            this.Controls.Add(this.lblCadastroOrcamentos);
            this.MaximizeBox = false;
            this.Name = "FormOrcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Sytems";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgOrcamentos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbluscar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtNumeroOrcamento;
        private System.Windows.Forms.Label lblNumeroOrcamento;
        private System.Windows.Forms.Label lblCadastroOrcamentos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label lblProduto;
    }
}