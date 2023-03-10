using SistemaOrcamento.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();//sair sistema
        }

        private void fORNECEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFornecedores form = new FormFornecedores();//ir parapagina de 
            form.ShowDialog();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();//ir parapagina de 
            form.ShowDialog();
        }

        private void uNIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnidades form = new FormUnidades();//ir parapagina de 
            form.ShowDialog();
        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();//ir parapagina de 
            form.ShowDialog();
        }

        private void nOVOORÇAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrcamentos form = new FormOrcamentos();//ir parapagina de 
            form.ShowDialog();
        }
    }
}
