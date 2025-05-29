using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologiaService
{
    public class Resultado
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int ValorNumerico { get; set; }
        public DateTime FechaResultado { get; set; }
    }
}
