using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidade
{
    public class DetalheVenda
    {
        public int idDetalheVenda { get; set; }
        public int idVenda { get; set; }
        public Produto oProduto { get; set; }
        public int quantidade { get; set; }
        public decimal total { get; set; }
        public string idTransacao { get; set; }
    }
}
