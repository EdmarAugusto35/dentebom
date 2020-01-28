using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Consulta
    {
     public int id { get; set; }
        public string motivo { get; set; }
        public DateTime dtconsulta { get; set; }
        public string receita { get; set; }
        public string diagnostico { get; set; }
        public DateTime dtretorno { get; set; }
        public string motivoR { get; set; }
      
    }
}
