using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Entidades
{
    public class Produtos
    {
        int id_produto;
        string codigo;
        string nome;
        string descricao;
        int id_fornecedor;
        int id_unidade;
        decimal valor;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}
