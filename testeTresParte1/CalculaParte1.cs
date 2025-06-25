using System;

namespace TesteDeMesaParte3.testeTresParte1
{
    public class CalculaParte1
    {
        private decimal valorPresente;
        private decimal taxaJuros;
        private DateTime dataFinalInvestimento;

        public CalculaParte1(decimal valorPresente, decimal taxaJuros, DateTime dataFinalInvestimento)
        {
            this.valorPresente = valorPresente;
            this.taxaJuros = taxaJuros;
            this.dataFinalInvestimento = dataFinalInvestimento;
        }

        public decimal ValorPresente
        {
            get { return valorPresente; }
            set { valorPresente = value; }
        }

        public decimal TaxaJuros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        public DateTime DataFinalInvestimento
        {
            get { return dataFinalInvestimento; }
            set { dataFinalInvestimento = value; }
        }

        public decimal CalcularValorFuturo()
        {
            // Fórmula do valor futuro: VF = VP * (1 + i)^n
            DateTime dataAtualSistema = DateTime.Now.Date;

            TimeSpan diferencaDatas = DataFinalInvestimento - dataAtualSistema;
            int diasEntreDatas = diferencaDatas.Days;

            // i_diaria = (1 + i_mensal)^(1/30) - 1
            decimal taxaJurosDiaria = (decimal)Math.Pow((double)(1 + TaxaJuros), 1.0 / 30.0) - 1;

            decimal valorFuturo = valorPresente * (decimal)Math.Pow((double)(1 + taxaJurosDiaria), diasEntreDatas);
            return valorFuturo;
        }
    }
}