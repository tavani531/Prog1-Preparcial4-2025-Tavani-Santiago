using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologiaService
{
    public class Espectrometros : Instrumentos
    {
        public string RangoMedicion { get; set; }
        public Enums.TipoEspectrometro TipoEspectrometro { get; set; }
        public float Presicion { get; set; }
    }
}
