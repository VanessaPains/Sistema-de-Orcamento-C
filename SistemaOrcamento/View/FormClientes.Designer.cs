namespace SistemaOrcamento.View
{
    partial class FormClientes
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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbluscar = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCadastroClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
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
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(311, 105);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(479, 308);
            this.dgClientes.TabIndex = 35;
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
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(95, 132);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(197, 21);
            this.txtTelefone.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(95, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 21);
            this.txtEmail.TabIndex = 26;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(38, 162);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(51, 13);
            this.lblEndereco.TabIndex = 25;
            this.lblEndereco.Text = "EMAIL:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(13, 135);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(76, 13);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(95, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 21);
            this.txtNome.TabIndex = 22;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "NOME:";
            // 
            // lblCadastroClientes
            // 
            this.lblCadastroClientes.AutoSize = true;
            this.lblCadastroClientes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroClientes.Location = new System.Drawing.Point(14, 9);
            this.lblCadastroClientes.Name = "lblCadastroClientes";
            this.lblCadastroClientes.Size = new System.Drawing.Size(276, 23);
            this.lblCadastroClientes.TabIndex = 20;
            this.lblCadastroClientes.Text = "CADASTRO DE CLIENTES";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbluscar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastroClientes);
            this.MaximizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systems";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbluscar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCadastroClientes;
    }
}