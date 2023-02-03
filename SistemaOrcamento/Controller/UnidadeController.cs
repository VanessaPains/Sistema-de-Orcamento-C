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
    public class UnidadeController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();//objeto instanciado. par usar conectar e desconetar

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("SELECT * FROM unidades order by unidade asc", con.con);
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

        public void Editar(Unidades dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("UPDATE unidades SET unidade = @unidade WHERE id_unidade = @id", con.con);
                sql.Parameters.AddWithValue("@unidade", dado.Unidade);//parametros para campos da taela
                sql.Parameters.AddWithValue("@id", dado.Id_unidade);//parametros para campos da taela

                sql.ExecuteNonQuery();
                con.FecharConexao();//fecha a conexao
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar." + ex.Message);//mostra menssagem em caso de erro
                con.FecharConexao();//fecha a conexao
            }
        }

        public DataTable Buscar(Unidades dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("SELECT * FROM unidades WHERE unidade LIKE @unidade OR id_unidade LIKE @id", con.con);
                sql.Parameters.AddWithValue("@unidade", dado.Unidade + "%");
                sql.Parameters.AddWithValue("@id", dado.Id_unidade + "%");

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


        public void Excluir(Unidades dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("DELETE FROM unidades WHERE id_unidade = @id", con.con);//
                sql.Parameters.AddWithValue("@id", dado.Id_unidade);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir." + ex.Message);
                con.FecharConexao();
            }
        }

        public void Inserir(Unidades dado)
        {
            try
            {
                con.AbrirConexão();//abrir conexao
                sql = new MySqlCommand("INSERT INTO unidades (unidade) VALUES (@unidade)", con.con);
                sql.Parameters.AddWithValue("@unidade", dado.Unidade);//parametros para campos da taela

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
