using System;

namespace testeTresParte3
{
    public class CalculaRendimento
    {
        decimal valorPresente;
        decimal taxaJuros;
        int periodoMes;

        public CalculaRendimento(decimal valorPresente, decimal taxaJuros, int periodoMes)
        {
            this.valorPresente = valorPresente;
            this.taxaJuros = taxaJuros;
            this.periodoMes = periodoMes;
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

        public int PeriodoMes
        {
            get { return periodoMes; }
            set { periodoMes = value; }
        }

        public decimal CalcularValorFuturo()
        {
            decimal valorFuturo = valorPresente * (decimal)Math.Pow((1 + (double)taxaJuros), periodoMes);
            return Math.Round(valorFuturo, 2);
        }

        public decimal ValorJuros()
        {
            decimal valorFuturo = CalcularValorFuturo();
            decimal valorJuros = valorFuturo - valorPresente;
            return Math.Round(valorJuros, 2);
        }
    }
}