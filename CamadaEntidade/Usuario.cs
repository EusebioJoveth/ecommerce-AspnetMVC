using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidade
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string eamil { get; set; }
        public string password { get; set; }
        public bool restablecer { get; set; }
        public bool activo { get; set; }
    }
}
