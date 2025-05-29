namespace BiologiaService
{
    public class Plataforma
    {
        int nivelPresicion = 50;

        public int CalcularNivelPresicion(Instrumentos instrumento)
        {
            if (instrumento is MicroscopiosOpticos microscopiosOpticos)
            {
                if (microscopiosOpticos.Resolucion < 100)
                {
                    nivelPresicion += 15;
                }
                if (microscopiosOpticos.TecnologiaEnfoque == Enums.TecnologiaEnfoque.Automático)
                {
                    nivelPresicion += 10;
                }
            }
            else if (instrumento is Espectrometros espectrometros)
            {
                if (espectrometros.Presicion > 0.8)
                {

                    nivelPresicion += 20;
                }
                if (espectrometros.TipoEspectrometro == Enums.TipoEspectrometro.Infrarrojo)
                {
                    nivelPresicion += 5;
                }
            }

            return nivelPresicion;
        }
        public List<Experimentos> ListaExperimentos { get; set; } = new();
        public List<Instrumentos> ListaInstrumentos { get; set; } = new();
        int contRegistroResultados = 1;
        public (bool,string) RegistroResultados(int codExperimento, string descripcion, int resultado)
        {
            var experimento=ListaInstrumentos.FirstOrDefault(x => x.Codigo == codExperimento);

            if (experimento == null)
            {
                return (false, "El experimento no existe");
            }
            if (resultado < 0)
            {
                return (false, "El resultado es menor a 0");
            }
            Resultado resultado1 = new Resultado
            {
                Codigo = contRegistroResultados,
                Descripcion = descripcion,
                ValorNumerico = resultado,
                FechaResultado = DateTime.Today
            };
            contRegistroResultados++;

            return (true, "Registro registrado con éxito");

        }
    }
}
