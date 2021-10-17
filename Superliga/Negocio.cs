using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superliga
{
    public class Negocio
    {
        public class Usuario
        {
            public static List<Entidades.Usuario> consultaTodos(string path)
            {
                List<Entidades.Usuario> lUsuario = new List<Entidades.Usuario>();
                try
                {
                    lUsuario = Datos.Usuario.consultaTodos(path);
                    return lUsuario;
                }
                catch
                {
                    return null;
                }
                
            }
                 
        }
    }
}
