using System;
using TesteDeMesaParte3.testeTresParte1;

namespace TesteDeMesaParte3
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaParte1 valores = new CalculaParte1(0m, 0m, DateTime.MinValue);
            CapturaValores capturaValores = new CapturaValores();
            CapturaValores.CapturaValoresFinanceiros(valores);
            capturaValores.ExibeValorFuturo(valores);
        }
    }
}
