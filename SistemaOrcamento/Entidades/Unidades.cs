using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Entidades
{
    public class Unidades
    {
        int id_unidade;
        string unidade;

        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
        public string Unidade { get => unidade; set => unidade = value; }
    }
}
