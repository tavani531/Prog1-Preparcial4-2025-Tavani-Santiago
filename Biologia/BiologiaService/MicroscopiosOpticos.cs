using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologiaService
{
    public class MicroscopiosOpticos:Instrumentos
    {
        public int AumentoMaximo { get; set; }
        public Enums.TecnologiaEnfoque TecnologiaEnfoque { get; set; }
        public float Resolucion { get; set; }
    }
}
