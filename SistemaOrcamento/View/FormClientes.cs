using MySql.Data.MySqlClient.Memcached;
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
    public partial class FormClientes : Form
    {
        ClienteModel model = new ClienteModel();

        public FormClientes()
        {  
            InitializeComponent();
            Listar();
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            DesabilitarCampos();
        }

        private void Listar()
        {
            try
            {
                dgClientes.DataSource = model.Listar();//datasource recebe dados
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            Clientes dados = new Clientes();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro.");
                return;
            }
            Clientes dados = new Clientes();
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

            if (MessageBox.Show("Deseja excluir Cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Clientes dados = new Clientes();
            Excluir(dados);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgClientes.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = dgClientes.CurrentRow.Cells[2].Value.ToString();
            txtCodigo.Text = dgClientes.CurrentRow.Cells[0].Value.ToString();
            HabilitarCampos();

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Clientes dados = new Clientes();
            Buscar(dados);

            if (txtBuscar.Text == "")
            {
                Listar();
                return;
            }
        }

        /// <summary>
        /// metodo para habilitar os campos
        /// </summary>
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;    
        }

        /// <summary>
        /// metodo para desabilitar os campos
        /// </summary>
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;   
        }

        /// <summary>
        /// metodo de limpar os campos do formulario
        /// </summary>
        public void Limpar()
        {
            txtNome.Select();//quando limpar posicionar mouse no campo nome

            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtBuscar.Text = "";
            txtCodigo.Text = "";
        }

        private void Salvar(Clientes dado)
        {
            try
            {
                dado.Nome = txtNome.Text;
                dado.Telefone = txtTelefone.Text;
                dado.Email = txtEmail.Text; 
                model.Salvar(dado);

                MessageBox.Show("Cliente Salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar Cliente." + ex.Message);
            }
        }

        public void Excluir(Clientes dado)
        {
            try
            {
                dado.Id_cliente = Convert.ToInt32(txtCodigo.Text);

                model.Excluir(dado);
                MessageBox.Show("Cliente excluido com Sucesso.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Editar(Clientes dado)
        {
            try
            {
                dado.Id_cliente = Convert.ToInt32(txtCodigo.Text);
                dado.Nome = txtNome.Text;
                dado.Telefone = txtTelefone.Text;
                dado.Email = txtEmail.Text;


                model.Editar(dado);
                MessageBox.Show("Cliente editado com Sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Buscar(Clientes dado)
        {
            try
            {
                dado.Nome = txtBuscar.Text;
                dgClientes.DataSource = model.Buscar(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar dados na busca." + ex.Message);
            }
        }


    }
}

