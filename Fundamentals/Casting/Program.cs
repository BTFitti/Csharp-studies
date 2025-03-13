using System.Globalization;
/*
Casting (ou conversão de tipo) é o processo de converter um valor de um tipo de dado para outro tipo.

Existem dois tipos principais de casting em C#:

Casting implícito (implícito ou automático)
Casting explícito (explícito)

O casting explícito ocorre quando você deseja converter um tipo para outro e há risco de perda de dados,
 ou quando o compilador não consegue fazer isso automaticamente.

O casting implícito acontece automaticamente quando não há risco de perda de dados. 
Geralmente, é feito quando você converte tipos menores para tipos maiores.

*/

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            //Casting explicito

            double decimalNum = 10.5;
            int num = (int)decimalNum; // Casting explícito (perde a parte decimal)
            Console.WriteLine(num); // Saída: 10

            int intNumber = 100;
            double doubleNumber = intNumber;  // Casting implícito de int para double
            Console.WriteLine(doubleNumber.ToString("F2",CI));  // Saída: 100.0

        }
    }
}