using SistemaOrcamento.Entidades;
using SistemaOrcamento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.View
{
    public partial class FormUnidades : Form
    {
        UnidadeModel model = new UnidadeModel();

        public FormUnidades()
        {
            InitializeComponent();
            Listar();
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            DesabilitarCampos();
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
            if(txtUnidade.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            Unidades dados = new Unidades();
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
            Unidades dados = new Unidades();
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

            if (MessageBox.Show("Deseja excluir Unidade?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Unidades dados = new Unidades();
            Excluir(dados);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void dgUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgUnidades.CurrentRow.Cells[0].Value.ToString();
            txtUnidade.Text = dgUnidades.CurrentRow.Cells[1].Value.ToString();

            HabilitarCampos();

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Unidades dados = new Unidades();
            Buscar(dados);

            if (txtBuscar.Text == "")
            {
                Listar();
                return;
            }
        }

        private void Listar()
        {
            try
            {
                dgUnidades.DataSource = model.Listar();//datasource recebe dados
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// metodo para habilitar os campos
        /// </summary>
        private void HabilitarCampos()
        {
            txtUnidade.Enabled = true;
        }

        /// <summary>
        /// metodo para desabilitar os campos
        /// </summary>
        private void DesabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtUnidade.Enabled = false;
        }

        /// <summary>
        /// metodo de limpar os campos do formulario
        /// </summary>
        public void Limpar()
        {
            txtUnidade.Select();//quando limpar posicionar mouse no campo nome

            txtCodigo.Text = "";
            txtUnidade.Text = "";
        }

        private void Salvar(Unidades dado)
        {
            try
            {
                dado.Unidade = txtUnidade.Text;
                model.Salvar(dado);

                MessageBox.Show("Unidade Salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar Unidade." + ex.Message);
            }
        }

        public void Excluir(Unidades dado)
        {
            try
            {
                dado.Id_unidade = Convert.ToInt32(txtCodigo.Text);

                model.Excluir(dado);
                MessageBox.Show("Unidade excluido com Sucesso.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Editar(Unidades dado)
        {
            try
            {
                dado.Id_unidade = Convert.ToInt32(txtCodigo.Text);
                dado.Unidade = txtUnidade.Text;



                model.Editar(dado);
                MessageBox.Show("Unidade editado com Sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Buscar(Unidades dado)
        {
            try
            {
                dado.Unidade = txtBuscar.Text;
                dgUnidades.DataSource = model.Buscar(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar dados na busca." + ex.Message);
            }
        }

    }
}
