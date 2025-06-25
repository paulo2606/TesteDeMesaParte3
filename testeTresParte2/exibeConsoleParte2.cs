using System;

namespace TesteDeMesaDois.TesteParte4
{
    public class exibeConsoleParte2
    {
        public void CapturaValoresIniciais(CalculaParte2 valores)
        {
            decimal valorInvestimento;
            decimal taxaJuros;
            int periodo;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- Simulação de Rendimento Mensal ---");
            Console.ResetColor();

            while (true)
            {
                Console.Write("Digite o valor para investimento inicial: R$ ");
                if (decimal.TryParse(Console.ReadLine(), out valorInvestimento) && valorInvestimento >= 0)
                {
                    valores.ValorPresente = valorInvestimento;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, digite um valor numérico positivo.");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                Console.Write("Digite a taxa de juros mensal: ");
                if (decimal.TryParse(Console.ReadLine(), out taxaJuros) && taxaJuros >= 0)
                {
                    valores.TaxaJurosMensal = taxaJuros / 100m;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, digite um valor numérico positivo para a taxa.");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                Console.Write("Digite o período total de meses para a simulação: ");
                if (int.TryParse(Console.ReadLine(), out periodo) && periodo > 0)
                {
                    valores.PeriodoMes = periodo;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo para o período.");
                    Console.ResetColor();
                }
            }
        }

        public void SimularRendimentoMensal(CalculaParte2 calculadora)
        {
            Console.Clear();
            decimal valorAtual = calculadora.ValorPresente;

            for (int mes = 1; mes <= calculadora.PeriodoMes; mes++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"--- Simulação Mês {mes} de {calculadora.PeriodoMes} ---");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Valor Inicial no Mês {mes}: R$ {valorAtual:N2}");
                Console.WriteLine($"Taxa de Juros Mensal: {calculadora.TaxaJurosMensal * 100:F2}%");
                Console.ResetColor();

                decimal rendimentoMes = valorAtual * calculadora.TaxaJurosMensal;
                decimal valorAcumuladoMes = valorAtual + rendimentoMes;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rendimento do Mês: R$ {rendimentoMes:N2}");
                Console.WriteLine($"Valor Acumulado (antes do resgate): R$ {valorAcumuladoMes:N2}");
                Console.ResetColor();

                valorAtual = calculadora.FazResgate(valorAcumuladoMes); 

                calculadora.ValorPresente = valorAtual;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nValor Final no Mês {mes} (após resgate): R$ {valorAtual:N2}");
                Console.ResetColor();

                if (mes < calculadora.PeriodoMes)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPressione qualquer tecla para ir para o próximo mês...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }

        public void ExibirResultadosFinais(decimal valorPresenteInicial, decimal taxaJurosMensal, int periodoMes, decimal valorFinalAtual)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Valor Inicial do Investimento: R$ {valorPresenteInicial:N2}");
            Console.WriteLine($"Taxa de Juros Mensal: {taxaJurosMensal * 100:F2}%");
            Console.WriteLine($"Período Total Simulado: {periodoMes} meses");
            Console.WriteLine($"Valor Final Acumulado: R$ {valorFinalAtual:N2}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}