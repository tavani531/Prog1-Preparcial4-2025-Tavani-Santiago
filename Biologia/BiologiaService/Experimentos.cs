using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologiaService
{
    public class Experimentos
    {
        public int Codigo { get; set; }
        public string NombreInvestigador { get; set; }
        public DateTime FechaInicio { get; set; }
        public List<Instrumentos> InstrumentosUtilizados { get; set; }
        public Resultado Resultado { get; set; }

    }
}
