using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploConta
{
    public class Conta
    {
        public decimal Saldo { get; protected set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public virtual bool Saque(decimal valor)
        {
            if(valor<= Saldo)
            {
                Saldo -= valor;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
