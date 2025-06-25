using System;

namespace testeTresParte3
{
    public class ExibeConsoleParte3
    {
        public void SolicitarEntradaParte2(CalculaRendimento valoresParte2)
        {
            Console.Write("Digite o valor presente:");
            valoresParte2.ValorPresente = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a taxa de juros:");
            valoresParte2.TaxaJuros = Convert.ToDecimal(Console.ReadLine()) / 100;

            Console.Write("Digite o período em meses:");
            valoresParte2.PeriodoMes = Convert.ToInt32(Console.ReadLine());
        }

        public void ExibirResultadosParte2(decimal valorPresente, decimal taxaJuros, int periodoMes)
        {
            Console.WriteLine($"\nValor Presente R$ {valorPresente:N2}");

            Console.WriteLine("========================================================================");
            Console.WriteLine("| Mês | Valor Investido | Taxa Juros |   Rendimento   | Rend. Líquido  |");
            Console.WriteLine("========================================================================");

            decimal rendimentoAtual = valorPresente;
            decimal jurosAcumulados = 0;

            for (int i = 1; i <= periodoMes; i++)
            {
                decimal jurosDoMes = rendimentoAtual * taxaJuros;
                jurosAcumulados += jurosDoMes;

                rendimentoAtual += jurosDoMes;

                Console.WriteLine($"| {i, 3} | {valorPresente, 14:N2} |{taxaJuros * 100,10:F2}% | R$ {rendimentoAtual,10:N2} | R$ {jurosAcumulados,9:N2} |");
            }
            Console.WriteLine("========================================================================");
        }
    }
}