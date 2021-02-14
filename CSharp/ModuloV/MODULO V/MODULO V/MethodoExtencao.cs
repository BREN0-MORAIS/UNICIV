using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULO_V
{
    public static class MethodoExtencao
    {
        public static bool ENumCpf(this string texto)
        {
            return texto.Length == 11;
        }
        
    }
}
