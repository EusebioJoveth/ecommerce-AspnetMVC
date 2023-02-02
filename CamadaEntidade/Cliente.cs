using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidade
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string senha { get; set; }
        public bool reestablecer { get; set; }
    }
}
