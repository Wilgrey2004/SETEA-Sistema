using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETEA_Sistema.Utilidades
{
    public static class MyConversorGenerico
    {
        public static T DeStringANumero<T>(string input) where T : struct, IConvertible 
        {
            if (input.Equals(""))
            {
                throw new ArgumentException(nameof(input), "El string no puede venir vacio");

            }

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch
            {
                throw new ArgumentException(nameof(input), "No Se Puede convertir");
            }
        }
    }
}
