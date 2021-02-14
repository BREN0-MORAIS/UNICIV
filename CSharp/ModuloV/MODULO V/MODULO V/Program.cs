using System;

namespace MODULO_V
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ele passa o texto para o Metodo de exetnsão
                "000000".ENumCpf();
                //blocos de códigos
                var valor = 10;
                var retorno = valor / 0;
            }
            catch (Exception e)
            {
                //tratamento caso houver uma exeção
            }
            finally
            {
                //executado dado que haja uma exeção ou não
            }
        }
    }
}
