using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    public static class PersonaExtensions
    {
        public static void Validar(this Persona persona)
        {
            MayorDeEdad(persona);
        }

        private static void MayorDeEdad(Persona persona)
        {
            if (!persona.Edad.HasValue || persona.Edad.Value < 18)
            {
                throw new Exception("Persona menor de edad");            
            }        
        }
    }
}
