using System;



namespace ModuloIII
{

 public  class Cliente
 {

        public const decimal RENDA_MINiMA_PREMIUM = 2500;
        public const decimal VALOR_MINIMO_EM_COMPRAS_PREMIUM = 5000;
        public const decimal RENDA_MINIMA_MASTER = 5000;
        public const decimal RENDA_MINIMA_EM_COMPRAS_MASTER = 8000;
        public int Codigo { get ; private set; }
        public string Nome { get; set ; }
        public decimal RendaMensal { get ;  set ; }
        public ENivelClassificacao NivelClassificacao { get ; set; }
        public string[] Emails { get; set; }
  

        //implicita -> possui o metodo ou  construtor s� que n�o esta visivel Expliita-> esta exposto 
        public Cliente(int codigo, string nome, decimal  rendaMensal, string[] email)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.RendaMensal = rendaMensal;
            this.Emails = email;

            NivelClassificacao = DefinirClassificacao();
  
        }

        public bool PromoverClienteParaPremium(decimal valorCompras)
        {
            if(VALOR_MINIMO_EM_COMPRAS_PREMIUM >= valorCompras && NivelClassificacao == ENivelClassificacao.Convencional)
            {

                NivelClassificacao = ENivelClassificacao.Premium;
                return true;
            }
            return false;
        }
        public bool PromoverMaster(decimal valorCompras)
        {
            if (valorCompras >= RENDA_MINIMA_EM_COMPRAS_MASTER)
            {

                NivelClassificacao = ENivelClassificacao.Master;
                return true;
            }
            return false;
        }

        private ENivelClassificacao DefinirClassificacao()
        {
            if (RendaMensal >= RENDA_MINIMA_MASTER)
            {
                return ENivelClassificacao.Master;
            }
            else if (RendaMensal >= RENDA_MINiMA_PREMIUM)
            {
                return ENivelClassificacao.Premium;
            }
            return ENivelClassificacao.Convencional;
        }
    }
}