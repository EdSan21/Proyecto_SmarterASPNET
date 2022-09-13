using System;
using System.Collections.Generic;
using System.Text;

namespace SerieModel.Modelos
{
    public class SerieModel
    {
        public int idserie { get; set; }
        public string nombre { get; set; }
        public string categorías { get; set; }
        public string idioma { get; set; }
        
    }

    public class Director
    {
        public int iddirector { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nacionalidad { get; set; }
        public string edad { get; set; }
    }

    public class Respuesta
    {
        public int id { get; set; }
        public string mensaje_resultado { get; set; }
    }
}
