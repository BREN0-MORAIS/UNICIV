using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloIII
{
    public static class ValidatorCPF
    {
        public static bool Validar(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
