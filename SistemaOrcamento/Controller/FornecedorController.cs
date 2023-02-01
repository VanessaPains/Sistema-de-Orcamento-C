using MySql.Data.MySqlClient;
using SistemaOrcamento.Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.Controller
{
    public class FornecedorController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();//objeto instanciado. par usar conectar e desconetar

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("SELECT * FROM fornecedores order by id_fornecedor desc", con.con);  
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                adapter.SelectCommand = sql;//retorno em linhas
                DataTable dt = new DataTable();//guarda um tabela os dados
                adapter.Fill(dt);//preencher os dados listados na tabela em forma de linhas
                return dt;//retorna a tabela preenchida
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
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("UPDATE fornecedores SET cnpj = @cnpj, nome = @nome, telefone = @telefone, endereco = @endereco WHERE id_fornecedor = @id", con.con);
                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@id", dado.Id_fornecedor);

                sql.ExecuteNonQuery();
                con.FecharConexao();    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar." + ex.Message);
                con.FecharConexao();
            }
        }

        public DataTable Buscar(Fornecedores dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("SELECT * FROM fornecedores WHERE nome LIKE @nome OR cnpj LIKE @cnpj", con.con);
                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj + "%");
                sql.Parameters.AddWithValue("@nome", dado.Nome + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                adapter.SelectCommand = sql;//retorno em linhas
                DataTable dt = new DataTable();//guarda um tabela os dados
                adapter.Fill(dt);//preencher os dados listados na tabela em forma de linhas
                return dt;//retorna a tabela preenchida
            }
            catch (Exception ex)
            {
                throw ex;
                con.FecharConexao();
            }
        }


        public void Excluir(Fornecedores dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("DELETE FROM fornecedores WHERE id_fornecedor = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id_fornecedor);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir." + ex.Message);
                con.FecharConexao();
            }
        }

        public void Inserir(Fornecedores dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("INSERT INTO fornecedores (cnpj, nome, telefone, endereco) VALUES (@cnpj, @nome, @telefone, @endereco)", con.con);
                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
