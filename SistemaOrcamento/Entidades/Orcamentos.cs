using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Entidades
{
    public class Orcamentos
    {
        int id_orcamento;
        string numero_orcamento;
        int id_produto;
        int id_cliente;
        int quantidade;
        decimal valor_total;

        public int Id_orcamento { get => id_orcamento; set => id_orcamento = value; }
        public string Numero_orcamento { get => numero_orcamento; set => numero_orcamento = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Valor_total { get => valor_total; set => valor_total = value; }
    }
}
