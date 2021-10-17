using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superliga
{
    public class Entidades
    {
        public class Usuario
        {
            public string nombre { get; set; }
            public int edad { get; set; }
            public string equipo { get; set; }
            public string estadoCivil { get; set; }
            public string nivelEstudio { get; set; }
        }

        public class UsuarioAux
        {
            public string nombre { get; set; }
            public int cantidad { get; set; }
        }

        public class clubes
        {
            public string equipo { get; set; }
            public int cantidadSocios { get; set; }
            public decimal promedioEdad { get; set; }
            public int menorEdad { get; set; }
            public int mayorEdad { get; set; }
        }
    }
}
