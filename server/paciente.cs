using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class paciente:pessoa
    {
   
        public String CPF{ get; set; }
        public String telefone { get; set; }
        public DateTime dtNacimento { get; set; }
        public String endereco  { get; set; }
    }
}
