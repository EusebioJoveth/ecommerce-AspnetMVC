using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidade
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public Marca oMarca { get; set; }
        public Categoria oCategoria { get; }
        public decimal preco { get; set; }
        public int stock { get; set; }
        public string urlImage { get; set; }
        public string nomeImagem { get; set; }
        public bool activo { get; set; }
    }
}
