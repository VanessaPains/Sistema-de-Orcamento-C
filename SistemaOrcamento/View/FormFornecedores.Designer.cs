namespace SistemaOrcamento.View
{
    partial class FormFornecedores
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
            this.lblCadastroFornecedores = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.txtBuscarCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastroFornecedores
            // 
            this.lblCadastroFornecedores.AutoSize = true;
            this.lblCadastroFornecedores.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroFornecedores.Location = new System.Drawing.Point(12, 9);
            this.lblCadastroFornecedores.Name = "lblCadastroFornecedores";
            this.lblCadastroFornecedores.Size = new System.Drawing.Size(344, 23);
            this.lblCadastroFornecedores.TabIndex = 1;
            this.lblCadastroFornecedores.Text = "CADASTRO DE FORNECEDORES";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(37, 135);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(90, 132);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 21);
            this.txtNome.TabIndex = 1;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(42, 162);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(42, 13);
            this.lblCnpj.TabIndex = 4;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(8, 188);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(76, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(90, 212);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(197, 21);
            this.txtEndereco.TabIndex = 4;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(6, 215);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(90, 159);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(197, 21);
            this.txtCnpj.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(90, 185);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(197, 21);
            this.txtTelefone.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(591, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(197, 21);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(470, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(713, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(632, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(551, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgFornecedores
            // 
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Location = new System.Drawing.Point(309, 105);
            this.dgFornecedores.Name = "dgFornecedores";
            this.dgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedores.Size = new System.Drawing.Size(479, 308);
            this.dgFornecedores.TabIndex = 18;
            this.dgFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFornecedores_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(369, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 10);
            this.label7.TabIndex = 19;
            this.label7.Text = "PRC Sytems @";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(449, 72);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(136, 17);
            this.rbNome.TabIndex = 20;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Buscar por Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCnpj.Location = new System.Drawing.Point(313, 72);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(130, 17);
            this.rbCnpj.TabIndex = 21;
            this.rbCnpj.TabStop = true;
            this.rbCnpj.Text = "Buscar por CNPJ";
            this.rbCnpj.UseVisualStyleBackColor = true;
            this.rbCnpj.CheckedChanged += new System.EventHandler(this.rbCnpj_CheckedChanged);
            // 
            // txtBuscarCnpj
            // 
            this.txtBuscarCnpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCnpj.Location = new System.Drawing.Point(591, 72);
            this.txtBuscarCnpj.Mask = "00.000.000/0000-00";
            this.txtBuscarCnpj.Name = "txtBuscarCnpj";
            this.txtBuscarCnpj.Size = new System.Drawing.Size(197, 21);
            this.txtBuscarCnpj.TabIndex = 22;
            this.txtBuscarCnpj.Visible = false;
            this.txtBuscarCnpj.TextChanged += new System.EventHandler(this.txtBuscarCnpj_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(90, 105);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 21);
            this.txtCodigo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "CODIGO:";
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarCnpj);
            this.Controls.Add(this.rbCnpj);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgFornecedores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastroFornecedores);
            this.MaximizeBox = false;
            this.Name = "FormFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systems";
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroFornecedores;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.MaskedTextBox txtBuscarCnpj;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}