using SistemaOrcamento.Entidades;
using SistemaOrcamento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.View
{
    public partial class FormFornecedores : Form
    {
        FornecedorModel model = new FornecedorModel();

        public FormFornecedores()
        {
            InitializeComponent();
            rbNome.Checked = true;
            Listar();
            btnSalvar.Enabled = false;  
            btnEditar.Enabled = false;  
            btnExcluir.Enabled = false;
        }

        /// <summary>
        /// metodo para incluir novo fornecedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();//chamada para habilitar os campos. Deixa acessivel para preencher os dados
            Limpar();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;  
        }

        /// <summary>
        /// metodo para habilitar os campos
        /// </summary>
        private void HabilitarCampos()
        {
            txtNome.Enabled= true;
            txtCnpj.Enabled= true;
            txtEndereco.Enabled= true;
            txtTelefone.Enabled= true;  
        }

        /// <summary>
        /// metodo para desabilitar os campos
        /// </summary>
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCnpj.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
        }

        /// <summary>
        /// metodo de limpar os campos do formulario
        /// </summary>
        public void Limpar()
        {
            txtNome.Select();//quando limpar posicionar mouse no campo nome

            txtNome.Text = "";
            txtCnpj.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtBuscar.Text = "";
            txtBuscarCnpj.Text = "";
            txtCodigo.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCnpj.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            Fornecedores dados = new Fornecedores();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampos();    
        }

        private void Salvar(Fornecedores dado)
        {
            try
            {
                dado.Nome = txtNome.Text;
                dado.Cnpj = txtCnpj.Text;
                dado.Endereco = txtEndereco.Text;   
                dado.Telefone= txtTelefone.Text;
                model.Salvar(dado);

                MessageBox.Show("Fornecedor Salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar Fornecedor."+ ex.Message);
            }
        }

        private void Listar()
        {
            try
            {
                dgFornecedores.DataSource = model.Listar();//datasource recebe dados
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(Fornecedores dado)
        {
            try
            {
                dado.Id_fornecedor = Convert.ToInt32(txtCodigo.Text);

                model.Excluir(dado);
                MessageBox.Show("Fornecedor excluido com Sucesso.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Editar(Fornecedores dado)
        {
            try
            {
                dado.Id_fornecedor = Convert.ToInt32(txtCodigo.Text);
                dado.Nome = txtNome.Text;
                dado.Telefone = txtTelefone.Text;
                dado.Cnpj = txtCnpj.Text;    
                dado.Endereco = txtEndereco.Text;

                model.Editar(dado);
                MessageBox.Show("Fornecedor editado com Sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void dgFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtCnpj.Text = dgFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = dgFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgFornecedores.CurrentRow.Cells[3].Value.ToString();
            txtCodigo.Text = dgFornecedores.CurrentRow.Cells[0].Value.ToString();
            HabilitarCampos();

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;  
            btnSalvar.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fornecedores dados = new Fornecedores();
            Buscar(dados);

            if (txtBuscar.Text == "")
            {
                Listar();
                return;
            }
        }

        private void txtBuscarCnpj_TextChanged(object sender, EventArgs e)
        {
            Fornecedores dados = new Fornecedores();
            Buscar(dados);

            if (txtBuscarCnpj.Text == "")
            {
                Listar();
                return;
            }
        }

        public void Buscar(Fornecedores dado)
        {
            try
            {
                dado.Nome = txtBuscar.Text;
                dado.Cnpj = txtBuscarCnpj.Text;
                dgFornecedores.DataSource = model.Buscar(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar dados na busca."+ex.Message);
            }
        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarCnpj.Visible = true;
            txtBuscar.Visible = false;
            txtBuscar.Text = "?";
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;
            txtBuscarCnpj.Visible = false;
            txtBuscarCnpj.Text = "";
            txtBuscar.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro.");
                return;
            }
            Fornecedores dados = new Fornecedores();
            Editar(dados);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro.");
                return; 

            }

            if (MessageBox.Show("Deseja excluir Fornecedor?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) 
            {
                return;
            }
            Fornecedores dados = new Fornecedores();
            Excluir(dados);
            Listar();
            Limpar();
            DesabilitarCampos();    
        }
    }
}
