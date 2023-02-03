namespace SistemaOrcamento
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRÇAMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOORÇAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMPRIMIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROSToolStripMenuItem,
            this.oRÇAMENTOSToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUTOSToolStripMenuItem,
            this.fORNECEDORESToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.uNIDADESToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cADASTROSToolStripMenuItem.Image")));
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS";
            // 
            // pRODUTOSToolStripMenuItem
            // 
            this.pRODUTOSToolStripMenuItem.Name = "pRODUTOSToolStripMenuItem";
            this.pRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pRODUTOSToolStripMenuItem.Text = "PRODUTOS";
            // 
            // fORNECEDORESToolStripMenuItem
            // 
            this.fORNECEDORESToolStripMenuItem.Name = "fORNECEDORESToolStripMenuItem";
            this.fORNECEDORESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fORNECEDORESToolStripMenuItem.Text = "FORNECEDORES";
            this.fORNECEDORESToolStripMenuItem.Click += new System.EventHandler(this.fORNECEDORESToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // uNIDADESToolStripMenuItem
            // 
            this.uNIDADESToolStripMenuItem.Name = "uNIDADESToolStripMenuItem";
            this.uNIDADESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uNIDADESToolStripMenuItem.Text = "UNIDADES";
            // 
            // oRÇAMENTOSToolStripMenuItem
            // 
            this.oRÇAMENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOORÇAMENTOToolStripMenuItem,
            this.iMPRIMIRToolStripMenuItem});
            this.oRÇAMENTOSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oRÇAMENTOSToolStripMenuItem.Image")));
            this.oRÇAMENTOSToolStripMenuItem.Name = "oRÇAMENTOSToolStripMenuItem";
            this.oRÇAMENTOSToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.oRÇAMENTOSToolStripMenuItem.Text = "ORÇAMENTOS";
            // 
            // nOVOORÇAMENTOToolStripMenuItem
            // 
            this.nOVOORÇAMENTOToolStripMenuItem.Name = "nOVOORÇAMENTOToolStripMenuItem";
            this.nOVOORÇAMENTOToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.nOVOORÇAMENTOToolStripMenuItem.Text = "NOVO ORÇAMENTO";
            // 
            // iMPRIMIRToolStripMenuItem
            // 
            this.iMPRIMIRToolStripMenuItem.Name = "iMPRIMIRToolStripMenuItem";
            this.iMPRIMIRToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.iMPRIMIRToolStripMenuItem.Text = "IMPRIMIR";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAIRToolStripMenuItem1});
            this.sAIRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sAIRToolStripMenuItem.Image")));
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            // 
            // sAIRToolStripMenuItem1
            // 
            this.sAIRToolStripMenuItem1.Name = "sAIRToolStripMenuItem1";
            this.sAIRToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.sAIRToolStripMenuItem1.Text = "SAIR";
            this.sAIRToolStripMenuItem1.Click += new System.EventHandler(this.sAIRToolStripMenuItem1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systems";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNIDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRÇAMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOORÇAMENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMPRIMIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem1;
    }
}

