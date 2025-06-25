using System;

namespace TesteDeMesaParte3.testeTresParte1
{
    public class CapturaValores
    {
        public static void CapturaValoresFinanceiros(CalculaParte1 valores)
        {
            Console.Write("Digite o valor para investimento: R$");
            valores.ValorPresente = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            valores.TaxaJuros = Convert.ToDecimal(Console.ReadLine()) / 100m;

            Console.Write("Digite a data final para seu investimento (dd/mm/aaaa): ");
            valores.DataFinalInvestimento = DateTime.Parse(Console.ReadLine());
        }

        public void ExibeValorFuturo(CalculaParte1 valores)
        {
            DateTime dataAtualSistema = DateTime.Now.Date;

            TimeSpan diferencaDatas = valores.DataFinalInvestimento - dataAtualSistema;
            int periodoMeses = (int)Math.Ceiling(diferencaDatas.TotalDays / 30.0);

            int totalDias = diferencaDatas.Days;
            int meses = 0;
            int dias = 0;
            string periodoFormatado;


            if (totalDias < 0)
            {
                periodoFormatado = "0 meses e 0 dias (data de investimento já ultrapassada)";
            }
            else
            {
                meses = totalDias / 30;
                dias = totalDias % 30;

                periodoFormatado = $"{meses} mes{(meses != 1 ? "es" : "")} e {dias} dia{(dias != 1 ? "s" : "")}";
            }


            decimal valorFuturo = valores.CalcularValorFuturo();
            Console.Clear();

            Console.WriteLine($"\n--- Detalhes do Investimento ---");
            Console.WriteLine($"O valor investido foi de: R${valores.ValorPresente:F2}");
            Console.WriteLine($"A taxa é de {valores.TaxaJuros:P2} ao mês.");
            Console.WriteLine($"O período de investimento é de: {periodoFormatado}");
            Console.WriteLine($"O valor futuro do investimento é: R${valorFuturo:F2}");
        }
    }
}