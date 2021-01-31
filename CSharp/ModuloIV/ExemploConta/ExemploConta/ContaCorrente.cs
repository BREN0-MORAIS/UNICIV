using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ExemploConta
{
    public class ContaCorrente : Conta
    {
        public decimal Limite { get; private set; }

        override public bool Saque(decimal valor)
        {
            if (valor <= (Saldo + Limite))
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
        public  ContaCorrente()
        {
            
        }
    }
}
