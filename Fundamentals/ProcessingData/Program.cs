using System.Globalization;
/*
Processamento é o ato de manipular dados ou executar operações com base em entradas, cálculos ou outras lógicas dentro do programa.
Exemplos de processamento em C# 

Operações matemáticas: Soma, subtração, multiplicação, divisão, etc.
Processamento de strings: Concatenar, dividir, formatar, etc.
Estruturas de controle: if, switch, laços for, while para controlar o fluxo de dados.

*/
namespace ProcessingData
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int sum = num1 + num2;
            Console.WriteLine($"A soma de {num1} e {num2} é: {sum}");
            
            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;
            area = (b1 + b2) / 2.0 * h;
            Console.WriteLine(area);
            
        }
    }
}