using System;

namespace TesteDeMesaDois.TesteParte4
{
    public class CalculaParte2
    {
        private decimal valorPresente;
        private decimal taxaJurosMensal;
        private int periodoMes;

        public CalculaParte2(decimal valorPresente, decimal taxaJurosMensal, int periodoMes)
        {
            this.valorPresente = valorPresente;
            this.taxaJurosMensal = taxaJurosMensal;
            this.periodoMes = periodoMes;
        }

        public decimal ValorPresente
        {
            get { return valorPresente; }
            set { valorPresente = value; }
        }

        public decimal TaxaJurosMensal
        {
            get { return taxaJurosMensal; }
            set { taxaJurosMensal = value; }
        }

        public int PeriodoMes
        {
            get { return periodoMes; }
            set { periodoMes = value; }
        }

        public decimal CalcularValorFuturo(decimal currentValor, int periods = 1)
        {
            decimal fator = (decimal)Math.Pow((1 + (double)taxaJurosMensal), periods);
            decimal valorFuturo = currentValor * fator;
            return Math.Round(valorFuturo, 2);
        }

        public decimal FazResgate(decimal valorAcumuladoMes)
        {
            decimal valorResgate = 0;
            string resposta;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nDeseja fazer um resgate neste mês? (S/N): ");
                Console.ResetColor();
                resposta = Console.ReadLine().ToUpper();

                if (resposta == "S")
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Digite o valor do resgate: R$ ");
                        Console.ResetColor();
                        if (decimal.TryParse(Console.ReadLine(), out valorResgate))
                        {
                            if (valorResgate > valorAcumuladoMes)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valor de resgate maior que o valor disponível em conta. Tente novamente.");
                                Console.ResetColor();
                            }
                            else if (valorResgate < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("O valor de resgate não pode ser negativo. Tente novamente.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Resgate de R$ {valorResgate:N2} realizado com sucesso.");
                                Console.ResetColor();
                                return valorAcumuladoMes - valorResgate;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Entrada inválida. Por favor, digite um número para o resgate.");
                            Console.ResetColor();
                        }
                    }
                }
                else if (resposta == "N")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Nenhum resgate realizado neste mês.");
                    Console.ResetColor();
                    return valorAcumuladoMes;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida. Por favor, digite 'S' para Sim ou 'N' para Não.");
                    Console.ResetColor();
                }
            }
        }
    }
}