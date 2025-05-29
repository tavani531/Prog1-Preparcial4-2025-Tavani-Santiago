using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BiologiaService
{
    public abstract class Instrumentos
    {
        private static int ContCod = 1;
        public int Codigo { get; private set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }
        public int Precio { get; set; }
        public DateTime FechaCalibracion { get; set; }

        public Instrumentos()
        {
            Codigo = ContCod;
            ContCod++;
        }
    }
}
