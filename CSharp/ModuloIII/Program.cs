using System;

namespace ModuloIII
{
    class Program
    {
            public string[] emails = new string[] { "pedro@hotmail.com", "Joao@hotmail.com", "paula@hotmail.com" };
        static void Main(string[] args)
        {
       
 
            //Cliente cliente1 = new Cliente(1, "Breno", 2500);
            ////cliente1.NivelClassificacao = ENivelClassificacao.Master;
            //Cliente cliente2 = new Cliente(2, "Maria", 1500);
            ////Console.WriteLine(ENivelClassificacao.Convencional);
            //Console.WriteLine(cliente1.NivelClassificacao == ENivelClassificacao.Convencional);
            //Console.WriteLine(cliente1.NivelClassificacao == ENivelClassificacao.Master);
            //Console.WriteLine(cliente1.NivelClassificacao == ENivelClassificacao.Premium);
            //if (cliente1.NivelClassificacao == ENivelClassificacao.Convencional)
            //{

            //}

            //Console.WriteLine(cliente1.Nome);
            //Console.WriteLine(cliente2.Nome);
           //Cliente cliente = new Cliente();
           //Cliente Cliente2 =  new Cliente();

           ////cliente 1
           //     //cliente.Codigo1 = 1;
           //     //cliente.Nome1 = "Jõa Silva";
           //     cliente.RenaMensal = 2500;
           //     cliente.ClientePremium = true; 
           ////cliente 2 
           //     //Cliente2.Codigo1 = 2;
           //     //Cliente2.Nome1 = "Maria";
           //     Cliente2.RenaMensal = 5000;
           //     Cliente2.ClientePremium = false; 

           //     //Console.WriteLine($@"
           //     //|-------------Informações Cliente1---------------------
           //     //Nome: {cliente.Nome1}
           //     //Código: {cliente.Codigo1}
           //     //");
        }

        public string ResgatarListaEmails(string[] vet)
        {
            var listarEmails = "Cliente Possui " + emails;
            foreach(var item in listarEmails)
            {
                listarEmails += emails;
            }

            return listarEmails;
        }
    }
}
