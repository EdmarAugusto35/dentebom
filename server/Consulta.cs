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
        public String motivo { get; set; }
        public DateTime dtconsulta { get; set; }
        public String receita { get; set; }
        public String diagnostico { get; set; }
        public DateTime dtretorno { get; set; }
        public String motivoR { get; set; }
        public int idpaciente { get; set; }
        public int iddentista { get; set; }

    }
}
