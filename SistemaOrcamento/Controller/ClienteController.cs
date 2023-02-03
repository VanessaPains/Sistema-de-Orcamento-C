using MySql.Data.MySqlClient;
using SistemaOrcamento.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.Controller
{
    public class ClienteController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();//objeto instanciado. par usar conectar e desconetar

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("SELECT * FROM clientes order by id_cliente desc", con.con);
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

        public void Editar(Clientes dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("UPDATE clientes SET nome = @nome, telefone = @telefone, email = @email WHERE id_cliente = @id", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);//parametros para campos da taela
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);//parametros para campos da taela
                sql.Parameters.AddWithValue("@email", dado.Email);//parametros para campos da taela
                sql.Parameters.AddWithValue("@id", dado.Id_cliente);//parametros para campos da taela

                sql.ExecuteNonQuery();
                con.FecharConexao();//fecha a conexao
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar." + ex.Message);//mostra menssagem em caso de erro
                con.FecharConexao();//fecha a conexao
            }
        }

        public DataTable Buscar(Clientes dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("SELECT * FROM clientes WHERE nome LIKE @nome OR id_cliente LIKE @id", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome + "%");
                sql.Parameters.AddWithValue("@id", dado.Id_cliente + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql);
                adapter.SelectCommand = sql;//retorno em linhas
                DataTable dt = new DataTable();//guarda um tabela os dados
                adapter.Fill(dt);//preencher os dados listados na tabela em forma de linhas
                return dt;//retorna a tabela preenchida
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Erro ao Excluir." + ex.Message);
                con.FecharConexao();
            }
        }


        public void Excluir(Clientes dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("DELETE FROM clientes WHERE id_cliente = @id", con.con);//
                sql.Parameters.AddWithValue("@id", dado.Id_cliente);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir." + ex.Message);
                con.FecharConexao();
            }
        }

        public void Inserir(Clientes dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("INSERT INTO clientes (nome, telefone, email) VALUES (@nome, @telefone, @email)", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);//parametros para campos da taela
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);//parametros para campos da taela
                sql.Parameters.AddWithValue("@email", dado.Email);//parametros para campos da taela

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
