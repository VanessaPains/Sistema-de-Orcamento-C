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
    }
}
