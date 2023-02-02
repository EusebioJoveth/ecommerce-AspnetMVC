using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidade
{
    public class Carrinho
    {
        public int iCarrinho { get; set; }
        public Cliente oCliente { get; set; }
        public Produto oProduto { get; set; }
        public int quantidade { get; set; }
    }
}
