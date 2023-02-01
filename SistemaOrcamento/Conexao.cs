using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento
{
    public class Conexao
    {
        string conexao = "SERVER=localhost; DATABASE=orcamento; UID=root; PWD=;";//string de conexão que contem nome db, usuario e senha

        public MySqlConnection con = null;

        public void AbrirConexão()
        {
            try
            {
                con = new MySqlConnection(conexao);//abre a conexão que e string
                con.Open(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro do conectar." + ex.Message);//mostra erro de conectar
            }
        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);//abre a conexão que e string
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro fechar conexao." + ex.Message);//mostra erro em encerrar conexão
            }
        }
    }


}
