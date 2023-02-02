using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidade
{
    public class Venda
    {
        public int idVenda { get; set; }
        public int idCliente { get; set; }
        public int totalProduto { get; set; }
        public string contacto { get; set; }
        public string idDistrito { get; set; }
        public string telefone { get; set; }
        public string direcao { get; set; }
        public string dataTexto { get; set; }
        public string idTransacao { get; set; }

        public List<DetalheVenda> oDetalheVenda { get; set; }
    }
}
