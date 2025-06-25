using System;
using System.Collections.Generic;
using TesteDeMesaDois.TesteParte4;
using testeTresParte3; // Certifique-se de que esta linha esteja presente para acessar suas classes

namespace TesteDeMesaParte3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione qual exercício deseja rodar:");
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("4 - Sair");
                Console.Write("Sua escolha: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        // Código existente do Exercício 1
                        TesteDeMesaParte3.testeTresParte1.CalculaParte1 calculadoraParte1 = new TesteDeMesaParte3.testeTresParte1.CalculaParte1(0m, 0m, DateTime.MinValue);
                        TesteDeMesaParte3.testeTresParte1.CapturaValores capturaValoresParte1 = new TesteDeMesaParte3.testeTresParte1.CapturaValores();

                        TesteDeMesaParte3.testeTresParte1.CapturaValores.CapturaValoresFinanceiros(calculadoraParte1);
                        capturaValoresParte1.ExibeValorFuturo(calculadoraParte1);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        // Código existente do Exercício 2
                        TesteDeMesaDois.TesteParte4.CalculaParte2 calculadoraParte4 = new TesteDeMesaDois.TesteParte4.CalculaParte2(0m, 0m, 0);
                        TesteDeMesaDois.TesteParte4.exibeConsoleParte2 exibeConsoleParte4 = new TesteDeMesaDois.TesteParte4.exibeConsoleParte2();

                        exibeConsoleParte4.CapturaValoresIniciais(calculadoraParte4);
                        decimal valorInicialParte4 = calculadoraParte4.ValorPresente;
                        decimal taxaJurosParte4 = calculadoraParte4.TaxaJurosMensal;
                        int periodoParte4 = calculadoraParte4.PeriodoMes;

                        exibeConsoleParte4.SimularRendimentoMensal(calculadoraParte4);
                        exibeConsoleParte4.ExibirResultadosFinais(valorInicialParte4, taxaJurosParte4, periodoParte4, calculadoraParte4.ValorPresente);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("--- Executando Teste Parte 2 ---");
                        CalculaRendimento calculadoraParte2 = new CalculaRendimento(0, 0, 0);
                        ExibeConsoleParte3 exibeConsoleParte2 = new ExibeConsoleParte3();
                        exibeConsoleParte2.SolicitarEntradaParte2(calculadoraParte2);
                        exibeConsoleParte2.ExibirResultadosParte2(
                            calculadoraParte2.ValorPresente,
                            calculadoraParte2.TaxaJuros,
                            calculadoraParte2.PeriodoMes
                        );
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa. Pressione qualquer tecla para fechar.");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}