using SistemaOrcamento.Controller;
using SistemaOrcamento.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Model
{
    public class UnidadeModel
    {
        UnidadeController controller = new UnidadeController();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Listar();//recebe metodo do controller chamada listar
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Salvar(Unidades dado)
        {
            try
            {
                controller.Inserir(dado);
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
                controller.Editar(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Unidades dado)
        {
            try
            {
                controller.Excluir(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Buscar(Unidades dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Buscar(dado);//recebe metodo do controller chamada listar
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
